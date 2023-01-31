namespace GestaoProduto.Domain.Entities
{
    public class FornecedorEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public IEnumerable<ProdutoEntity> Produtos { get; set; }

    }
}
