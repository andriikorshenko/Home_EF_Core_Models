using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Task_002.Entities;

namespace Task_002.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> typeBuilder)
        {
            typeBuilder
                .HasMany(p => p.Orders)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerId)
                .HasPrincipalKey(p => p.Id);

            typeBuilder
                .Property(p => p.FirstName).IsRequired()
                .HasMaxLength(50);

            typeBuilder
                .Property(p => p.SecondName).IsRequired()
                .HasMaxLength(50);

            typeBuilder
                .Property(p => p.PhoneNumber).IsRequired();
        }
    }
}
