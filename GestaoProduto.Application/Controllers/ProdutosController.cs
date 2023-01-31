using GestaoProduto.Domain.DTO.Produto;
using GestaoProduto.Domain.Interfaces.Produto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GestaoProduto.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public IProdutoService _service { get; set; }
        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodos()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> BuscarProdutoPorId(int id)
        {
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarProduto([FromBody] ProdutoDTOCreate produto)
        {
            try
            {
                var result = await _service.Post(produto);
                if (result != null)
                {
                    return Ok(result); 
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarProduto([FromBody] ProdutoDTOUpdate produto)
        {
            try
            {
                var result = await _service.Put(produto);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult> AtualizarSituacaoProduto(int id)
        {
            try
            {
                var result = await _service.PutStatus(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
