using ProjectManagement.SCAO.Models;
using ProjectManagement.SCAO.TOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Aggregates
{
    public class EmpleadoAggregate
    {
        protected Empleado empleado;
        protected SCAOContextDataContext db;
        public EmpleadoAggregate(string empleadoSSNO)
        {
            db = new SCAOContextDataContext();
            empleado = findOrFail(empleadoSSNO);
        }

        public Empleado getEmpleado()
        {
            return empleado;
        }


        protected Empleado findOrFail(string ssno)
        {
            var empleadoX = (
                from empleado in db.EMP
                where empleado.SSNO == ssno
                select new Empleado
                {
                    id = empleado.ID,
                    ssno = empleado.SSNO,
                    nombre = empleado.FIRSTNAME,
                    apellido = empleado.LASTNAME,
                    cedula = empleado.MIDNAME
                }
            ).FirstOrDefault();

            if (empleadoX == null) throw new ArgumentException();

            return empleadoX;
        }

        public IEnumerable<GrupoPases> getPasesIntoRangoAgrupadosPorDias(DateTime startDate, DateTime endDate)
        {
            var readers = new System.Nullable<short>[] { 9, 10, 40, 41 };

            return db.EVENTS

            .Where(pase =>
                pase.EMPID == getEmpleado().id
                && pase.EVENT_TIME_UTC.Value.CompareTo(startDate) > 0
                && pase.EVENT_TIME_UTC.Value.CompareTo(endDate) < 0
                && readers.Contains(pase.DEVID)
            )

            .OrderByDescending(pase => pase.EVENT_TIME_UTC)

            .GroupBy(pase => new
            {
                pase.EVENT_TIME_UTC.Value.Date,
                pase.EMPID
            })
              
            .Select(g => new GrupoPases { 
                dia = g.Key.Date,
                pasesPorDia = g.Select(pase => new Pase(pase))
            });
        }

        public int countDiasLaboradosIntoRangoAgrupadosPorDias(DateTime startDate, DateTime endDate)
        {
            return db.EVENTS

            .Where(pase =>
                pase.EMPID == getEmpleado().id
                && pase.EVENT_TIME_UTC.Value.CompareTo(startDate) > 0
                && pase.EVENT_TIME_UTC.Value.CompareTo(endDate) < 0
            )

            .GroupBy(pase => new
            {
                pase.EVENT_TIME_UTC.Value.Date,
                pase.EMPID
            })

            .Count();
        }



    }
}