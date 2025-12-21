using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManager.Domain.Entities;

namespace SalesManager.Infrastructure.Data.PostgreSql.Mappings
{
    public class ProductEntityMapper : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                   .HasColumnName("id")
                   .ValueGeneratedNever();

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(200)
                   .HasColumnName("name");

            builder.Property(p => p.Description)
                   .IsRequired()
                   .HasMaxLength(1000)
                   .HasColumnName("description");

            builder.Property(p => p.Price)
                   .IsRequired()
                   .HasColumnName("price")
                   .HasColumnType("numeric(18,2)");

            builder.Property(p => p.Stock)
                   .IsRequired()
                   .HasColumnName("stock");

            builder.Property(p => p.CreatedAt)
                   .IsRequired()
                   .HasColumnName("created_at")
                   .HasColumnType("timestamp with time zone");

            builder.Property(p => p.UpdatedAt)
                   .IsRequired()
                   .HasColumnName("updated_at")
                   .HasColumnType("timestamp with time zone");
        }
    }
}
