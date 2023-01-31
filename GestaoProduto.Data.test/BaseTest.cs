using GestaoProduto.Data.Context;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoProduto.Data.test
{
    public class BaseTest
    {
        public BaseTest()
        {

        }

        public class DbTeste : IDisposable
        {
            private string dataBaseName = $"dbApiTest_{Guid.NewGuid().ToString().Replace("-","")}";
            public ServiceProvider ServiceProvider { get; set; }

            public DbTeste()
            {
                var connectionString = $"Persist Security Info=True;Server=localhost;Database+{dataBaseName};User=root;Password=1234@";
                var serviceCollection = new ServiceCollection();
                serviceCollection.AddDbContext<MyContext>(o =>
                    o.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)),
                    ServiceLifetime.Transient);
                ServiceProvider = serviceCollection.BuildServiceProvider();
                using (var context = ServiceProvider.GetService<MyContext>())
                {
                    context.Database.EnsureCreated();
                }
            }

            public void Dispose()
            {
                using (var context = ServiceProvider.GetService<MyContext>())
                {
                    context.Database.EnsureDeleted();
                }
            }
        }
    }
}