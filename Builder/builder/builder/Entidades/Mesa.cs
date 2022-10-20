namespace builder.builder.Entidades
{
    public class mesa : ActivoBuilder
    {
        public override void setCodigo()
        {
            _activo.codigo = 2;

        }

        public override void setNombre()
        {
            _activo.nombre = "Mesa de centro";

        }

        public override void setPrecio()
        {
            _activo.precio = 1200;

        }

        public override void setDepartamento()
        {
            _activo.departamento = "Muebles";
        }


        public override void setAnioDepreciacion()
        {

        }

        public override void setAñoFabricacion()
        {

        }

        public override void setPlaca()
        {

        }
        public override void setFechaCompra()
        {
            _activo.fechaDeCompra = "2022/01/10";
        }

        public override void setTipo()
        {
            _activo.tipo = "Mesa";
        }

        public override void setResponsable()
        {
            _activo.tipo = "Bodeguero A";
        }

    }
}
