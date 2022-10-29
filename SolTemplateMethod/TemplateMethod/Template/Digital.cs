namespace TemplateMethod.Template
{
    public class Digital : Libro
    {
        public override double CalcularComision()
        {
            return 10;
        }

        public override double CalcularPrecio()
        {
            return 500;
        }
    }
}
