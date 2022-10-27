using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAdapter.Model
{
    public class Temperatura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tempID { get; set; }
        public string bloque { get; set; }
        public decimal temp { get; set; }
    }
}
