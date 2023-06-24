using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PerfumeAppAPI.Data.Configurations;
using PerfumeAppAPI.Data.Entities;

namespace PerfumeAppAPI.Data
{
    public class StoreDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSale> ProductsSale { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-V122D4I5;Database=PerfumeStoreDb;Trusted_Connection = True;TrustServerCertificate= True;");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfigurations());
            builder.ApplyConfiguration(new UserConfigurations ());
            builder.ApplyConfiguration(new UserRoleConfigurations());
            builder.ApplyConfiguration(new ProductsConfigurations());

        }
    }
}
