namespace GestaoProduto.Domain.Models
{
    public class ProdutoModel : BaseModel
    {
        public string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public int _statusProduto;

        public int StatusProduto
        {
            get { return _statusProduto; }
            set { _statusProduto = value; }
        }

        public DateTime _dataFabricacao;

        public DateTime DataFabricacao
        {
            get { return _dataFabricacao; }
            set { _dataFabricacao = value; }
        }

        public DateTime _dataValidade;

        public DateTime DataValidade
        {
            get { return _dataValidade; }
            set { _dataValidade = value; }
        }

        public int _fornecedorID;

        public int FornecedorID
        {
            get { return _fornecedorID; }
            set { _fornecedorID = value; }
        }

    }
}
