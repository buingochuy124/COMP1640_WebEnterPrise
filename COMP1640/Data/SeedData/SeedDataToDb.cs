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
            PasswordHasher<AppUserModel> hasher = new PasswordHasher<AppUserModel>();

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
                    DepartmentId = "998"

                },
                new AppUserModel()
                {
                    Id = "202",
                    UserName = "pbinh.2501@gmail.com",
                    NormalizedUserName = "pbinh.2501@gmail.com".ToUpper(),
                    Email = "pbinh.2501@gmail.com",
                    NormalizedEmail = "pbinh.2501@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Thanh Binh",
                    LastName = "Phan",
                    EmailConfirmed = true,
                    DepartmentId = "999"

                },
                 new AppUserModel()
                 {
                     Id = "203",
                     UserName = "vothanhluan19102001@gmail.com",
                     NormalizedUserName = "vothanhluan19102001@gmail.com".ToUpper(),
                     Email = "vothanhluan19102001@gmail.com",
                     NormalizedEmail = "vothanhluan19102001@gmail.com".ToUpper(),
                     PasswordHash = hasher.HashPassword(null, "Default@123"),
                     SecurityStamp = Guid.NewGuid().ToString("D"),
                     FirstName = "Thanh Luan",
                     LastName = "Vo",
                     EmailConfirmed = true,
                     DepartmentId = "998"

                 },
                new AppUserModel()
                {
                    Id = "204",
                    UserName = "nttrung9cc@gmail.com",
                    NormalizedUserName = "nttrung9cc@gmail.com".ToUpper(),
                    Email = "nttrung9cc@gmail.com",
                    NormalizedEmail = "nttrung9cc@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Thanh Trung",
                    LastName = "Nguyen",
                    EmailConfirmed = true,
                    DepartmentId = "998"
                },
                new AppUserModel()
                {
                    Id = "205",
                    UserName = "tuanle273@gmail.com",
                    NormalizedUserName = "tuanle273@gmail.com".ToUpper(),
                    Email = "tuanle273@gmail.com",
                    NormalizedEmail = "tuanle273@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    FirstName = "Tuan Anh",
                    LastName = "Le",
                    EmailConfirmed = true,
                    DepartmentId= "999"
                });
          
        }
        public static void SeedDepartment(ModelBuilder builder)
        {
            builder.Entity<DepartmentModel>().HasData(
                new DepartmentModel
                {
                    Id = "999",
                    Name = "Biological Sciences",
                    CordinatorId = "202"
                },
                new DepartmentModel
                {
                    Id = "998",
                    Name = "Biostatistics",
                    CordinatorId = "203"
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
