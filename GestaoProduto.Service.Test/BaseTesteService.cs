
using AutoMapper;
using GestaoProduto.CrossCutting.Mappings;

namespace GestaoProduto.Service.Test
{
    public abstract class BaseTesteService
    {
        public IMapper Mapper {get; set;}

        public  BaseTesteService()
        {
            Mapper = new AutoMapperFixture().GetMapper();
        }

        public class AutoMapperFixture : IDisposable
        {
            public IMapper GetMapper()
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new DtoToModelProfile());
                    cfg.AddProfile(new EntityToDtoProfile());
                    cfg.AddProfile(new ModelToEntityProfile());
                });

                return config.CreateMapper();
            }
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}