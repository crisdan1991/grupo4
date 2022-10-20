using PrjVehiculos.Models;

namespace PrjVehiculos.FactoryMethod
{
    public abstract class VehiculoMain
    {
        public bool TieneExcepcionRevision { get; set; }
        public string Placa { get; set; }
        public abstract decimal CalcularMatricula(Impuestos impuesto, Vehiculo vehiculo);
    }
}
