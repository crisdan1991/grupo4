namespace PrjVehiculos.FactoryMethod
{
    public abstract class VehiculoFactoryCreator
    {
        public abstract VehiculoMain CrearVehiculoFactory(TipoVehiculoEnum tipoVehiculo);
    }
}
