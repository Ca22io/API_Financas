using API_Financas.Domain.Enum;
using API_Financas.Dto.Transacao;
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

        public async Task<IEnumerable<TransacaoModel>> ObterTransacoesPorDataAsync(DateOnly dataInicio, DateOnly dataFim)
        {
            var Transacoes = await _context.Transacoes
                .Include(t => t.Categoria)
                .Include(t => t.Tipo)
                .Where(t => t.Data >= dataInicio && t.Data <= dataFim)
                .OrderBy(t => t.Data)
                .AsNoTracking()
                .ToListAsync();


            return Transacoes;
        }

        public async Task<IEnumerable<TransacaoModel>> ObterTransacaoAsync()
        {
            var Transacoes = await _context.Transacoes
                .Include(t => t.Categoria)
                .Include(t => t.Tipo)
                .OrderBy(t => t.Data)
                .AsNoTracking()
                .ToListAsync();

            return Transacoes;
        }

        public async Task<StatusOperacao> AdicionarTransacaoAsync(TransacaoModel transacao)
        {
            await _context.Transacoes.AddAsync(transacao);

            if (await _context.SaveChangesAsync() > 0)
            {
                return StatusOperacao.Sucesso;
            }

            return StatusOperacao.Erro;

        }

        public async Task<StatusOperacao> AtualizarTransacaoAsync(TransacaoModel Transacao)
        {

            if (!VerificarTransacaoexiste(Transacao.IdTransacao))
            {
                return StatusOperacao.NaoEncontrado;
            }

            var TransacaoAtualiza = await _context.Transacoes.AsTracking().FirstOrDefaultAsync(t => t.IdTransacao == Transacao.IdTransacao);

            TransacaoAtualiza.Descricao = Transacao.Descricao;
            TransacaoAtualiza.Valor = Transacao.Valor;

            if (await _context.SaveChangesAsync() > 0)
            {
                return StatusOperacao.Sucesso;
            }

            return StatusOperacao.Erro;
        }

        public async Task<StatusOperacao> RemoverTransacaoAsync(int Id)
        {

            if (!VerificarTransacaoexiste(Id))
            {
                return StatusOperacao.NaoEncontrado;
            }

            if (Id > 0)
            {
                var transacao = await _context.Transacoes
                    .FirstOrDefaultAsync(t => t.IdTransacao == Id);

                _context.Transacoes.Remove(transacao);

                if (await _context.SaveChangesAsync() > 0)
                {
                    return StatusOperacao.Sucesso;
                }

                return StatusOperacao.Erro;
            }

            return StatusOperacao.IdInvalido;
        }

        private bool VerificarTransacaoexiste(int id)
        {
            return _context.Transacoes.Any(t => t.IdTransacao == id);
        }

        private List<TransacaoGetDto> ListaDeTransacoes(List<TransacaoModel> t)
        {
            var TransacoesDto = t.Select(t => new TransacaoGetDto
            {
                IdTransacao = t.IdTransacao,
                Descricao = t.Descricao,
                Valor = t.Valor,
                Data = t.Data,
                NomeTipo = t.Tipo.Nome,
                NomeCategoria = t.Categoria.Nome
            })
                .ToList();

            return TransacoesDto;
        }
    }
}