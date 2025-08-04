using API_Financas.Models;

namespace API_Financas.Domain.Interfaces
{

    public interface ITransacaoRepository
    {
        Task<IEnumerable<TransacaoModel>> ObterTransacoesPorDataAsync();
        Task<TransacaoModel> ObterTransacaoPorIdAsync(int id);
        Task AdicionarTransacaoAsync(TransacaoModel transacao);
        Task AtualizarTransacaoAsync(TransacaoModel transacao);
        Task RemoverTransacaoAsync(int id);
    }

}