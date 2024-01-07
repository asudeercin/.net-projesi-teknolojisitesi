using Microsoft.EntityFrameworkCore;
using shopapp.data.Configurations;
using shopapp.entity;


namespace shopapp.data.Concrete.EfCore
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
     
       
        public DbSet<Comment> Comments { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlite("Data Source=shopDb");
         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());    


 modelBuilder.Entity<Comment>()
        .HasOne(c => c.Product)
        .WithMany(p => p.Comments)
        .HasForeignKey(c => c.ProductId);
            modelBuilder.Seed();        
        }


    }
}