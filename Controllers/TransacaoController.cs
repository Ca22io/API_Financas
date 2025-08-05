using API_Financas.Data.Repositories;
using API_Financas.Domain.Enum;
using API_Financas.Dto.Transacao;
using API_Financas.Models;
using Microsoft.AspNetCore.Mvc;


namespace API_Financas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {
        private readonly TransacaoRepository _transacaoRepository;

        public TransacaoController(TransacaoRepository transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTransacoes([FromQuery] DateOnly? dataInicio, [FromQuery] DateOnly? dataFim)
        {
            
            if (dataInicio == null && dataFim == null)
            {
                var transacoes = await _transacaoRepository.ObterTransacaoAsync();
                return Ok(transacoes);
            }

            var transacao = await _transacaoRepository.ObterTransacoesPorDataAsync(dataInicio.Value, dataFim.Value);
            return Ok(transacao);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarTransacoes([FromBody] TransacaoPostDto transacao)
        {
            if (ModelState.IsValid)
            {
                var Transacao = new TransacaoModel
                {
                    Descricao = transacao.Descricao,
                    Valor = transacao.Valor,
                    Data = transacao.Data,
                    IdTipo = transacao.IdTipo,
                    IdCategoria = transacao.IdCategoria
                };

                var AdicionarTransacao = await _transacaoRepository.AdicionarTransacaoAsync(Transacao);

                return AdicionarTransacao switch
                {
                    StatusOperacao.Sucesso => Ok("Transação adicionada com sucesso!"),
                    StatusOperacao.Erro => BadRequest("Erro ao adicionar transação!")
                };
            }

            return BadRequest(transacao);
        }

        [HttpDelete("{IdTransacao}")]
        public async Task<IActionResult> DeletarTransacao(int IdTransacao)
        {
            if (IdTransacao > 0)
            {
                var DeletarTransacao = await _transacaoRepository.RemoverTransacaoAsync(IdTransacao);

                return DeletarTransacao switch
                {
                    StatusOperacao.Sucesso => Ok("Transacao deletada com sucesso!"),
                    StatusOperacao.NaoEncontrado => BadRequest("Transacao não encontrada!"),
                    StatusOperacao.Erro => BadRequest("Erro ao deletar transacao!")
                };
            }

            return BadRequest("Id invalido");
        }


        [HttpPut]
        public async Task<IActionResult> AtualizarTransacao([FromBody] TransacaoPutDto transacao)
        {
            if (ModelState.IsValid)
            {
                var Transacao = new TransacaoModel
                {
                    IdTransacao = transacao.IdTransacao,
                    Descricao = transacao.Descricao,
                    Valor = transacao.Valor
                };

                var AtualizarTransacao = await _transacaoRepository.AtualizarTransacaoAsync(Transacao);

                return AtualizarTransacao switch
                {
                    StatusOperacao.Sucesso => Ok("Transação atualizada com sucesso!"),
                    StatusOperacao.NaoEncontrado => BadRequest("Transação não encontrada!"),
                    StatusOperacao.Erro => BadRequest("Erro ao atualizar transação!")
                };
            }

            return BadRequest(transacao);
        }

    }
}