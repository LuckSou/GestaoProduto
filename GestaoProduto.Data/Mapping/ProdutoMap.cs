using GestaoProduto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProduto.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.StatusProduto)
                .HasColumnType("int");

            builder.Property(p => p.DataFabricacao)
                .HasColumnType("date");

            builder.Property(p => p.DataValidade)
            .HasColumnType("date");

            builder.HasOne(p => p.Fornecedor)
            .WithMany(b => b.Produtos)
            .HasForeignKey(p => p.FornecedorID)
            .HasPrincipalKey(b => b.Id);
        }
    }
}
