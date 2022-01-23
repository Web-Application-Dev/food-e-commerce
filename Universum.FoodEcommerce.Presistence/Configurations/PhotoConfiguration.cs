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
    class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasKey(photo => photo.Id);

            builder.Property(photo => photo.Id);

            builder.Property(photo => photo.PhotoURL)
                .IsRequired();

            builder.Property(photo => photo.ProductId)
                .IsRequired();




            builder.ToTable("Photos");
        }


    }
}
