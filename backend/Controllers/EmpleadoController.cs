using ProjectManagement.SCAO.Aggregates;
using ProjectManagement.SCAO.Models;
using ProjectManagement.SCAO.Services;
using ProjectManagement.SCAO.TOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManagement.Controllers.SCAO
{
    [RoutePrefix("api/empleado")]
    public class EmpleadoController : ApiController
    {
        private EmpleadoAggregate empleadoAggregate;
        private CalculadorCiclosService calculador;
        private EmpleadoRepo empleadoRepo;

        public EmpleadoController()
        {
            empleadoRepo = new EmpleadoRepo();
        }

        [Route("{ssno}")]
        public Empleado Get(string ssno)
        {
            return empleadoRepo.find(ssno);
        }

        [Route("{ssno}/reporte")]
        [HttpGet]
        public dynamic getReporte(string ssno, [FromUri] Rango rango)
        {
            DateTime startDate = rango.minDate;
            DateTime endDate = rango.maxDate;

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
                totalHorasLaboradas = calculador.getSumatoriaCiclosToHours(),
                ciclos = calculador.getAllCiclosUsadosEnLaSumatoriaAgrupadosPorDia()
            };

        }

    }
}
