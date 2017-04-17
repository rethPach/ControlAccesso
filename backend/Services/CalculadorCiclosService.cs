using ProjectManagement.SCAO.Models;
using ProjectManagement.SCAO.TOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.SCAO.Services
{
    public class CalculadorCiclosService
    {
        protected IEnumerable<GrupoCiclos> grupoCiclos;
        protected int countPases;
        protected TimeSpan sumatoria;
        private IEnumerable<TOs.GrupoPases> grupoPases;

        public CalculadorCiclosService(IEnumerable<TOs.GrupoPases> grupoPasesArg)
        {
            grupoPases = grupoPasesArg;
            sumatoria = new TimeSpan(0, 0, 0);
            grupoCiclos = createCiclos();
        }

        protected IEnumerable<GrupoCiclos> createCiclos()
        {
            List<GrupoCiclos> grupoCiclos = new List<GrupoCiclos>();

            foreach(GrupoPases grupoPase in grupoPases)
            {
                var ciclos = new List<Ciclo>();
                var pases = grupoPase.pasesPorDia.ToArray();
                var countPases = pases.Count();
                var sumatoriaCiclo = new TimeSpan(0, 0, 0);

                for (int current = 0; current < countPases; current++)
                {
                    bool hasNext = (current + 1) < countPases;

                    if (hasNext
                        && pases[current].IsSalida()
                        && pases[current + 1].IsEntrada()
                    )
                    {
                        TimeSpan salida = pases[current].fecha.Value.TimeOfDay;
                        TimeSpan entrada = pases[current + 1].fecha.Value.TimeOfDay;
                        TimeSpan duracion = salida.Subtract(entrada);

                        ciclos.Add(new Ciclo(entrada, salida, duracion));
                        sumatoriaCiclo = sumatoriaCiclo.Add(duracion);

                    }
                }

                grupoCiclos.Add(new GrupoCiclos { 
                    dia = grupoPase.dia,
                    ciclos = ciclos,
                    total = getHoursToDouble(sumatoriaCiclo)
                });

                sumatoria = sumatoria.Add(sumatoriaCiclo);

            }

            return grupoCiclos;
           
        }

        public double getSumatoriaCiclosToHours()
        {
            return getHoursToDouble(sumatoria);
        }

        public IEnumerable<GrupoCiclos> getAllCiclosUsadosEnLaSumatoriaAgrupadosPorDia()
        {
            return grupoCiclos;
        }

        protected double getHoursToDouble(TimeSpan timespan)
        {
            return Convert.ToDouble(
                timespan.ToString(@"h\.m")
            );
        }

    }
}