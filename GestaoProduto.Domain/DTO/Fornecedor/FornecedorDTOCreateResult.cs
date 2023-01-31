namespace GestaoProduto.Domain.DTO.Fornecedor
{
    public class FornecedorDTOCreateResult
    {
        public int Id { get; set; }
        public string Nome { get;  set; }
        public string CNPJ { get;  set; }
        public DateTime CreatAt { get; set; }
    }
}
