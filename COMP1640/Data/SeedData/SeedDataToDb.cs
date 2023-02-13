using COMP1640.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace COMP1640.Data.SeedData
{
    public class SeedDataToDb
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedRoles(builder);
            SeedUsers(builder);
            SeedUserRoles(builder);

        }
        public static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<RoleModel>().HasData(
                new RoleModel()
                {
                    Id = "101",
                    Name = Utils.Role.Admin,
                    NormalizedName = Utils.Role.Admin.ToUpper()
                },
                new RoleModel()
                {
                    Id = "102",
                    Name = Utils.Role.Coordinator,
                    NormalizedName = Utils.Role.Coordinator.ToUpper()
           
                },
                new RoleModel()
                {
                    Id = "103",
                    Name = Utils.Role.Manager,
                    NormalizedName = Utils.Role.Manager.ToUpper()
                },
                new RoleModel()
                {
                    Id = "104",
                    Name = Utils.Role.Staff,
                    NormalizedName = Utils.Role.Staff.ToUpper()
                });
        }
        public static void SeedUsers(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<AppUserModel>();

            builder.Entity<AppUserModel>().HasData(
                new AppUserModel()
                {
                    Id = "201",
                    UserName = "Admin201@gmail.com",
                    NormalizedUserName = "Admin201@gmail.com".ToUpper(),
                    Email = "Admin201@gmail.com",
                    NormalizedEmail = "Admin201@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Ngoc Huy",
                    LastName = "Bui",
                    EmailConfirmed = true,
                },
                new AppUserModel()
                {
                    Id = "202",
                    UserName = "Manager202@gmail.com",
                    NormalizedUserName = "Manager202@gmail.com".ToUpper(),
                    Email = "Manager202@gmail.com",
                    NormalizedEmail = "Manager202@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Thanh Binh",
                    LastName = "Phan",
                    EmailConfirmed = true,

                },
                new AppUserModel()
                {
                    Id = "203",
                    UserName = "Staff203@gmail.com",
                    NormalizedUserName = "Staff203@gmail.com".ToUpper(),
                    Email = "Staff203@gmail.com",
                    NormalizedEmail = "Staff203@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Nguyen Thanh",
                    LastName = "Trung",
                    EmailConfirmed = true,

                },
                new AppUserModel()
                {
                    Id = "204",
                    UserName = "Coordinator204@gmail.com",
                    NormalizedUserName = "Coordinator204@gmail.com".ToUpper(),
                    Email = "Coordinator204@gmail.com",
                    NormalizedEmail = "Coordinator204@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Anh",
                    LastName = "Tuan",
                    EmailConfirmed = true,

                });
        }
        public static void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
              new IdentityUserRole<string>
              {
                  // Bui Ngoc Huy
                  UserId = "201",
                  RoleId = "101"

              },
              new IdentityUserRole<string>
              {
                  // Bui Ngoc Huy
                  UserId = "201",
                  RoleId = "102"

              },
              new IdentityUserRole<string>
              {
                  // Bui Ngoc Huy
                  UserId = "201",
                  RoleId = "103"

              },
              new IdentityUserRole<string>
              {
                  // Bui Ngoc Huy
                  UserId = "201",
                  RoleId = "104"
        
              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "204",
                  RoleId = "102"

              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "204",
                  RoleId = "103"

              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "204",
                  RoleId = "104"
       
              },
              new IdentityUserRole<string>
              {
                  // Nguyen Thanh Trung
                  UserId = "202",
                  RoleId = "102"

              },
              new IdentityUserRole<string>
              {
                  // Nguyen Thanh Trung
                  UserId = "202",
                  RoleId = "103"
           
              },
              new IdentityUserRole<string>
              {
                  // Tuan Anh
                  UserId = "203",
                  RoleId = "104"

              });

        }
    }
}
