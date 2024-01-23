using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.DataContext
{
    public class Context:DbContext
    {
        public Context() { } // Parametresiz kurucu eklendi
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ProductCategory yapılandırması
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId }); // Bileşik anahtar tanımı

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product) // ProductCategory ile Product arasında bir-çok ilişki
                .WithMany(p => p.ProductCategories) // Product tarafında koleksiyon
                .HasForeignKey(pc => pc.ProductId); // ForeignKey tanımı

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category) // ProductCategory ile Category arasında bir-çok ilişki
                .WithMany(c => c.ProductCategories) // Category tarafında koleksiyon
                .HasForeignKey(pc => pc.CategoryId); // ForeignKey tanımı
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories  { get; set; }
        public DbSet<Order>Orders  { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
