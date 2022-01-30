using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Universum.FoodEcommerce.Domain.Entities;


namespace Universum.FoodEcommerce.Presistence.Configurations
{
    class AddressConfiguration : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(address => address.Id);

            builder.Property(address => address.Id);

            builder.Property(address => address.CityId)
                .IsRequired();

            builder.Property(address => address.Street)
                .IsRequired();

            builder.Property(address => address.StreetNr)
                .IsRequired();

            Relationships(builder);

            builder.ToTable("Addresses");
        }

        private void Relationships(EntityTypeBuilder<Address> builder)
        {
            builder.HasOne(x => x.City)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
