using System;
using Temperatura.Entidades;

namespace Temperatura.Interfaces
{
    public interface ITemperaturaAdapter
    {
        public double convertirTemperatura(TipoTemperatura tipo, double valor);
    }
}