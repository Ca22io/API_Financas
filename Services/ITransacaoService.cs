using System.Collections.Generic;
using API_Financas.Domain.Enum;
using API_Financas.Dto.Transacao;

namespace API_Financas.Services
{
    public interface ITransacaoService
    {
        Task<IEnumerable<TransacaoGetDto>> ObterTransacoes(DateOnly? dataInicio, DateOnly? dataFim);
        Task<StatusOperacao> AdicionarTransacoes(TransacaoPostDto transacao);
        Task<StatusOperacao> DeletarTransacao(int id);
        Task<StatusOperacao> AtualizarTransacao(TransacaoPutDto transacao);
    }
}