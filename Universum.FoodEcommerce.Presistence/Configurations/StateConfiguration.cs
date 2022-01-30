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
    class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(state => state.Id);

            builder.Property(state => state.Id);

            builder.Property(state => state.Name)
                .IsRequired();

            builder.Property(state => state.ShortCode)
                    .IsRequired();

            builder.ToTable("States");
        }
    }
}
