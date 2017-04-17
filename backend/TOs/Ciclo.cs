using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.TOs
{
    public class Ciclo
    {
        public Ciclo(TimeSpan entrada, TimeSpan salida, TimeSpan duracion)
        {
            this.entrada = entrada;
            this.salida = salida;
            this.duracion = duracion;
        }

        public TimeSpan entrada { get; protected set; }

        public TimeSpan salida { get; protected set; }

        public TimeSpan duracion { get; protected set; }
    }
}