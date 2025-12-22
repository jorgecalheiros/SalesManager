using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManager.Domain.Entities;

namespace SalesManager.Infrastructure.Data.PostgreSql.Mappings
{
    public class SaleItemEntityMapper : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("sale_items");

            builder.HasKey(si => si.Id);
            builder.Property(si => si.Id)
                   .HasColumnName("id")
                   .ValueGeneratedNever();

            builder.Property(s => s.SaleId)
                   .IsRequired()
                   .HasColumnName("sale_id");

            builder.Property(si => si.ProductId)
                   .IsRequired()
                   .HasColumnName("product_id");

            builder.Property(si => si.UnitPrice)
                   .IsRequired()
                   .HasColumnName("unit_price")
                   .HasColumnType("numeric(18,2)");

            builder.Property(si => si.Quantity)
                   .IsRequired()
                   .HasColumnName("quantity");

            builder.Ignore(si => si.Total);

            builder.Property(si => si.CreatedAt)
                   .IsRequired()
                   .HasColumnName("created_at")
                   .HasColumnType("timestamp with time zone");

            builder.Property(si => si.UpdatedAt)
                   .IsRequired()
                   .HasColumnName("updated_at")
                   .HasColumnType("timestamp with time zone");

            builder.HasOne<Sale>()
                   .WithMany(s => s.Items)
                   .HasForeignKey(si => si.SaleId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Product>()
                   .WithMany()
                   .HasForeignKey(si => si.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
