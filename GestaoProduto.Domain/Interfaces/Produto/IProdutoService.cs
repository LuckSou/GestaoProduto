using GestaoProduto.Domain.DTO.Produto;

namespace GestaoProduto.Domain.Interfaces.Produto
{
    public interface IProdutoService
    {
        Task<ProdutoDTO> Get(int id);
        Task<IEnumerable<ProdutoDTO>> GetAll();
        Task<ProdutoDTOCreateResult> Post(ProdutoDTOCreate produto);
        Task<ProdutoDTOUpdateResult> Put(ProdutoDTOUpdate produto);
        Task<bool> Delete(int id);
    }
}
