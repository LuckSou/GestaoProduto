namespace GestaoProduto.Domain.Models
{
    public class BaseModel
    {
        private int _Id { get; set; }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private DateTime _createAt { get; set; }
        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }
        private DateTime _updateAt { get; set; }
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }

    }
}
