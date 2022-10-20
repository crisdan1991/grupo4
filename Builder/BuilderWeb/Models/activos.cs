namespace BuilderWeb.Models
{
    public class activos
    {
        public string activo { get; set; }
        public int codigo { get; set; }
        public string? nombre { get; set; }
        public double precio { get; set; }
        public string? departamento { get; set; } //auto, computador
        public string? anioDepreciacion { get; set; } // auto, computador
        public int? añoFabricacion { get; set; } //auto
        public string? tipo { get; set; } //computador
        public string? fechaDeCompra { get; set; } //computador
        public string? responsable { get; set; }  //computador
        public string? placa { get; set; }  //computador

    }
}
