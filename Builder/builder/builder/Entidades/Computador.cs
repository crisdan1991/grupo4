namespace builder.builder.Entidades
{
    public class Computador : ActivoBuilder
    {

        public override void setCodigo()
        {
            _activo.codigo = 1;

        }

        public override void setNombre()
        {
            _activo.nombre = "Computador HP";

        }

        public override void setPrecio()
        {
            _activo.precio = 2300;

        }

        public override void setDepartamento()
        {
            _activo.departamento = "Informatica";
        }


        public override void setAnioDepreciacion()
        {
            _activo.anioDepreciacion = "20%";
        }

        public override void setAñoFabricacion()
        {

        }

        public override void setPlaca()
        {

        }
        public override void setFechaCompra()
        {

        }

        public override void setTipo()
        {
            _activo.tipo = "Escritorio";
        }

        public override void setResponsable()
        {
            _activo.tipo = "Soporte A";
        }

    }
}
