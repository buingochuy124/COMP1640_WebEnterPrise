﻿// <auto-generated />
using System;
using COMP1640.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP1640.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP1640.Models.AppUserModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "201",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c6ca2b31-c1ef-4fdb-a9e1-3447d56936d7",
                            Email = "Admin201@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ngoc Huy",
                            LastName = "Bui",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN201@GMAIL.COM",
                            NormalizedUserName = "ADMIN201@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFXvpn8QGKCqH3NUjfyv3HNrJWBStKiaxFLC4lo0BnbD1iod6q6/lPbs12krDHKOUQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e038f0eb-fed2-4152-89f2-a8ec664c59dc",
                            TwoFactorEnabled = false,
                            UserName = "Admin201@gmail.com"
                        },
                        new
                        {
                            Id = "202",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "34309096-84e6-47d3-8558-8f8a21274c4f",
                            Email = "Manager202@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Thanh Binh",
                            LastName = "Phan",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER202@GMAIL.COM",
                            NormalizedUserName = "MANAGER202@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECZcHE93YNTFvBDY/I1C7Fs8+p2fJim4czaNA0pW9P+btPyskWZy5UIqb4hqYS2bEg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "666944a6-ac0f-4746-acff-a1a147272782",
                            TwoFactorEnabled = false,
                            UserName = "Manager202@gmail.com"
                        },
                        new
                        {
                            Id = "203",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "092fea09-d166-4319-8344-ed2d5b51fa67",
                            Email = "Staff203@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyen Thanh",
                            LastName = "Trung",
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF203@GMAIL.COM",
                            NormalizedUserName = "STAFF203@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIMHx+/9RVA/Jm4pxrFIAYfoorWbZA55B+uIlX7dn/9ferRKooMM6Bvj8xGVL9Mg+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4e396f0b-99bd-4bb1-a511-d5a1f5ae7a55",
                            TwoFactorEnabled = false,
                            UserName = "Staff203@gmail.com"
                        },
                        new
                        {
                            Id = "204",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1154758c-7a9c-4efd-9588-e56fa06d61d9",
                            Email = "Coordinator204@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anh",
                            LastName = "Tuan",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR204@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR204@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKhUyYPVCOXoADpLXhrYxGrg8PfDDJNXEOE/dqMcYCAhIOZ+J/gDHCcR23tAZ2umxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "babf5e58-24f4-4ac3-a5a9-9fc39e7dd333",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator204@gmail.com"
                        },
                        new
                        {
                            Id = "205",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "73bbc996-a1e2-4670-864d-aa3a20d1d7dc",
                            Email = "Coordinator205@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Luan",
                            LastName = "Vo",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR205@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR205@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM1HMovU1zrx3vStWMM7DBNBtrdN1lwRaarOL5eX4UpQIBO84t/lqs4kX8+vOlZCFA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "607f54eb-62cf-41bd-ace3-ec228c9ab3e3",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator205@gmail.com"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.CategoryModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("COMP1640.Models.DepartmentModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CordinatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CordinatorId");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = "0dd7b706-e89f-4fae-be8a-e06452326c51",
                            CordinatorId = "204",
                            Name = "Biological Sciences"
                        },
                        new
                        {
                            Id = "31d19ecf-81f1-4e78-b01e-abf19efe4ac5",
                            CordinatorId = "205",
                            Name = "Biostatistics"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.PostCommentModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("bit");

                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("COMP1640.Models.PostInteractModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsAnonymous")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInteracted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLike")
                        .HasColumnType("bit");

                    b.Property<string>("PostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostInteracts");
                });

            modelBuilder.Entity("COMP1640.Models.PostModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("COMP1640.Models.RoleModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "101",
                            ConcurrencyStamp = "870d67c1-7545-4d2b-ab17-f430d9646ca5",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "102",
                            ConcurrencyStamp = "589daf7a-20d4-4421-9db1-baad01f75855",
                            Name = "Coordinator",
                            NormalizedName = "COORDINATOR"
                        },
                        new
                        {
                            Id = "103",
                            ConcurrencyStamp = "d370d96f-5488-4c6d-94af-68d626951de8",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "104",
                            ConcurrencyStamp = "3b5ad9c6-1927-4992-ac01-4084577bafbd",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "201",
                            RoleId = "101"
                        },
                        new
                        {
                            UserId = "201",
                            RoleId = "102"
                        },
                        new
                        {
                            UserId = "201",
                            RoleId = "103"
                        },
                        new
                        {
                            UserId = "201",
                            RoleId = "104"
                        },
                        new
                        {
                            UserId = "204",
                            RoleId = "102"
                        },
                        new
                        {
                            UserId = "204",
                            RoleId = "103"
                        },
                        new
                        {
                            UserId = "204",
                            RoleId = "104"
                        },
                        new
                        {
                            UserId = "202",
                            RoleId = "102"
                        },
                        new
                        {
                            UserId = "202",
                            RoleId = "103"
                        },
                        new
                        {
                            UserId = "203",
                            RoleId = "104"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("COMP1640.Models.DepartmentModel", b =>
                {
                    b.HasOne("COMP1640.Models.AppUserModel", "Cordinator")
                        .WithMany()
                        .HasForeignKey("CordinatorId");
                });

            modelBuilder.Entity("COMP1640.Models.PostCommentModel", b =>
                {
                    b.HasOne("COMP1640.Models.PostModel", "Post")
                        .WithMany()
                        .HasForeignKey("PostId");

                    b.HasOne("COMP1640.Models.AppUserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("COMP1640.Models.PostInteractModel", b =>
                {
                    b.HasOne("COMP1640.Models.PostModel", "Post")
                        .WithMany("PostInteracts")
                        .HasForeignKey("PostId");

                    b.HasOne("COMP1640.Models.AppUserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("COMP1640.Models.PostModel", b =>
                {
                    b.HasOne("COMP1640.Models.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("COMP1640.Models.AppUserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("COMP1640.Models.RoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("COMP1640.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("COMP1640.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("COMP1640.Models.RoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("COMP1640.Models.AppUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
