namespace builder.builder.Entidades
{
    public class activos
    {
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

        public activos()
        {

        }

        public activos(int Codigo, string Nombre, double Precio, string Departamento, string AnioDepreciacion, int AñoFabricacion, string Tipo, string FechaDeCompra, string Responsable, string Placa)
        {
            codigo = Codigo;
            nombre = Nombre;
            precio = Precio;
            departamento = Departamento;
            anioDepreciacion = AnioDepreciacion;
            añoFabricacion = AñoFabricacion;
            tipo = Tipo;
            fechaDeCompra = FechaDeCompra;
            responsable = Responsable;
            placa = Placa;
        }


    }
}
