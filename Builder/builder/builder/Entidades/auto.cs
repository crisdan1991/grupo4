namespace builder.builder.Entidades
{
    public class auto : ActivoBuilder
    {
        public override void setCodigo()
        {
            _activo.codigo = 3;

        }

        public override void setNombre()
        {
            _activo.nombre = "Auto Deportivo";

        }

        public override void setPrecio()
        {
            _activo.precio = 45000;

        }

        public override void setDepartamento()
        {
            _activo.departamento = "Autos";
        }


        public override void setAnioDepreciacion()
        {
            _activo.anioDepreciacion = "30%";
        }

        public override void setAñoFabricacion()
        {

        }

        public override void setPlaca()
        {

        }
        public override void setFechaCompra()
        {
            _activo.fechaDeCompra = "2022/01/01";
        }

        public override void setTipo()
        {
            _activo.tipo = "Deportivo";
        }

        public override void setResponsable()
        {
            _activo.tipo = "Vendedor A";
        }

    }
}
