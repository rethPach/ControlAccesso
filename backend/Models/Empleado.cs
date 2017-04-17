using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Models
{
    public class Empleado
    {
        public Empleado() {}

        public Empleado(EMP empleado)
        {
            id = empleado.ID;
            ssno = empleado.SSNO;
            nombre = empleado.FIRSTNAME;
            apellido = empleado.LASTNAME;
            cedula = empleado.MIDNAME;
        }

        public Empleado(ProjectManagement.Models.Repositories.User user)
        {
            id = user.Id;
            ssno = user.IDyn;
            nombre = user.FirstName;
            apellido = user.LastName;
            departamento = user.Departmnt;
        }


        public int id { get; set; }

        public string ssno { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string cedula { get; set; }

        public IEnumerable<Pase> pases { get; set; }

        public string departamento { get; set; }
    }
}