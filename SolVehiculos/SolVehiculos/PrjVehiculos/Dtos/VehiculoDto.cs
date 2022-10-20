namespace PrjVehiculos.Dtos
{
    public class DtoInPLaca
    {
        public string Placa { get; set; }
    }

    public class DtoInOutVehiculo
    {
        public int IdTipoVehiculo { get; set; }
        public string NombreTipoVehiculo { get; set; }
    }

    public class DtoOutVehiculo
    {
        public string Placa { get; set; }
        public string TipoVehiculo { get; set; }
        public int AnioFabricacion { get; set; }
        public string PaisOrigen { get; set; }
        public string NombrePropietario { get; set; }
        public decimal Avaluo { get; set; }
        public string Color { get; set; }
        public decimal Cilindraje { get; set; }
        public string Marca { get; set; }
    }
}
