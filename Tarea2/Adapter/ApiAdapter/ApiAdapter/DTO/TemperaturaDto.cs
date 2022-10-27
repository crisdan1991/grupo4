using System.ComponentModel.DataAnnotations;

namespace adapter.Adapter.Entidades
{
    public class TemperaturaDTO
    {
        [Key]
        public int tempID { get; set; }
        public string bloque { get; set; }
        public decimal temp { get; set; }
    }
}
