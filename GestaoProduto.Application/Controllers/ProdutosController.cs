using GestaoProduto.Domain.DTO.Produto;
using GestaoProduto.Domain.Interfaces.Produto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace GestaoProduto.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult BuscarTodos()
        {
            try
            {
                var result = _service.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return TratarErro(ex);
            }
        }

        [HttpGet]
        public ActionResult BuscarProdutoPorId(int id)
        {
            try
            {
                var result = _service.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return TratarErro(ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarProduto([FromBody] ProdutoDTOCreate produtoDTO)
        {
            try
            {
                var produto = await _service.Post(produtoDTO);
                if (produto != null)
                {
                    return Ok(produto);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return TratarErro(ex);
            }
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarProduto([FromBody] ProdutoDTOUpdate produtoDTO)
        {
            try
            {
                var produto = await _service.Put(produtoDTO);
                if (produto != null)
                {
                    return Ok(produto);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return TratarErro(ex);
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
            catch (Exception ex)
            {
                return TratarErro(ex);
            }
        }

        private ActionResult TratarErro(Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
        }
    }
}
