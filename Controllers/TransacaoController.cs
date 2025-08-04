using System.Linq;
using System.Threading.Tasks;
using API_Financas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Financas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : ControllerBase
    {
        readonly FinancasContext _context;

        public TransacaoController(FinancasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTransacoes()
        {

            var transacoes = await _context.Transacoes
                .Include(t => t.Categorias)
                .Include(t => t.Tipos)
                .OrderBy(t => t.Data)
                .AsNoTracking()
                .ToListAsync();

            return Ok(transacoes);
            
        }
        
    }

   
}