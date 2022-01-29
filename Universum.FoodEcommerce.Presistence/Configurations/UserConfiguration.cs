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
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);

            builder.Property(user => user.Id);

            builder.Property(user => user.Name)
                .IsRequired();

            builder.Property(user => user.LastName)
                .IsRequired();

            builder.Property(user => user.Password)
                .IsRequired();

            builder.Property(user => user.RoleId)
                .IsRequired();

            builder.Property(user => user.GenderId)
                .IsRequired();

            builder.Property(user => user.AddressId)
                .IsRequired();            

            builder.ToTable("Users");
        }

      
    }
}
