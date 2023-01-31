using AutoMapper;
using GestaoProduto.Domain.DTO.Fornecedor;
using GestaoProduto.Domain.DTO.Produto;
using GestaoProduto.Domain.Entities;

namespace GestaoProduto.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ProdutoDTO, ProdutoEntity>().ReverseMap();
            CreateMap<ProdutoDTOCompleto, ProdutoEntity>().ReverseMap();
            CreateMap<ProdutoDTOCreate, ProdutoEntity>().ReverseMap();
            CreateMap<ProdutoDTOCreateResult, ProdutoEntity>().ReverseMap();
            CreateMap<ProdutoDTOUpdate, ProdutoEntity>().ReverseMap();
            CreateMap<ProdutoDTOUpdateResult, ProdutoEntity>().ReverseMap();

            CreateMap<FornecedorDTO, FornecedorEntity>().ReverseMap();
            CreateMap<FornecedorDTOCompleto, FornecedorEntity>().ReverseMap();
            CreateMap<FornecedorDTOCreate, FornecedorEntity>().ReverseMap();
            CreateMap<FornecedorDTOCreateResult, FornecedorEntity>().ReverseMap();
            CreateMap<FornecedorDTOUpdate, FornecedorEntity>().ReverseMap();
            CreateMap<FornecedorDTOUpdateResult, FornecedorEntity>().ReverseMap();

        }
    }
}
