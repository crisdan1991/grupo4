using System;
using System.Diagnostics.Metrics;

namespace adapter.Adapter
{
    public class Dispositivo1 : IDispositivo
    {

     public   decimal ObtenerTemperatura(string bloque)
        {

            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = 0;

            switch (bloque)
            { 
                case "Bloque A":
                      value = random.Next(0, 60);
                       break;

                case "Bloque B":
                    value = random.Next(12, 30);
                    break;

                default:
                    // code block
                    break;

            }
            
          

            return value;
        }

     public string ObtenerTipoMedida()
        {
            return "c";
        }
    }
}
