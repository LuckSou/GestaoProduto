using GestaoProduto.Domain.Entities;

namespace GestaoProduto.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(int id);
        Task<T> BuscaIDAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
    }
}
