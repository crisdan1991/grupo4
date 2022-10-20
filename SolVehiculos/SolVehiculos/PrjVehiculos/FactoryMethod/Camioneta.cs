using PrjVehiculos.Models;

namespace PrjVehiculos.FactoryMethod
{
    public class Camioneta : VehiculoMain
    {
        public override decimal CalcularMatricula(Impuestos impuesto, Vehiculo vehiculo)
        {
            decimal impuestoPropiedad = vehiculo.Avaluo * impuesto.ImpuestoPropiedad;
            decimal impuestoRodaje = vehiculo.Avaluo * impuesto.ImpuestoRodaje;
            decimal tasaPagoAccidentes = vehiculo.Avaluo * impuesto.TasaPagoAccidentes;
            decimal valorCilindraje = (vehiculo.Cilindraje/100) * (vehiculo.Avaluo/100);

            decimal total = impuestoPropiedad + impuestoRodaje + tasaPagoAccidentes + valorCilindraje + impuesto.TasaAnt;

            return total;
        }
    }
}
