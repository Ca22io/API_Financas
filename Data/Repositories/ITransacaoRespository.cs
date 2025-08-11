using API_Financas.Domain.Enum;
using API_Financas.Dto.Transacao;
using API_Financas.Models;

namespace API_Financas.Data.Repositories
{
    public interface ITransacaoRepository
    {
        Task<IEnumerable<TransacaoModel>> ObterTransacoesPorDataAsync(DateOnly dataInicio, DateOnly dataFim);
        Task<IEnumerable<TransacaoModel>> ObterTransacaoAsync();
        Task<StatusOperacao> AdicionarTransacaoAsync(TransacaoModel transacao);
        Task<StatusOperacao> AtualizarTransacaoAsync(TransacaoModel transacao);
        Task<StatusOperacao> RemoverTransacaoAsync(int id);
    }

}