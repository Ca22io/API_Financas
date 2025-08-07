using API_Financas.Data.Repositories;
using API_Financas.Domain.Enum;
using API_Financas.Models;

namespace API_Financas.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<CategoriaModel>> ObterCategorias()
        {
            return await _categoriaRepository.ObterCategoriasAsync();
        }

        public async Task<StatusOperacao> AdicionarCategoria(CategoriaModel categoria)
        {
            return await _categoriaRepository.AdicionarCategoriaAsync(categoria);
        }

        public async Task<StatusOperacao> AtualizarCategoria(CategoriaModel categoria)
        {
            return await _categoriaRepository.AtualizarCategoriaAsync(categoria);
        }

        public async Task<StatusOperacao> RemoverCategoria(int id)
        {
            return await _categoriaRepository.RemoverCategoriaAsync(id);
        }
    }
}