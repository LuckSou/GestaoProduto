namespace GestaoProduto.Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public string Descricao { get; set; }
        public int StatusProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int FornecedorID { get; private set; }
        public FornecedorEntity Fornecedor { get; set; }
    }

}
