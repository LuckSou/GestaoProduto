using GestaoProduto.Domain.DTO.Fornecedor;

namespace GestaoProduto.Domain.Interfaces.Fornecedor
{
    public interface IFornecedorService
    {
        Task<FornecedorDTO> Get(int id);
        Task<IEnumerable<FornecedorDTOCompleto>> GetAll();
        Task<FornecedorDTOCreateResult> Post(FornecedorDTOCreate fornecedor);
        Task<FornecedorDTOUpdateResult> Put(FornecedorDTOUpdate fornecedor);
        Task<bool> Delete(int id);
    }
}
