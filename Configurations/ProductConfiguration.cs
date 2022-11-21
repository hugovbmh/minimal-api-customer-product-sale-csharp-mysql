using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebinarApiRest.Entities;

namespace WebinarApiRest.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Code)
                .HasMaxLength(20);
            builder.Property(p => p.Description)
                .HasMaxLength(200);
            builder.Property(p => p.UnitPrice)
                .HasPrecision(11, 2);
            builder.HasData(new List<Product>()
            {
                new Product{Id = 1, Code="1000",Description="Playstation 4",UnitPrice = 299},
                new Product{Id = 2, Code="2000",Description="Xbox Series 4",UnitPrice = 400},
                new Product{Id = 3, Code="3000",Description="Nintendo Switch",UnitPrice = 500},
                new Product{Id = 4, Code="4000",Description="Playstation 5",UnitPrice = 600},
            });
        }
    }
}
