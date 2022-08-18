using Microsoft.EntityFrameworkCore;

namespace AspStore.ShopUi.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Tbl_Products { get; set; }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                        new Product
                        {
                            Id = 1,
                            Category = "Mobile",
                            Name = "Apple Iphone 13",
                            Description = "آخرین محصول اپل",
                            Price = 25_000_000
                        },
                            new Product
                            {
                                Id = 2,
                                Category = "Mobile",
                                Name = "Sony Xperia xz",
                                Description = "آخرین محصول سونی",
                                Price = 15_000_000
                            },
                                new Product
                                {
                                    Id = 3,
                                    Category = "Mobile",
                                    Name = "Samsung s20",
                                    Description = "آخرین محصول ساسمونگ",
                                    Price = 20_000_000
                                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
