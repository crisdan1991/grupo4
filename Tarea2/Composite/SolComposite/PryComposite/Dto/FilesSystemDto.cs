namespace PryComposite.Dto
{
    public class FileSystemDtoIn
    {
        public int Id { get; set; }
        public int IdPadre { get; set; }
        public string Nombre { get; set; }
        public bool EsArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public int Tamanio { get; set; }
    }

    public class DirectoriosDtoOut
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
