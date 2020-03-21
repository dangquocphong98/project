using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nothing.Model.Entity;

namespace Nothing.Model.Configuration
{
    public class MenuConfiguration : IEntityTypeConfiguration<MenuAdmin>
    {
        public void Configure(EntityTypeBuilder<MenuAdmin> builder)
        {
            builder.ToTable("Menu");
            builder.HasKey(x => x.Id_Menu);
            builder.Property(x => x.NameMenu)
                .IsRequired()
                .HasColumnType("nvarchar(99)");
        }
    }
}
