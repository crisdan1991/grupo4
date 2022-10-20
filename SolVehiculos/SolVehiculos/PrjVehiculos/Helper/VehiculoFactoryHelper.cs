using PrjVehiculos.FactoryMethod;
using System.Text.Json;

namespace PrjVehiculos.Helper
{
    public static class VehiculoFactoryHelper
    {
        public static T Factory<T>(TipoVehiculoEnum tipoVehiculoEnum)
        {
            T respuesta = default(T);

            var factory = new VehiculoFactory();
            var auto = factory.CrearVehiculoFactory(tipoVehiculoEnum);

            string serilized = JsonSerializer.Serialize(auto);

            respuesta = JsonSerializer.Deserialize<T>(serilized);

            return respuesta;
        }
    }
}
