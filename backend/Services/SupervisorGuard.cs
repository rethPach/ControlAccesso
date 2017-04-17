using ProjectManagement.Models.Repositories;
using ProjectManagement.SCAO.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Services
{
    public class SupervisorGuard
    {
        protected SupervisorAggregate supervisorAggregate;
        protected DataClassesDataContext db;
        public SupervisorGuard()
        {
            db = new DataClassesDataContext();
        }

        public void assertThatIsSupervisor(User userLogin)
        {
            var supervisorX = (
                from grupo in db.Groups
                join proyecto in db.Projects on grupo.Code equals proyecto.Code
                where grupo.Supervisor == userLogin.Id
                select grupo.Supervisor
            ).Count();

            if (!isSupervisor(supervisorX)) throw new NotSupervisorException();
        }

        protected bool isSupervisor(int supervisorX)
        {
            return supervisorX > 0;
        }

    }

       
    
}