using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManager.Domain.Entities;

namespace SalesManager.Infrastructure.Data.PostgreSql.Mappings
{
    public class ClientEntityMapper : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("clients");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                   .HasColumnName("id")
                   .ValueGeneratedNever();

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(200)
                   .HasColumnName("name");

            builder.Property(c => c.Email)
                   .IsRequired()
                   .HasMaxLength(254)
                   .HasColumnName("email");

            builder.Property(c => c.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnName("phone_number");

            builder.Property(c => c.CreatedAt)
                   .IsRequired()
                   .HasColumnName("created_at")
                   .HasColumnType("timestamp with time zone");

            builder.Property(c => c.UpdatedAt)
                   .IsRequired()
                   .HasColumnName("updated_at")
                   .HasColumnType("timestamp with time zone");
        }
    }
}
