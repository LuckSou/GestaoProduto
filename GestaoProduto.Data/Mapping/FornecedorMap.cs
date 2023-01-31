using GestaoProduto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProduto.Data.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<FornecedorEntity>
    {
        public void Configure(EntityTypeBuilder<FornecedorEntity> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(f => f.CNPJ)
                .IsUnique();

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.CNPJ)
                .IsRequired()
                .HasMaxLength(14);

        }
    }
}
