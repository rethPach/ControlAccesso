using ProjectManagement.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Models
{
    public class Proyecto
    {
        public Proyecto(Project proyecto)
        {
            id = proyecto.Id;
            code = proyecto.Code;
            nombre = proyecto.Name;
        }

        public Proyecto(int idArg, string codeArg, string nombreArg)
        {
            id = idArg;
            code = codeArg;
            nombre = nombreArg;
        }

        public string code { get; set; }

        public string nombre { get; set; }

        public int id { get; set; }
    }
}