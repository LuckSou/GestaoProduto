using GestaoProduto.Data.Mapping;
using GestaoProduto.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestaoProduto.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<ProdutoEntity> Produtos { get; set; }
        public DbSet<FornecedorEntity> Fornecedores { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new FornecedorMap());
        }
    }
}
