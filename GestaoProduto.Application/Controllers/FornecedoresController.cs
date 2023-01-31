using GestaoProduto.Domain.DTO.Fornecedor;
using GestaoProduto.Domain.Interfaces.Fornecedor;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GestaoProduto.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        public IFornecedorService _service { get; set; }
        public FornecedoresController(IFornecedorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> BuscaFornecedores()
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
        public async Task<ActionResult> BuscaFornecedorID(int id)
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
        public async Task<ActionResult> InsereFornecedor([FromBody] FornecedorDTOCreate fornecedor)
        {
            try
            {
                var result = await _service.Post(fornecedor);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetWithIdFornecedor", new { id = result.Id })), result);
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
        public async Task<ActionResult> AtualizaFornecedores([FromBody] FornecedorDTOUpdate fornecedor)
        {
            try
            {
                var result = await _service.Put(fornecedor);
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
