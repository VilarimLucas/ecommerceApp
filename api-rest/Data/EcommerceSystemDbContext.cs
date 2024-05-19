using api_rest.Data.Map;
using api_rest.models;
using api_rest.Models;
using Microsoft.EntityFrameworkCore;

namespace api_rest.Data
{
    public class EcommerceSystemDbContext : DbContext
    {
        public EcommerceSystemDbContext(DbContextOptions<EcommerceSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<UserCheckoutModel> UserCheckouts { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<StockProductModel> StockProducts { get; set; }
        public DbSet<ShipingModel> Shippings { get; set; }
        public DbSet<PaymentModel> Payments { get; set; }
        public DbSet<OrderSaleModel> OrdersSales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
