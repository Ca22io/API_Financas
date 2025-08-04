using API_Financas.Domain.Enum;
using API_Financas.Domain.Interfaces;
using API_Financas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Financas.Data.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        public readonly FinancasContext _context;

        public TransacaoRepository(FinancasContext context)
        {
            _context = context;

        }

        public void IncluirTipo()
        {
            _context.Tipos.Add(new TipoModel { Nome = "Receita" });
            _context.Tipos.Add(new TipoModel { Nome = "Despesa" });
        }

        public async Task<IEnumerable<TransacaoModel>> ObterTransacoesPorDataAsync(DateOnly dataInicio, DateOnly dataFim)
        {
            var transacoes = await _context.Transacoes
                .Include(t => t.Categorias)
                .Include(t => t.Tipos)
                .Where(t => t.Data >= dataInicio && t.Data <= dataFim)
                .OrderBy(t => t.Data)
                .AsNoTracking()
                .ToListAsync();

            return transacoes;
        }

        public async Task<IEnumerable<TransacaoModel>> ObterTransacaoAsync()
        {
            var transacoes = await _context.Transacoes
                .Include(t => t.Categorias)
                .Include(t => t.Tipos)
                .OrderBy(t => t.Data)
                .AsNoTracking()
                .ToListAsync();

            return transacoes;
        }

        public async Task<StatusOperacao> AdicionarTransacaoAsync(TransacaoModel transacao)
        {
            await _context.Transacoes.AddAsync(transacao);

            if (await _context.SaveChangesAsync() > 0)
            {
                var TransacaoId = await _context.Transacoes
                    .Where(t => t == transacao)
                    .Select(t => t.IdTransacao)
                    .FirstOrDefaultAsync();

                return StatusOperacao.Sucesso;
            }

            return StatusOperacao.Erro;

        }

        public async Task<StatusOperacao> AtualizarTransacaoAsync(TransacaoModel transacao)
        {
            if (VerificarTransacaoexiste(transacao.IdTransacao) == false)
            {
                return StatusOperacao.NaoEncontrado;
            }

            _context.Transacoes.Update(transacao);

            if (await _context.SaveChangesAsync() > 0)
            {
                return StatusOperacao.Sucesso;
            }

            return StatusOperacao.Erro;
        }

        public async Task<StatusOperacao> RemoverTransacaoAsync(int id)
        {

            if (VerificarTransacaoexiste(id) == false)
            {
                return StatusOperacao.NaoEncontrado;
            }

            var transacao = await _context.Transacoes
                .FirstOrDefaultAsync(t => t.IdTransacao == id);

            _context.Transacoes.Remove(transacao);

            if (await _context.SaveChangesAsync() > 0)
            {
                return StatusOperacao.Sucesso;
            }

            return StatusOperacao.Erro;
        }

        public bool VerificarTransacaoexiste(int id)
        {
            return _context.Transacoes.Any(t => t.IdTransacao == id);
        }
    }
}