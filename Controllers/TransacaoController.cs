using API_Financas.Data.Repositories;
using API_Financas.Domain.Enum;
using API_Financas.Dto.Transacao;
using API_Financas.Models;
using API_Financas.Services;
using Microsoft.AspNetCore.Mvc;


namespace API_Financas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {

        readonly ITransacaoService _transacaoService;

        public TransacaoController(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }
        

        [HttpGet]
        public async Task<IActionResult> ObterTransacoes([FromQuery] DateOnly? dataInicio, [FromQuery] DateOnly? dataFim)
        {
            var transacao = await _transacaoService.ObterTransacoes(dataInicio, dataFim);
            
            return Ok(transacao);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarTransacoes([FromBody] TransacaoPostDto transacao)
        {
            if (ModelState.IsValid)
            {

                var AdicionarTransacao = await _transacaoService.AdicionarTransacoes(transacao);

                return AdicionarTransacao switch
                {
                    StatusOperacao.Sucesso => Created(AdicionarTransacao.ToString(), "Transação adicionada com sucesso!"),
                    StatusOperacao.Erro => NotFound("Erro ao adicionar transação!")
                };
            }

            return BadRequest(transacao);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarTransacao([FromBody] TransacaoPutDto transacao)
        {
            if (ModelState.IsValid)
            {
                var AtualizarTransacao = await _transacaoService.AtualizarTransacao(transacao);

                return AtualizarTransacao switch
                {
                    StatusOperacao.Sucesso => Ok("Transação atualizada com sucesso!"),
                    StatusOperacao.NaoEncontrado => BadRequest("Transação não encontrada!"),
                    StatusOperacao.Erro => NotFound("Erro ao atualizar transação!")
                };
            }

            return BadRequest(transacao);
        }

        [HttpDelete("{IdTransacao}")]
        public async Task<IActionResult> DeletarTransacao(int IdTransacao)
        {
            if (IdTransacao > 0)
            {
                var DeletarTransacao = await _transacaoService.DeletarTransacao(IdTransacao);

                return DeletarTransacao switch
                {
                    StatusOperacao.Sucesso => Ok("Transacao deletada com sucesso!"),
                    StatusOperacao.NaoEncontrado => BadRequest("Transacao não encontrada!"),
                    StatusOperacao.Erro => NotFound("Erro ao deletar transacao!")
                };
            }

            return BadRequest("Id invalido");
        }


    }
}