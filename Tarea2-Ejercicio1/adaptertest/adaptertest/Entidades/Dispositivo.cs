using System;

namespace Temperatura.Entidades
{
    public class Dispositivo
    {
        private String nombreC;
        private double valorC;
        private String nombreF;
        private double valorF;

        public string NombreC
        {
            get => nombreC;
            set => nombreC = value;
        }

        public string NombreF
        {
            get => nombreF;
            set => nombreF = value;
        }

        public double ValorC
        {
            get => valorC;
            set => valorC = value;
        }

        public double ValorF
        {
            get => valorF;
            set => valorF = value;
        }

        public double aFahrenheit(double celcius)
        {
            Double fahrenheit = (celcius * 1.8) + 32;
            return fahrenheit;
        }
        public double aCelsius(double fahrenheit)
        {
            Double celcius = (fahrenheit - 32) / 1.8;
            return celcius;
        }

        public override string ToString()
        {
            return $"{nameof(NombreC)}: {NombreC}, {nameof(ValorC)}: {ValorC}, {nameof(NombreF)}: {NombreF},{nameof(ValorF)}: {ValorF}";
        }
    }
}