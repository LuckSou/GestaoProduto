using AutoMapper;
using GestaoProduto.Domain.DTO.Fornecedor;
using GestaoProduto.Domain.Entities;
using GestaoProduto.Domain.Interfaces;
using GestaoProduto.Domain.Interfaces.Fornecedor;
using GestaoProduto.Domain.Models;

namespace GestaoProduto.Service.Service
{
    public class FornecedorService : IFornecedorService
    {
        private IRepository<FornecedorEntity> _repository;
        private readonly IMapper _mapper;

        public FornecedorService(IRepository<FornecedorEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<FornecedorDTO> Get(int id)
        {
            var entity = await _repository.BuscaIDAsync(id);
            return _mapper.Map<FornecedorDTO>(entity);
        }

        public async Task<IEnumerable<FornecedorDTOCompleto>> GetAll()
        {
            var listentity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<FornecedorDTOCompleto>>(listentity);
        }

        public async Task<FornecedorDTOCreateResult> Post(FornecedorDTOCreate fornecedor)
        {
            var model = _mapper.Map<FornecedorModel>(fornecedor);
            var entity = _mapper.Map<FornecedorEntity>(model);

            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<FornecedorDTOCreateResult>(result);
        }

        public async Task<FornecedorDTOUpdateResult> Put(FornecedorDTOUpdate fornecedor)
        {
            var model = _mapper.Map<FornecedorModel>(fornecedor);
            var entity = _mapper.Map<FornecedorEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<FornecedorDTOUpdateResult>(result);
        }
    }
}
