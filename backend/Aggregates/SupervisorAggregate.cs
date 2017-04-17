using ProjectManagement.Models.Repositories;
using ProjectManagement.SCAO.Models;
using ProjectManagement.SCAO.TOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Aggregates
{
    public class SupervisorAggregate
    {
        protected User user;
        protected DataClassesDataContext db;
        public SupervisorAggregate(User userAuth)
        {
            user = userAuth;
            db = new DataClassesDataContext();
        }
        public IEnumerable<Proyecto> getProyectosFuncionales()
        {
            return getProyectos(1);
        }

        public IEnumerable<Proyecto> getProyectosExternos()
        {
            return getProyectos(0);
        }

        protected IEnumerable<Proyecto> getProyectos(int funcional)
        {
            var proyectos = (
                from proyecto in db.Projects
                join grupo in db.Groups on proyecto.Code equals grupo.Code
                where
                    proyecto.Functional == funcional
                    && proyecto.IsActive == true
                    && grupo.Supervisor == user.Id
                select new Proyecto(proyecto.Id, proyecto.Code, proyecto.Name)
            );

            return proyectos;
        }

        public IEnumerable<Empleado> getSupervisadosByProyecto(int proyectoId)
        {
            var result = (
                from proyecto in db.Projects
                join grupo in db.Groups on proyecto.Code equals grupo.Code
                join p_u in db.Project_Users on proyecto.Id equals p_u.Project_Id
                join user in db.Users on p_u.User_Id equals user.Id into supervisados
                from supervisado in supervisados where supervisado.Id != user.Id
                where
                    proyecto.IsActive == true
                    && proyecto.Id == proyectoId
                select new Empleado(supervisado)
            );

            return result;
        }

    }
}