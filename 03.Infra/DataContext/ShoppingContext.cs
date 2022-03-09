using _01.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.DataContext
{
    public class ShoppingContext : DbContext
    {
        private const string _connectionString =
            "Server=DESKTOP-4JUN5MG\\REZASQLSERVER;Database=ShoppingAppDB;Trusted_Connection=True;";
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddressOnModelBuilderExtension();
            modelBuilder.ShippingOnModelBuilderExtension();
            modelBuilder.ProductOnModelBuilderExtension();
            modelBuilder.OrderDetailOnModelBuilderExtension();
            modelBuilder.OrderOnModelBuilderExtension();
            modelBuilder.CustmerOnModelBuilderExtension();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
