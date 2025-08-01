using System.ComponentModel.DataAnnotations;

namespace API_Financas.Models
{
    public class TipoModel
    {
        [Key]
        public int IdTipo { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }
    }
}