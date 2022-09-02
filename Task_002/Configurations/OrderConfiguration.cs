using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_002.Entities;

namespace Task_002.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> typeBuilder)
        {
            typeBuilder
                .Property(p => p.ProductName).IsRequired()
                .HasMaxLength(50);

            typeBuilder
                .Property(p => p.Quontity).IsRequired()
                .HasMaxLength(1000);

            typeBuilder
                .Property(p => p.Price).IsRequired();
        }
    }
}
