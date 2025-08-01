using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Financas.Models
{
    public class TransacaoModel
    {
        [Key]
        public int IdTransacao { get; set; }

        [Required, StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public int IdTipo { get; set; }

        public int IdCategoria { get; set; }
        
        [ForeignKey("IdCategoria")]
        public ICollection<CategoriaModel> Categorias { get; set; }

        [ForeignKey("IdTipo")]
        public ICollection<TipoModel> Tipos { get; set; }
    }
}