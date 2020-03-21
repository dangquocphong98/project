using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nothing.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Model.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id_User);
            builder.Property(x => x.UserName)
                .IsRequired()
                .HasColumnType("varchar(99)");
            builder.Property(x => x.PassWord)
              .IsRequired()
              .HasColumnType("varchar(99)");

        }
    }
}
