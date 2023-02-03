using GestaoProduto.Domain.DTO.Fornecedor;
using GestaoProduto.Domain.Interfaces.Fornecedor;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Fornecedor.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedoresController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpGet]
        public ActionResult BuscarTodosFornecedores()
        {
            try
            {
                var fornecedores = _fornecedorService.GetAll();
                return Ok(fornecedores);
            }
            catch (Exception ex)
            {
                return TratarErro(ex);
            }
        }

        [HttpGet]
        public ActionResult BuscarFornecedorPorId(int id)
        {
            try
            {
                var fornecedor = _fornecedorService.Get(id);
                return Ok(fornecedor);
            }
            catch (Exception ex)
            {
                return TratarErro(ex);
            }
        }

        [HttpPost]
        public ActionResult CadastrarFornecedor([FromBody] FornecedorDTOCreate fornecedorDTO)
        {
            try
            {
                var fornecedor = _fornecedorService.Post(fornecedorDTO);
                if (fornecedor == null)
                {
                    return BadRequest();
                }
                return Ok(fornecedor);
            }
            catch (Exception ex)
            {
                return TratarErro(ex);
            }
        }

        [HttpPut]
        public ActionResult AtualizarFornecedor([FromBody] FornecedorDTOUpdate fornecedorDTO)
        {
            try
            {
                var fornecedor = _fornecedorService.Put(fornecedorDTO);
                if (fornecedor == null)
                {
                    return BadRequest();
                }
                return Ok(fornecedor);
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


