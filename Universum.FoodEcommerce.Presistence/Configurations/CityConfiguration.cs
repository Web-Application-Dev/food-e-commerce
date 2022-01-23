using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Presistence.Configurations
{
    class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(city => city.Id);

            builder.Property(city => city.Id);

            builder.Property(city => city.Name)
                .IsRequired();

            builder.Property(city => city.ZipCode)
                    .IsRequired();

            builder.Property(city => city.StateId)
                    .IsRequired();

            Relationships(builder);

            builder.ToTable("City");
        }

        private void Relationships(EntityTypeBuilder<City> builder)
        {
            builder.HasOne(x => x.State)
               .WithMany(x => x.Cities)
               .HasForeignKey(x => x.StateId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
 
    
}
