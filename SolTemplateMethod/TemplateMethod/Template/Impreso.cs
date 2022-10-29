namespace TemplateMethod.Template
{
    public class Impreso : Libro
    {
        double _costoEnvio = 20;

        public override double CalcularComision()
        {
            return 0.02 * CalcularPrecio() + _costoEnvio;
        }

        public override double CalcularPrecio()
        {
            return 500;
        }
    }
}
