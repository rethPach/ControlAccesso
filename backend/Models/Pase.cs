using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Models
{
    public class Pase
    {
        
        public Pase()
        {

        }

        public Pase(EVENTS pase)
        {
            serialnum = pase.SERIALNUM;
            empleadoId = pase.EMPID;
            fecha = pase.EVENT_TIME_UTC;
            reader = pase.DEVID;
        }
        
        public int serialnum { get; set; }

        public System.Nullable<int> empleadoId { get; set; }

        public System.Nullable<System.DateTime> fecha { get; set; }

        public System.Nullable<short> reader { get; set; }

        internal bool IsSalida()
        {
            var readers = new System.Nullable<short>[] { 40, 41 };
            return readers.Contains(reader);
        }

        internal bool IsEntrada()
        {
            var readers = new System.Nullable<short>[] { 9, 10 };
            return readers.Contains(reader);
        }
    }
}