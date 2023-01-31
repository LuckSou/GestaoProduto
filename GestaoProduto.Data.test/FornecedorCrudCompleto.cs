using GestaoProduto.Data.Repository;
using GestaoProduto.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestaoProduto.Data.test.BaseTest;

namespace GestaoProduto.Data.test
{
    public class FornecedorCrudCompleto : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvider;

        public FornecedorCrudCompleto(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD de Fornecedor")]
        [Trait("CRUD", "FornecedorEntity")]
        public async Task EPossivelRealizarCRUDFornecedor()
        {
            using (var context = _serviceProvider.GetService<DbTeste>())
            {
                //BaseRepository _repository = new BaseRepository(context);
            }
        }
    }
}
