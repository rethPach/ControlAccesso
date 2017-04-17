using ProjectManagement.SCAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.TOs
{
    public class ProyectoSupervisados
    {
        public ProyectoSupervisados(ProjectManagement.Models.Repositories.Project proyecto, IEnumerable<ProjectManagement.Models.Repositories.User> supervisados)
        {
            this.proyecto = new Proyecto(proyecto);
            this.supervisados = supervisados.Select(s => new Empleado(s));
        }

        public Proyecto proyecto { get; protected set; }

        public IEnumerable<Empleado> supervisados { get; protected set; }
    }
}