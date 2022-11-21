using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebinarApiRest.Entities;

namespace WebinarApiRest.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        // Fluent API
        builder.Property(p => p.FirstName)
            .HasMaxLength(100);

        builder.Property(p => p.LastName)
            .HasMaxLength(100);
        //crear registros por default
        builder.HasData(new List<Customer>()
        {
            new Customer {Id = 1, FirstName = "Hugo", LastName = "Vilchez", Age = 25},
            new Customer {Id = 2, FirstName = "Bryan", LastName = "Peralta", Age = 20},
            new Customer {Id = 3, FirstName = "Juan", LastName = "Diaz", Age = 10},
        });
    }
}