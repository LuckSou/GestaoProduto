using System.ComponentModel.DataAnnotations;

namespace GestaoProduto.Domain.DTO.Produto
{
    public class ProdutoDTO
    {
        [Required(ErrorMessage = "É necessario informar a descrição do produto!")]
        [StringLength(100, ErrorMessage = "A descrição do produto deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }

        public int StatusProduto { get; set; }

        [Required(ErrorMessage = "A data de fabricação é obrigatória.")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "A data de validade é obrigatória.")]
        [Compare("DataValidade", ErrorMessage = "A data de fabricação não pode ser maior ou igual à data de validade.")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "É necessario informar o ID do fornecedor.")]
        public int FornecedorID { get; set; }
    }
}
