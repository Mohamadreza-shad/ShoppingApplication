using _01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Infra.DataContext
{
    public static class OrderModelBuilderExtension
    {
        public static void OrderOnModelBuilderExtension(this ModelBuilder builder)
        {
            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<Order>().HasKey(pk => pk.Id);

            builder.Entity<Order>().Property(pr => pr.Id).HasColumnName("Id");

            builder.Entity<Order>().Property(pr => pr.OrderDate).IsRequired();

            builder.Entity<Order>().HasOne(ship => ship.Shipper)
                                   .WithMany(orderheader => orderheader.Orders)
                                   .HasForeignKey(fk => fk.ShipperId)
                                   .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>().HasMany(orderDetail => orderDetail.OrderDetails)
                                   .WithOne(orderHeader => orderHeader.Order)
                                   .HasForeignKey(fk => fk.OrderId)
                                   .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>().HasOne(ship => ship.Customer)
                                   .WithMany(orderheader => orderheader.Orders)
                                   .HasForeignKey(fk => fk.CustomerId)
                                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
