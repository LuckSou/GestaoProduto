using GestaoProduto.Domain.Interfaces.Fornecedor;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProduto.Service.Test
{
    public class QuandoForExecutadoGet : FornecedorTestes
    {
        private IFornecedorService _service;
        private Mock<IFornecedorService> _serviceMock;

        [Fact(DisplayName ="É Possivel Executar o Metodo GET.")]      
        public async Task GET_BuscaFornecedorPorID_DeveRetornarFornecedorDTO()
        {
            _serviceMock= new Mock<IFornecedorService>();
            _serviceMock.Setup(m => m.Get(ID)).ReturnsAsync(fornecedorDTO);
            _service = _serviceMock.Object;

            var result = await _service.Get(ID);

            Assert.NotNull(result);
            Assert.Equal(result.CNPJ, CNPJFornecedor);

        }
    }
}
