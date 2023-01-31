using System.ComponentModel.DataAnnotations;

namespace GestaoProduto.Domain.DTO.Fornecedor
{
    public class FornecedorDTOCompleto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

    }
}
