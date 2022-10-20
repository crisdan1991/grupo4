namespace PrjVehiculos.FactoryMethod
{
    public class VehiculoFactory : VehiculoFactoryCreator
    {
        public override VehiculoMain CrearVehiculoFactory(TipoVehiculoEnum tipoVehiculo)
        {
            switch (tipoVehiculo)
            {
                case TipoVehiculoEnum.AUTO:
                    return new Auto();
                    break;

                case TipoVehiculoEnum.CAMIONETA:
                    return new Camioneta();
                    break;

                case TipoVehiculoEnum.CAMION:
                    return new Camion();
                    break;

                default:
                    return null;
                    break;
            }
        }
    }
}
