using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyFirstWebAPIExample.Entities
{
    public class MenuCategory
    {
        public long Id { get; set; }
        public string Category { get; set; }

        public string Categorydescription { get; set; }

    }
    public class MenuCategoryMapping : IEntityTypeConfiguration<MenuCategory>
    {
        public void Configure(EntityTypeBuilder<MenuCategory> builder)
        {
            builder.Property(k => k.Id).UseSqlServerIdentityColumn();


            builder.Property(k => k.Category).HasMaxLength(100).IsRequired(true);
            builder.Property(k => k.Categorydescription).HasMaxLength(200).IsRequired();
            builder.HasKey(k => k.Id);
            builder.ToTable("T_ELITE_CATEGORY");
        }
    }

}
