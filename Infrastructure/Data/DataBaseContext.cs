using Core.Entities.Category;
using Core.Entities.DashBoard;
using Core.Entities.Information;
using Core.Entities.Product;
using Core.Entities.Store;
using Infrastructure.EntitiesConfiguration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataBaseContext : IdentityDbContext
    {
        public DataBaseContext() : base() { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new MainCategoryConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new OptionsConfiguration());
            builder.ApplyConfiguration(new BagConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());

            builder.Entity<MainCategory>().HasData(SeedData.SeedMainCategory());
            builder.Entity<SubCategory>().HasData(SeedData.SeedSubCategory());
            builder.Entity<CategoryEntity>().HasData(SeedData.SeedCategory());
            builder.Entity<ProductEntity>().HasData(SeedData.SeedProduct());
            builder.Entity<ImageEntity>().HasData(SeedData.SeedImage());
            builder.Entity<StorageEntity>().HasData(SeedData.SeedStorage());
            builder.Entity<ImageForHome>().HasData(SeedData.SeedImageForHome());

            builder.Entity<StoreEntity>().HasData(SeedData.SeedStores());
            builder.Entity<Info>().HasData(SeedData.SeedInfos());
            builder.Entity<Options>().HasData(SeedData.SeedOptions());
        }
        public DbSet<User> User { get; set; }

        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<StorageEntity> Storage { get; set; }
        public DbSet<ImageForHome> ImageForHome { get; set; }


        public DbSet<StoreEntity> Store { get; set; }
        public DbSet<Info> Info { get; set; }
        public DbSet<Options> Options { get; set; }
    }
}
