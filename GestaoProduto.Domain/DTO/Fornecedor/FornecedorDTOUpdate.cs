using System.ComponentModel.DataAnnotations;

namespace GestaoProduto.Domain.DTO.Fornecedor
{
    public class FornecedorDTOUpdate
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
