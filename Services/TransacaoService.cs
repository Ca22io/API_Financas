using System.Collections.Generic;
using API_Financas.Data.Repositories;
using API_Financas.Domain.Enum;
using API_Financas.Dto.Transacao;
using API_Financas.Models;
using AutoMapper;

namespace API_Financas.Services
{
    public class TransacaoService : ITransacaoService
    {
        readonly ITransacaoRepository _transacaoRepository;
        readonly IMapper _mapper;

        public TransacaoService(ITransacaoRepository transacaoRepository, IMapper mapper)
        {
            _transacaoRepository = transacaoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransacaoGetDto>> ObterTransacoes(DateOnly? dataInicio, DateOnly? dataFim)
        {

            if (dataInicio == null && dataFim == null)
            {
                var Transacoes = await _transacaoRepository.ObterTransacaoAsync();
                
                var TransacoesDto = _mapper.Map<List<TransacaoGetDto>>(Transacoes);

                return TransacoesDto;
            }
            else
            {
                var Transacoes = await _transacaoRepository.ObterTransacoesPorDataAsync(dataInicio.Value, dataFim.Value);
                
                var TransacoesDto = _mapper.Map<List<TransacaoGetDto>>(Transacoes);

                return TransacoesDto;
            }
            
        }

        public async Task<StatusOperacao> AdicionarTransacoes(TransacaoPostDto transacao)
        {
            var Transacao = _mapper.Map<TransacaoModel>(transacao);
           
            return await _transacaoRepository.AdicionarTransacaoAsync(Transacao);
        }

        public async Task<StatusOperacao> AtualizarTransacao(TransacaoPutDto transacao)
        {
            var Transacao = _mapper.Map<TransacaoModel>(transacao);

            return await _transacaoRepository.AtualizarTransacaoAsync(Transacao);
        }

        public async Task<StatusOperacao> DeletarTransacao(int id)
        {
            var Transacao = await _transacaoRepository.RemoverTransacaoAsync(id);

            return Transacao;
        }

    }
}