using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nothing.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Model.Configuration
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable("Profile");
            builder.HasKey(x => x.Id_Profile);
            builder.Property(x => x.Displayname)
                .IsRequired()
                .HasColumnType("nvarchar(99)");
            builder.Property(x => x.DoctorComment)
               .IsRequired()
               .HasColumnType("nvarchar(max)");
            builder.Property(x => x.Pathological)
               .IsRequired()
               .HasColumnType("nvarchar(999)");
        }
    }
}
