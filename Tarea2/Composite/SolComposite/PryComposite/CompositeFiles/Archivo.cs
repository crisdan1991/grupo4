using System.Reflection.Metadata.Ecma335;

namespace PryComposite.CompositeFiles
{
    public class Archivo : Component
    {
        int _tamanio;
        string _tipoArchivo;

        public int Tamanio { get { return _tamanio; } }

        public Archivo(string nombre, string tipoArchivo, int tamanio) : base(nombre)
        {
            _tamanio = tamanio;
            _tipoArchivo = tipoArchivo;
        }

        public override void AgregarHijo(Component component)
        {
        }

        public override IList<Component> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerTamanio
        {
            get
            {
                return _tamanio;
            }
        }
    }
}
