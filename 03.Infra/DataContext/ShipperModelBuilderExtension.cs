using _01.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.DataContext
{
    public static class ShipperModelBuilderExtension
    {
        public static void ShippingOnModelBuilderExtension(this ModelBuilder builder)
        {
            builder.Entity<Shipper>().ToTable("Shippers");

            builder.Entity<Shipper>().HasKey(pk => pk.Id);

            builder.Entity<Shipper>().Property(pr => pr.Name)
                                      .HasColumnName("Name")
                                      .IsRequired();

            builder.Entity<Shipper>().HasMany(ord => ord.Orders)
                                      .WithOne(ship => ship.Shipper)
                                      .HasForeignKey(fk => fk.ShipperId)
                                      .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
