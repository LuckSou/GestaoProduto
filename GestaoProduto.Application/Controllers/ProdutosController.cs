using GestaoProduto.Domain.DTO.Produto;
using GestaoProduto.Domain.Interfaces.Produto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GestaoProduto.Application.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public IProdutoService _service { get; set; }
        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [Route("api/BuscarTodos")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
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
        [Route("api/BuscarProdutoPorId")]
        public async Task<ActionResult> Get(int id)
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
        [Route("api/CadastrarProduto")]
        public async Task<ActionResult> Post([FromBody] ProdutoDTOCreate produto)
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
        [Route("api/AtualizarProduto")]
        public async Task<ActionResult> Put([FromBody] ProdutoDTOUpdate produto)
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
    }
}
