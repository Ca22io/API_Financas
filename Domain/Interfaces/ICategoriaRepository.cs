using API_Financas.Models;

namespace API_Financas.Domain.Interfaces
{

    public interface ICategoriaRepository
    {
        Task<IEnumerable<CategoriaModel>> ObterCategoriasAsync();
        Task AdicionarCategoriaAsync(CategoriaModel categoria);
        Task AtualizarCategoriaAsync(CategoriaModel categoria);
        Task RemoverCategoriaAsync(int id);
    }

}