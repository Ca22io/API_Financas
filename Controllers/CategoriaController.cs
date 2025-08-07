using API_Financas.Domain.Enum;
using API_Financas.Dto.Categoria;
using API_Financas.Models;
using API_Financas.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Financas.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaRepository)
        {
            _categoriaService = categoriaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Obtercategorias()
        {
            return Ok( await _categoriaService.ObterCategorias());
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarCategoria([FromBody] CategoriaDto categoria)
        {
            if (ModelState.IsValid)
            {
                var Categoria = await _categoriaService.AdicionarCategoria(categoria);

                return Categoria switch
                {
                    StatusOperacao.Sucesso => Created(categoria.ToString(), "Categoria criada com sucesso!"),
                    StatusOperacao.Erro => BadRequest("Erro ao adicionar categoria!")
                };
            }

            return BadRequest(categoria);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCategoria([FromBody] CategoriaDto categoria)
        {
            if (ModelState.IsValid)
            {
                var Categoria = await _categoriaService.AtualizarCategoria(categoria);

                return Categoria switch
                {
                    StatusOperacao.Sucesso => NoContent(),
                    StatusOperacao.NaoEncontrado => NotFound("Categoria não localizada!"),
                    StatusOperacao.Erro => BadRequest("Erro ao atualizar categoria!")
                };
            }

            return BadRequest(categoria);
        }

        [HttpDelete("{IdCategoria}")]
        public async Task<IActionResult> RemoverCategoria(int IdCategoria)
        {
            if (IdCategoria > 0)
            {
                var Categoria = await _categoriaService.RemoverCategoria(IdCategoria);

                return Categoria switch
                {
                    StatusOperacao.Sucesso => Ok("Categoria removida com sucesso!"),
                    StatusOperacao.NaoEncontrado => NotFound("Categoria não localizada"),
                    StatusOperacao.IdInvalido => BadRequest("O Id passado é invalido!"),
                    StatusOperacao.Erro => BadRequest("Erro ao excluir categoria!")
                };
            }

            return BadRequest("O Id passado é invalido!");
            
        }
    }
}