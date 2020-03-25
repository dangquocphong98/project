using Microsoft.EntityFrameworkCore;
using Nothing.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Model.Data
{
    public static class SeedExtendtion
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<string> ls = new List<string> { "7", "8", "11" };
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id_User = 1,
                    UserName = "Admin",
                    PassWord = "Admin",
                    Id_Role = 1,
                    LanguageCurrent = "EN",
                },
                 new User
                 {
                     Id_User = 2,
                     UserName = "Employee",
                     PassWord = "Employee",
                     Id_Role = 2
                 },
                  new User
                  {
                      Id_User = 3,
                      UserName = "User",
                      PassWord = "User",
                      Id_Role = 3
                  }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id_Role = 1, Role_Name = "Admin" },
                new Role { Id_Role = 2, Role_Name = "Employee" },
                new Role { Id_Role = 3, Role_Name = "User" }
            );

        }
    }
}
