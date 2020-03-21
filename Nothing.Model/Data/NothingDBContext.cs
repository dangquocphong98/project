using Microsoft.EntityFrameworkCore;
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
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());

            //modelBuilder.Seed();
        }

        public DbSet<Language> languages { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<MenuAdmin> menus { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Profile> profiles { get; set; }

    }
}
