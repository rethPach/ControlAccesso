using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.TOs
{
    public class GrupoPases
    {
        public DateTime dia { get; set; }

        public IEnumerable<Models.Pase> pasesPorDia { get; set; }
    }
}