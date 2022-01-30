using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Presistence.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);

            builder.Property(product => product.Id);

            builder.Property(product => product.Name)
                .IsRequired();

            builder.Property(product => product.Description)
                .IsRequired();

            builder.Property(product => product.Price)
                .IsRequired();

            builder.Property(product => product.PhotoId)
                .IsRequired();

            Relationships(builder);

            builder.ToTable("Products");
        }

        private void Relationships(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x=>x.Photo)
                .WithOne(x => x.Product)
                .HasForeignKey<Product>(x=>x.PhotoId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
