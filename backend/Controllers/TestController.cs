using ProjectManagement.Models.Repositories;
using ProjectManagement.SCAO;
using ProjectManagement.SCAO.Aggregates;
using ProjectManagement.SCAO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManagement.Controllers.SCAO
{
    public class TestController : ApiController
    {
        protected EmpleadoAggregate empleadoAggregate;
        protected CalculadorCiclosService calculador;

        public dynamic Get()
        {
            return it_obtiene_los_empleados_asociados_a_un_proyecto_donde_arturo_rios_es_supervisor(37);
            //return it_obtiene_los_proyectos_funcionales_donde_arturo_rios_es_supervisor();
            //return it_obtiene_los_proyectos_externos_donde_arturo_rios_es_supervisor();
            //return cuando_un_usuario_no_es_supervisor_el_guard_lanza_una_exeption();
            //return it_obtiene_un_reporte_detallado_para_un_empleado_x();
            //return it_obtiene_los_empleados_dentro_de_las_intalaciones();
            //return it_obtiene_los_empleados_fuera_de_las_intalaciones();
        }

        protected dynamic it_obtiene_un_reporte_detallado_para_un_empleado_x()
        {
            string ssno = "111";
            DateTime startDate = new DateTime(2017, 1, 9);
            DateTime endDate = new DateTime(2017, 1, 17);

            empleadoAggregate = new EmpleadoAggregate(ssno);

            int countDiasLaborados = empleadoAggregate
                .countDiasLaboradosIntoRangoAgrupadosPorDias(startDate, endDate);

            var grupoPases = empleadoAggregate
                .getPasesIntoRangoAgrupadosPorDias(startDate, endDate);

            calculador = new CalculadorCiclosService(grupoPases);

            return new
            {
                totalDiasLaborados = countDiasLaborados,
                totalHorasLaborables = countDiasLaborados * 8,
                totalHorasLaboradas = calculador.getSumatoriaCiclosToHours().TotalHours,
                //pases = grupoPases,
                ciclos = calculador.getAllCiclosUsadosEnLaSumatoriaAgrupadosPorDia()
            };
        }

        protected dynamic it_obtiene_los_empleados_dentro_de_las_intalaciones()
        {
            return new MonitorService().getEmpleadosDentro();
        }

        protected dynamic it_obtiene_los_empleados_fuera_de_las_intalaciones()
        {
            return new MonitorService().getEmpleadosFuera();
        }

        protected dynamic cuando_un_usuario_no_es_supervisor_el_guard_lanza_una_exeption()
        {
            try
            {
                var db = new DataClassesDataContext();
                var anUser = db.Users.Where(u => u.Id == 1).Single();
                var guard = new SupervisorGuard();
                guard.assertThatIsSupervisor(anUser);

                return "Si eres supervisor";
            }

            catch (NotSupervisorException)
            {
                return "No eres supervisor";
            }
        }

        protected dynamic it_obtiene_los_proyectos_funcionales_donde_arturo_rios_es_supervisor()
        {
            var db = new DataClassesDataContext();
            var arturoRios = db.Users.Where(u => u.Id == 2).Single();
            var supervisorAggregate = new SupervisorAggregate(arturoRios);

            var r = supervisorAggregate.getProyectosFuncionales();

            return r;
        }

        protected dynamic it_obtiene_los_proyectos_externos_donde_arturo_rios_es_supervisor()
        {
            var db = new DataClassesDataContext();
            var arturoRios = db.Users.Where(u => u.Id == 2).Single();
            var supervisorAggregate = new SupervisorAggregate(arturoRios);

            return supervisorAggregate.getProyectosExternos();
        }

        protected dynamic it_obtiene_los_empleados_asociados_a_un_proyecto_donde_arturo_rios_es_supervisor(int projectoId)
        {
            var db = new DataClassesDataContext();
            var arturoRios = db.Users.Where(u => u.Id == 2).Single();
            var supervisorAggregate = new SupervisorAggregate(arturoRios);

            return supervisorAggregate.getSupervisadosByProyecto(projectoId);

        }

    }
}
