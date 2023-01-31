using GestaoProduto.Domain.DTO.Fornecedor;

namespace GestaoProduto.Domain.DTO.Produto
{
    public class ProdutoDTOCompleto
    {
        public string Descricao { get; set; }
        public int StatusProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public FornecedorDTO FornecedorDTO { get; set; }
    }
}
