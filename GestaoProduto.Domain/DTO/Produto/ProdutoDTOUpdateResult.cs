namespace GestaoProduto.Domain.DTO.Produto
{
    public class ProdutoDTOUpdateResult
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int StatusProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int FornecedorID { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
