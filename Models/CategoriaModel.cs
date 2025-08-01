using System.ComponentModel.DataAnnotations;

namespace API_Financas.Models
{
    public class CategoriaModel
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }
    }
}