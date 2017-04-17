using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.TOs
{
    public class GrupoCiclos
    {
        public List<Ciclo> ciclos { get; set; }

        public DateTime dia { get; set; }

        public TimeSpan total { get; set; }
    }
}