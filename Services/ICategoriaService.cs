using API_Financas.Domain.Enum;
using API_Financas.Dto.Categoria;

namespace API_Financas.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDto>> ObterCategorias();
        Task<StatusOperacao> AdicionarCategoria(CategoriaDto categoria);
        Task<StatusOperacao> AtualizarCategoria(CategoriaDto categoria);
        Task<StatusOperacao> RemoverCategoria(int id);
    }
}