using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temperatura.Adapter;
using Temperatura.Entidades;

namespace adaptertest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            AdapterTemperatura convertidor = new AdapterTemperatura();
            Console.WriteLine(convertidor.convertirTemperatura(TipoTemperatura.CELSIUS, 10));
            Console.WriteLine(convertidor.convertirTemperatura(TipoTemperatura.FAHRENHEIT, 50));
            Dispositivo obj = new Dispositivo() {
            
                NombreC = TipoTemperatura.CELSIUS.ToString(),
                ValorC = 10,
                NombreF = TipoTemperatura.FAHRENHEIT.ToString(),
                ValorF = convertidor.convertirTemperatura(TipoTemperatura.CELSIUS, 10) 
            };
            Console.WriteLine(obj.ToString());

        }
    }
}