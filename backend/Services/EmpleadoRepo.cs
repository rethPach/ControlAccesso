using ProjectManagement.SCAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Services
{
    public class EmpleadoRepo
    {
        protected SCAOContextDataContext db;
    
        public EmpleadoRepo()
        {
            db = new SCAOContextDataContext();
        }
        
        public Empleado find(string ssno)
        {
            return db.EMP.Where(e => ssno == e.SSNO)
                .Select(e => new Empleado(e))
                .SingleOrDefault();
        }
    }
}