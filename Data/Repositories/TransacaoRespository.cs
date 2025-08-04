using API_Financas.Domain.Interfaces;
using API_Financas.Models;

namespace API_Financas.Data.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        public readonly FinancasContext _context;

        public TransacaoRepository(FinancasContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<TransacaoModel>> ObterTransacoesPorDataAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TransacaoModel> ObterTransacaoPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AdicionarTransacaoAsync(TransacaoModel transacao)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarTransacaoAsync(TransacaoModel transacao)
        {
            throw new NotImplementedException();
        }

        public Task RemoverTransacaoAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}