using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.TOs
{
    public class EmpleadoMonitor
    {
        public Models.Empleado empleado { get; set; }

        public Models.Pase ultimoPase { get; set; }
    }
}