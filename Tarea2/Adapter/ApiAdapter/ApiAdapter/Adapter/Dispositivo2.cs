using System;

namespace adapter.Adapter
{
    public class Dispositivo2
    {
        public decimal ObtenerTemperaturafahrenheit(string bloque)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = 0;
            value = random.Next(32, 140);
            
            return value;
        }

        public string ObtenerTipoMedida()
        {
            return "F";
        }
    }
}
