namespace TemplateMethod.Template
{
    public abstract class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Precio { get; set; }

        public double CalcularPercioFinal()
        {
            return this.CalcularPrecio() + this.CalcularComision();
        }
        public abstract double CalcularPrecio();

        public abstract double CalcularComision();


    }
}
