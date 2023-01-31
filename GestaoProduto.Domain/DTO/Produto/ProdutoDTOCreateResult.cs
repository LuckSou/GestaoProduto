namespace GestaoProduto.Domain.DTO.Produto
{
    public class ProdutoDTOCreateResult
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int FornecedorID { get; set; }
        public DateTime CreatAt { get; set; }
    }
}
