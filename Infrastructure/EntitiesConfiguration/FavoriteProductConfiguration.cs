using Core.Entities.Bag_and_Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfiguration
{
    public class FavoriteProductConfiguration : IEntityTypeConfiguration<FavoriteProduct>
    {
        public void Configure(EntityTypeBuilder<FavoriteProduct> builder)
        {
            //Set Primary Key
            builder.HasKey(fp => new { fp.UserId, fp.ProductId });

            //Set Property configurations

            builder.HasOne(fp => fp.User)
                   .WithMany(u => u.FavoriteProducts)
                   .HasForeignKey(fp => fp.UserId);

            //Set Relationship configurations
            builder.HasOne(fp => fp.Product)
                   .WithMany(p => p.FavoriteProducts)
                   .HasForeignKey(fp => fp.ProductId);
        }
    }
}
