using _01.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.DataContext
{
    public static class CustmerModelBuilderExtension
    {
        public static void CustmerModelBuilder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(cus => cus.Id);
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Customer>().Property(p => p.NationalCode)
                                           .HasMaxLength(10)
                                           .IsRequired();

            modelBuilder.Entity<Customer>().Property(p => p.Phone)
                                           .HasMaxLength(11)
                                           .IsRequired();
            modelBuilder.Entity<Customer>().Property(p => p.Email).IsRequired();

            modelBuilder.Entity<Customer>().Property(p => p.FirstName)
                                           .HasMaxLength(20)
                                           .IsRequired();

            modelBuilder.Entity<Customer>().Property(p => p.LastName)
                                           .HasMaxLength(20)
                                           .IsRequired();
            modelBuilder.Entity<Customer>()
                        .HasMany(xx => xx.Addresses)
                        .WithOne(xx => xx.Customer)
                        .HasForeignKey(xx => xx.CustomerId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Customer>()
                        .HasMany(xx => xx.Orders)
                        .WithOne(xx => xx.Customer)
                        .HasForeignKey(xx => xx.CustomerId)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
