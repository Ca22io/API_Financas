using API_Financas.Domain.Enum;
using API_Financas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Financas.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public readonly FinancasContext _context;

        public CategoriaRepository(FinancasContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoriaModel>> ObterCategoriasAsync()
        {
            var categorias = await _context.Categorias.AsNoTracking().ToListAsync();

            return categorias;
        }

        public async Task<StatusOperacao> AdicionarCategoriaAsync(CategoriaModel categoria)
        {
            await _context.Categorias.AddAsync(categoria);

            if (await _context.SaveChangesAsync() > 0)
            {
                return StatusOperacao.Sucesso;
            }

            return StatusOperacao.Erro;
        }

        public async Task<StatusOperacao> AtualizarCategoriaAsync(CategoriaModel categoria)
        {
            if (!VerificaCategoriaExiste(categoria.IdCategoria))
            {
                return StatusOperacao.NaoEncontrado;
            }

            _context.Categorias.Update(categoria);

            if (await _context.SaveChangesAsync() > 0)
            {
                return StatusOperacao.Sucesso;
            }

            return StatusOperacao.Erro;

        }

        public async Task<StatusOperacao> RemoverCategoriaAsync(int Id)
        {
            if (!VerificaCategoriaExiste(Id))
            {
                return StatusOperacao.NaoEncontrado;
            }

            if (Id > 0)
            {
                var LocalizarCategoria = await _context.Categorias
                    .FirstOrDefaultAsync(c => c.IdCategoria == Id);

                _context.Remove(LocalizarCategoria);

                if (await _context.SaveChangesAsync() > 0)
                {
                    return StatusOperacao.Sucesso;
                }

                return StatusOperacao.Erro;
            }

            return StatusOperacao.IdInvalido;
        }

        private bool VerificaCategoriaExiste(int Id)
        {
            return _context.Categorias.Any(c => c.IdCategoria == Id);
        }

        Task<StatusOperacao> ICategoriaRepository.AdicionarCategoriaAsync(CategoriaModel categoria)
        {
            throw new NotImplementedException();
        }

        Task<StatusOperacao> ICategoriaRepository.AtualizarCategoriaAsync(CategoriaModel categoria)
        {
            throw new NotImplementedException();
        }

        Task<StatusOperacao> ICategoriaRepository.RemoverCategoriaAsync(int id)
        {
            throw new NotImplementedException();
        }
    }

}