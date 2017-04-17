using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Models
{
    public class Supervisor
    {
        public Supervisor(ProjectManagement.Models.Repositories.User user)
        {
            id = user.Id;
            email = user.Email;
            ssno = user.IDyn;
            nombre = user.FirstName;
            apellido = user.LastName;
            departamento = user.Departmnt;
            username = user.UserName;
        }



        public string email { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string departamento { get; set; }

        public string username { get; set; }

        public string ssno { get; set; }

        public int id { get; set; }
    }
}