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
    class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasKey(orderStatus => orderStatus.Id);

            builder.Property(orderStatus => orderStatus.Id);

            builder.Property(orderStatus => orderStatus.Orders)
                .IsRequired();



            builder.ToTable("OrderStatus");
        }

       
    }
}
