using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoProduto.Domain.DTO.Produto
{
    public class ProdutoDTO
    {
        [Required(ErrorMessage = "A descrição do produto é obrigatória.")]
        [StringLength(100, ErrorMessage = "A descrição do produto deve ter no máximo 100 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O status do produto é obrigatório.")]
        public int StatusProduto { get; set; }

        [Required(ErrorMessage = "A data de fabricação é obrigatória.")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "A data de validade é obrigatória.")]
        [Compare(nameof(DataFabricacao), ErrorMessage = "A data de validade não pode ser menor que a data de fabricação.")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "O ID do fornecedor é obrigatório.")]
        public int FornecedorID { get; set; }
    }
}
