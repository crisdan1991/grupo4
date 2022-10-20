namespace builder.builder
{
    public class ActivoDirector
    {
        private ActivoBuilder builder;

        public void setBuilder(ActivoBuilder builder)
            { this.builder = builder; }

        public ActivoBuilder getBuilder()
        { 
         return builder;
        }



        public void crearActivo()
        {
            builder.setNombre();
            builder.setPrecio();
            builder.setCodigo();
            builder.setDepartamento();
            builder.setTipo();
            builder.setAnioDepreciacion();
            builder.setAñoFabricacion();
            builder.setPlaca();
            builder.setFechaCompra();
            builder.setResponsable();
        }
    }
}
