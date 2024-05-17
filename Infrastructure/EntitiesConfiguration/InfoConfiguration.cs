using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Information;

namespace Infrastructure.EntitiesConfiguration
{
    public class OptionsConfiguration : IEntityTypeConfiguration<Options>
    {
        public void Configure(EntityTypeBuilder<Options> builder)
        {
            builder.HasKey(c => c.Id);

            // Зв'язок між Options та Info
            builder
                .HasOne(o => o.Info)
                .WithMany(i => i.Options)
                .HasForeignKey(o => o.InfoId);
        }
    }
}
