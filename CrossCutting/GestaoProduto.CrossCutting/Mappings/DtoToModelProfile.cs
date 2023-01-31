using AutoMapper;
using GestaoProduto.Domain.DTO.Fornecedor;
using GestaoProduto.Domain.DTO.Produto;
using GestaoProduto.Domain.Models;

namespace GestaoProduto.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<ProdutoDTO, ProdutoModel>().ReverseMap();
            CreateMap<ProdutoDTOCompleto, ProdutoModel>().ReverseMap();
            CreateMap<ProdutoDTOCreate, ProdutoModel>().ReverseMap();
            CreateMap<ProdutoDTOCreateResult, ProdutoModel>().ReverseMap();
            CreateMap<ProdutoDTOUpdate, ProdutoModel>().ReverseMap();
            CreateMap<ProdutoDTOUpdateResult, ProdutoModel>().ReverseMap();

            CreateMap<FornecedorDTO, FornecedorModel>().ReverseMap();
            CreateMap<FornecedorDTOCompleto, FornecedorModel>().ReverseMap();
            CreateMap<FornecedorDTOCreate, FornecedorModel>().ReverseMap();
            CreateMap<FornecedorDTOCreateResult, FornecedorModel>().ReverseMap();
            CreateMap<FornecedorDTOUpdate, FornecedorModel>().ReverseMap();
            CreateMap<FornecedorDTOUpdateResult, FornecedorModel>().ReverseMap();
        }

    }
}
