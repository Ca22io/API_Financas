using API_Financas.Domain.Enum;
using API_Financas.Models;

namespace API_Financas.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaModel>> ObterCategorias();
        Task<StatusOperacao> AdicionarCategoria(CategoriaModel categoria);
        Task<StatusOperacao> AtualizarCategoria(CategoriaModel categoria);
        Task<StatusOperacao> RemoverCategoria(int id);
    }
}