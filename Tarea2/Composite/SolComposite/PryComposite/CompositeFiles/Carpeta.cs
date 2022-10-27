namespace PryComposite.CompositeFiles
{
    public class Carpeta : Component
    {
        private List<Component> listaComponentes;

        public Carpeta(string nombre) : base(nombre)
        {
            listaComponentes = new List<Component>();
        }

        public override void AgregarHijo(Component component)
        {
            listaComponentes.Add(component);
        }

        public override IList<Component> ObtenerHijos()
        {
            return listaComponentes.ToArray();
        }

        public override int ObtenerTamanio
        {
            get
            {
                int tmanio = 0;

                foreach (Component component in listaComponentes)
                {
                    tmanio += component.ObtenerTamanio;
                }

                return ObtenerTamanio;
            }
        }
    }
}
