using AutoMapper;
using GestaoProduto.Domain.DTO.Produto;
using GestaoProduto.Domain.Entities;
using GestaoProduto.Domain.Interfaces;
using GestaoProduto.Domain.Interfaces.Produto;
using GestaoProduto.Domain.Models;

namespace GestaoProduto.Service.Service
{
    public class ProdutoService : IProdutoService
    {

        private IRepository<ProdutoEntity> _repository;
        private readonly IMapper _mapper;

        public ProdutoService(IRepository<ProdutoEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ProdutoDTO> Get(int id)
        {
            var entity = await _repository.BuscaIDAsync(id);
            return _mapper.Map<ProdutoDTO>(entity);
        }

        public async Task<IEnumerable<ProdutoDTO>> GetAll()
        {
            var listentity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(listentity);
        }

        public async Task<ProdutoDTOCreateResult> Post(ProdutoDTOCreate produto)
        {
            try
            {
                var model = _mapper.Map<ProdutoModel>(produto);
                var entity = _mapper.Map<ProdutoEntity>(model);

                var result = await _repository.InsertAsync(entity);
                return _mapper.Map<ProdutoDTOCreateResult>(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ProdutoDTOUpdateResult> Put(ProdutoDTOUpdate produto)
        {
            var model = _mapper.Map<ProdutoModel>(produto);
            var entity = _mapper.Map<ProdutoEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<ProdutoDTOUpdateResult>(result);
        }

    }
}

