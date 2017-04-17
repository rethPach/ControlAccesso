using ProjectManagement.Models.Repositories;
using ProjectManagement.Models.Services;
using ProjectManagement.SCAO.Aggregates;
using ProjectManagement.SCAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManagement.Controllers.SCAO
{
    [RoutePrefix("api/supervisor")]
    public class SupervisorController : ApiController
    {
        private SupervisorAggregate supervisorAggregate;
        private User supervisor;

        [Route("{id}/proyectosFuncionales")]
        [HttpGet]
        public IEnumerable<Proyecto> getProyectosFuncionales(int id)
        {
            supervisor = new UserServices().GetById(id);
            supervisorAggregate = new SupervisorAggregate(supervisor);
            return supervisorAggregate.getProyectosFuncionales();
        }

        [Route("{id}/proyectosExternos")]
        [HttpGet]
        public IEnumerable<Proyecto> getProyectosExternos(int id)
        {
            User supervisor = new UserServices().GetById(id);
            supervisorAggregate = new SupervisorAggregate(supervisor);
            return supervisorAggregate.getProyectosExternos();
        }

        [Route("{id}/proyectos/{proyectoId}")]
        [HttpGet]
        public IEnumerable<Empleado> getEmpleadosByProyecto(int id, int proyectoId)
        {
            User supervisor = new UserServices().GetById(id);
            supervisorAggregate = new SupervisorAggregate(supervisor);
            return supervisorAggregate.getSupervisadosByProyecto(proyectoId);
        }

    }
}
