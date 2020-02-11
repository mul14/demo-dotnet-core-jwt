using Microsoft.EntityFrameworkCore;
using Program.Models;

namespace Program.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CartModel> Carts { get; set; }
        
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
