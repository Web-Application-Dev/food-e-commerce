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
    class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(productType => productType.Id);

            builder.Property(productType => productType.Id);

            builder.Property(productType => productType.Name)
                .IsRequired();

            builder.Property(product => product.ProductId)
                .IsRequired();

            builder.ToTable("ProductTypes");
        }
    }
}
