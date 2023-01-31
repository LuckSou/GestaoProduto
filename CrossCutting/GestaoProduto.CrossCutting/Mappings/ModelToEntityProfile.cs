using AutoMapper;
using GestaoProduto.Domain.Entities;
using GestaoProduto.Domain.Models;

namespace GestaoProduto.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<ProdutoModel, ProdutoEntity>().ReverseMap();

            CreateMap<FornecedorModel, FornecedorEntity>().ReverseMap();
        }
    }
}
