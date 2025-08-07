using API_Financas.Domain.Enum;
using API_Financas.Models;

namespace API_Financas.Data.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<CategoriaModel>> ObterCategoriasAsync();
        Task<StatusOperacao> AdicionarCategoriaAsync(CategoriaModel categoria);
        Task<StatusOperacao> AtualizarCategoriaAsync(CategoriaModel categoria);
        Task<StatusOperacao> RemoverCategoriaAsync(int id);
    }

}