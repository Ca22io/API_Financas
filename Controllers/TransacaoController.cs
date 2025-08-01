using Microsoft.AspNetCore.Mvc;

namespace API_Financas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {

        [HttpGet(Name = "GetTransacoes")]
        public async Task<IEnumerable<Transacao>> ObterTransacoes()
        {
            return await Task.FromResult(new List<Transacao>
            {
                new Transacao { Id = 1, Descricao = "Compra de supermercado", Valor = 150.00m, Data = DateTime.Now },
                new Transacao { Id = 2, Descricao = "Pagamento de conta de luz", Valor = 75.00m, Data = DateTime.Now.AddDays(-1) },
                new Transacao { Id = 3, Descricao = "Venda de produto", Valor = 200.00m, Data = DateTime.Now.AddDays(-2) }
            });
        }
    }

    public class Transacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    };
}