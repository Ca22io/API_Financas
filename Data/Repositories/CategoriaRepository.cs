using API_Financas.Domain.Interfaces;
using API_Financas.Models;

namespace API_Financas.Data.Repositories
{

    public class CategoriaRepository : ICategoriaRepository
    {
        public readonly FinancasContext _context;

        public CategoriaRepository(FinancasContext context)
        {
            _context = context;
        }

        public Task AdicionarCategoriaAsync(CategoriaModel categoria)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarCategoriaAsync(CategoriaModel categoria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaModel>> ObterCategoriasAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoverCategoriaAsync(int id)
        {
            throw new NotImplementedException();
        }
    }

}