namespace GestaoProduto.Domain.DTO.Fornecedor
{
    public class FornecedorDTOUpdateResult
    {

        public int Id { get; set; }
        public string Nome { get;  set; }
        public string CNPJ { get;  set; }
        public DateTime UpdateAt { get; set; }
    }
}
