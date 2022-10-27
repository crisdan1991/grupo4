using Temperatura.Entidades;

namespace Temperatura.Adapter
{
    public class AdapterTemperatura : Interfaces.ITemperaturaAdapter
    {
        private Dispositivo dispositivo = new Dispositivo();
        public double convertirTemperatura(TipoTemperatura tipo, double valor)
        {
            var x = 0.0;
            if (tipo == TipoTemperatura.CELSIUS)
            {
                x= dispositivo.aFahrenheit(valor);
            }

            if (tipo == TipoTemperatura.FAHRENHEIT)
            {
                x= dispositivo.aCelsius(valor);
            }

            return x;
        }
    }
}