using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nothing.Model.Entity;


namespace Nothing.Model.Configuation
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Language");
            builder.HasKey(x => x.ID_Language);
            builder.Property(x => x.Key_Language)
                .IsRequired()
                .HasColumnType("varchar(99)");
            builder.Property(x => x.Language_VN).IsRequired().HasColumnType("nvarchar(max)");
            builder.Property(x => x.Language_EN).IsRequired().HasColumnType("nvarchar(max)");
        }
    }
}
