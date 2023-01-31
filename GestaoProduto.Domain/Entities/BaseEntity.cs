using System.ComponentModel.DataAnnotations;

namespace GestaoProduto.Domain.Entities

{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }
    }
}
