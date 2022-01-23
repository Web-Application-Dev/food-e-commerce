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
    class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(gender => gender.Id);

            builder.Property(gender => gender.Id);

            builder.Property(gender => gender.Name)
                .IsRequired();

            builder.ToTable("Gender");
        }

    }
}
