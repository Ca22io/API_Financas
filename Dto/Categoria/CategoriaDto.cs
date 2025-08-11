using API_Financas.Models;

namespace API_Financas.Dto.Categoria
{
    public class CategoriaDto
    {
        public int? IdCategoria { get; set; }
        public string Nome { get; set; }

        public CategoriaDto FromEntity(CategoriaModel categoria)
        {
            return new CategoriaDto
            {
                IdCategoria = categoria.IdCategoria,
                Nome = categoria.Nome
            };
        }
    }
}