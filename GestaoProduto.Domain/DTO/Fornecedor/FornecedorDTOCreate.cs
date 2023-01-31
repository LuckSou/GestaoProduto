using System.ComponentModel.DataAnnotations;

namespace GestaoProduto.Domain.DTO.Fornecedor
{
    public class FornecedorDTOCreate
    {

        [Required(ErrorMessage = "É necessario informar o nome do Fornecedor!")]
        [StringLength(100, ErrorMessage = "O nome do Fornecedor deve ter no máximo {1} caracteres.")]
        public string Nome { get;  set; }

        [Required(ErrorMessage = "É necessario informar o CNPJ do Fornecedor!")]
        [StringLength(14, ErrorMessage = "O CNPJ do Fornecedor deve ter no máximo {1} caracteres.")]
        public string CNPJ { get;  set; }
    }
}
