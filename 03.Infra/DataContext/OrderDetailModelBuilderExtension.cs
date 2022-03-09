using _01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace _03.Infra.DataContext
{
    public static class OrderDetailModelBuilderExtension
    {
        public static void OrderDetailOnModelBuilderExtension(this ModelBuilder builder)
        {
            builder.Entity<OrderDetail>().ToTable("OrderDetails");
            builder.Entity<OrderDetail>().HasKey(pk => pk.Id);

            builder.Entity<OrderDetail>().Property(pr => pr.Quantity)
                                         .HasColumnName("Quantity")
                                         .IsRequired();

            builder.Entity<OrderDetail>().Property(pr => pr.UnitPrice)
                                         .HasColumnName("UnitPrice")
                                         .IsRequired();

            builder.Entity<OrderDetail>().Property(pr => pr.TotalPrice)
                                         .HasColumnName("TotalPrice")
                                         .IsRequired();

            builder.Entity<OrderDetail>().HasOne(ordHeader => ordHeader.Order)
                                         .WithMany(ordDetail => ordDetail.OrderDetails)
                                         .HasForeignKey(fk => fk.OrderId)
                                         .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderDetail>().HasOne(p => p.Product)
                                         .WithMany(orderDetail => orderDetail.OrderDetails)
                                         .HasForeignKey(fk => fk.ProductId)
                                         .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
