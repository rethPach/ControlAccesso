using ProjectManagement.Models.Repositories;
using ProjectManagement.SCAO.Models;
using ProjectManagement.SCAO.TOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Services
{
    public class MonitorService
    {
        protected SCAOContextDataContext db;
        protected DataClassesDataContext dbKairos;
        public MonitorService()
        {
            db = new SCAOContextDataContext();
        }

        public IEnumerable<EmpleadoMonitor> getEmpleadosFuera()
        {
            var readers = new System.Nullable<short>[] { 40, 41 };
            return getEmpleadosConUltimoPase().Where(e => readers.Contains(e.ultimoPase.reader));
        }

        public IEnumerable<EmpleadoMonitor> getEmpleadosDentro()
        {
            var readers = new System.Nullable<short>[] { 9, 10 };
            return getEmpleadosConUltimoPase().Where(e => readers.Contains(e.ultimoPase.reader));
        }

        public IEnumerable<EmpleadoMonitor> getEmpleadosConUltimoPase()
        {
            var readers = new System.Nullable<short>[] { 9, 10, 40, 41 };
            var ssnos = ssnosAllUsers();
            var empleadosConUltimoPase = (
                from empleado in db.EMP
                join pase in db.EVENTS on empleado.ID equals pase.EMPID into pases
                    from ultimoPase in pases
                    where
                        ultimoPase.EVENT_TIME_UTC == pases.Max(p => p.EVENT_TIME_UTC)
                        && readers.Contains(ultimoPase.DEVID)
                        && ssnos.Contains(empleado.SSNO)
                select new EmpleadoMonitor
                {
                    empleado = new Empleado(empleado),
                    ultimoPase = new Pase(ultimoPase)
                }
            );

            return empleadosConUltimoPase;
        }

        public IEnumerable<string> ssnosAllUsers()
        {
            using(dbKairos = new DataClassesDataContext())
            {
                return dbKairos.Users.Select(u => u.IDyn).ToList();
            }
        }
    }
}