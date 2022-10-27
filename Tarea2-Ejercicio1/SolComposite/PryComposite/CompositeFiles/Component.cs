namespace PryComposite.CompositeFiles
{
    public abstract class Component
    {
        string _nombre;

        public Component(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre { get { return _nombre; } }

        public abstract void AgregarHijo(Component component);

        public abstract IList<Component> ObtenerHijos();

        public abstract int ObtenerTamanio { get;  }
    }
}
