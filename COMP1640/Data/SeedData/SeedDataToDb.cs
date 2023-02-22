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
            SeedDepartment(builder);
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
                    UserName = "Coordinator202@gmail.com",
                    NormalizedUserName = "Coordinator205@gmail.com".ToUpper(),
                    Email = "Coordinator205@gmail.com",
                    NormalizedEmail = "Coordinator205@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Thanh Binh",
                    LastName = "Phan",
                    EmailConfirmed = true,

                },
                 new AppUserModel()
                 {
                     Id = "203",
                     UserName = "Coordinator203@gmail.com",
                     NormalizedUserName = "Coordinator206@gmail.com".ToUpper(),
                     Email = "Coordinator206@gmail.com",
                     NormalizedEmail = "Coordinator206@gmail.com".ToUpper(),
                     PasswordHash = hasher.HashPassword(null, "Default@123"),
                     SecurityStamp = Guid.NewGuid().ToString("D"),
                     FirstName = "Luan",
                     LastName = "Vo",
                     EmailConfirmed = true,

                 },
                new AppUserModel()
                {
                    Id = "204",
                    UserName = "Manager204@gmail.com",
                    NormalizedUserName = "Manager203@gmail.com".ToUpper(),
                    Email = "Manager203@gmail.com",
                    NormalizedEmail = "Manager203@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Nguyen Thanh",
                    LastName = "Trung",
                    EmailConfirmed = true,

                },
                new AppUserModel()
                {
                    Id = "205",
                    UserName = "Staff205@gmail.com",
                    NormalizedUserName = "Staff204@gmail.com".ToUpper(),
                    Email = "Staff204@gmail.com",
                    NormalizedEmail = "Staff204@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Anh",
                    LastName = "Tuan",
                    EmailConfirmed = true,

                });
          
        }
        public static void SeedDepartment(ModelBuilder builder)
        {
            builder.Entity<DepartmentModel>().HasData(
                new DepartmentModel
                {
                    Id = Guid.NewGuid().ToString("D"),
                    Name = "Biological Sciences",
                    CordinatorId = "204"
                },
                new DepartmentModel
                {
                    Id = Guid.NewGuid().ToString("D"),
                    Name = "Biostatistics",
                    CordinatorId = "205"
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
                  UserId = "202",
                  RoleId = "102"

              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "202",
                  RoleId = "103"

              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "202",
                  RoleId = "104"
       
              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "203",
                  RoleId = "102"

              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "203",
                  RoleId = "103"

              },
              new IdentityUserRole<string>
              {
                  // Phan Thanh Binh
                  UserId = "203",
                  RoleId = "104"

              },
              new IdentityUserRole<string>
              {
                  // Nguyen Thanh Trung
                  UserId = "204",
                  RoleId = "103"

              },
              new IdentityUserRole<string>
              {
                  // Nguyen Thanh Trung
                  UserId = "204",
                  RoleId = "104"
           
              },
              new IdentityUserRole<string>
              {
                  // Tuan Anh
                  UserId = "205",
                  RoleId = "104"
              });

        }
    }
}
