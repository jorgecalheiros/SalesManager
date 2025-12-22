using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManager.Domain.Entities;

namespace SalesManager.Infrastructure.Data.PostgreSql.Mappings
{
    public class SaleEntityMapper : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("sales");

            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id)
                   .HasColumnName("id")
                   .ValueGeneratedNever();

            builder.Property(s => s.ClientId)
                   .IsRequired()
                   .HasColumnName("client_id");

            builder.Ignore(s => s.Total);

            builder.HasMany(s => s.Items)
                   .WithOne()
                   .HasForeignKey(s => s.SaleId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(s => s.CreatedAt)
                   .IsRequired()
                   .HasColumnName("created_at")
                   .HasColumnType("timestamp with time zone");

            builder.Property(s => s.UpdatedAt)
                   .IsRequired()
                   .HasColumnName("updated_at")
                   .HasColumnType("timestamp with time zone");
        }
    }
}
