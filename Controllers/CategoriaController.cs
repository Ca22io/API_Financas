using API_Financas.Data.Repositories;
using API_Financas.Domain.Enum;
using API_Financas.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Financas.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaController(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Obtercategorias()
        {
            return Ok(_categoriaRepository.ObterCategoriasAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarCategoria([FromBody] CategoriaModel categoria)
        {
            if (ModelState.IsValid)
            {
                var Categoria = await _categoriaRepository.AdicionarCategoriaAsync(categoria);

                return Categoria switch
                {
                    StatusOperacao.Sucesso => Ok("Categoria criada com sucesso!"),
                    StatusOperacao.Erro => BadRequest("Erro ao adicionar categoria!")
                };
            }

            return BadRequest(categoria);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCategoria([FromBody] CategoriaModel categoria)
        {
            if (ModelState.IsValid)
            {
                var Categoria = await _categoriaRepository.AtualizarCategoriaAsync(categoria);

                return Categoria switch
                {
                    StatusOperacao.Sucesso => Ok("Categoria atualiza com sucesso!"),
                    StatusOperacao.NaoEncontrado => BadRequest("Categoria não localizada!"),
                    StatusOperacao.Erro => BadRequest("Erro ao atualizar categoria!")
                };
            }


            return BadRequest(categoria);
        }

        [HttpDelete("[IdCategoria]")]
        public async Task<IActionResult> RemoverCategoria(int IdCategoria)
        {
            if (IdCategoria > 0)
            {
                var Categoria = await _categoriaRepository.RemoverCategoriaAsync(IdCategoria);

                return Categoria switch
                {
                    StatusOperacao.Sucesso => Ok("Categoria removida com sucesso!"),
                    StatusOperacao.NaoEncontrado => BadRequest("Categoria não localizada"),
                    StatusOperacao.IdInvalido => BadRequest("O Id passado é invalido!"),
                    StatusOperacao.Erro => BadRequest("Erro ao excluir categoria!")
                };
            }

            return BadRequest("O Id passado é invalido!");
            
        }
    }
}