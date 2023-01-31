using GestaoProduto.Domain.Interfaces.Fornecedor;
using GestaoProduto.Domain.Interfaces.Produto;
using GestaoProduto.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoProduto.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProdutoService, ProdutoService>();
            serviceCollection.AddTransient<IFornecedorService, FornecedorService>();
        }
    }
}
