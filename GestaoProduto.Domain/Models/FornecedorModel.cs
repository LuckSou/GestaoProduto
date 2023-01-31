namespace GestaoProduto.Domain.Models
{
    public class FornecedorModel : BaseModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _CNPJ;

        public string CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value; }
        }

    }
}
