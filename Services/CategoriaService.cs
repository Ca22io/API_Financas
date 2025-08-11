using API_Financas.Data.Repositories;
using API_Financas.Domain.Enum;
using API_Financas.Dto.Categoria;
using API_Financas.Models;
using AutoMapper;

namespace API_Financas.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaDto>> ObterCategorias()
        {
            var Categorias = await _categoriaRepository.ObterCategoriasAsync();
            
            var CategoriasDto = _mapper.Map<IEnumerable<CategoriaDto>>(Categorias);

            return CategoriasDto;
        }

        public async Task<StatusOperacao> AdicionarCategoria(CategoriaDto categoria)
        {
            var Categoria = _mapper.Map<CategoriaModel>(categoria);

            return await _categoriaRepository.AdicionarCategoriaAsync(Categoria);
        }

        public async Task<StatusOperacao> AtualizarCategoria(CategoriaDto categoria)
        {
            var Categoria = _mapper.Map<CategoriaModel>(categoria);

            return await _categoriaRepository.AtualizarCategoriaAsync(Categoria);
        }

        public async Task<StatusOperacao> RemoverCategoria(int id)
        {
            return await _categoriaRepository.RemoverCategoriaAsync(id);
        }
    }
}