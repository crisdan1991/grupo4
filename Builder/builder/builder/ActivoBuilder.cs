using builder.builder.Entidades;

namespace builder.builder
{
    public abstract class ActivoBuilder
    {
        protected activos _activo = new activos();

        public activos getActivo()
        {
            return _activo;
        }

        public abstract void setCodigo();
        public abstract void setNombre();
        public abstract void setPrecio();

        public abstract void setDepartamento();
        public abstract void setAnioDepreciacion();
        public abstract void setAñoFabricacion();

        public abstract void setPlaca();
        public abstract void setFechaCompra();

        public abstract void setTipo();
        public abstract void setResponsable();



    }
}
