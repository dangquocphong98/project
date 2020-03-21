﻿using Microsoft.EntityFrameworkCore;
using Nothing.Model.Configuation;
using Nothing.Model.Configuration;
using Nothing.Model.Entity;

namespace Nothing.Model.Data
{
    public class NothingDBContext : DbContext
    {
        public NothingDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            //modelBuilder.Seed();
        }

        public DbSet<Language> languages { get; set; }
        public DbSet<Role> roles { get; set; }

    }
}
