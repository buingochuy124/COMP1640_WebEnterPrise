﻿// <auto-generated />
using System;
using COMP1640.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP1640.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230301092552_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "8b8c0985-f21b-4e58-a826-2dc61646288e",
                            Email = "Admin201@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ngoc Huy",
                            LastName = "Bui",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN201@GMAIL.COM",
                            NormalizedUserName = "ADMIN201@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENzYq6i1OGIxJl30OwOERIQBsrIGoDlFdkdJsmuLVVdynsHzM/a08KG1taMnCzX6Xg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a622f9be-b009-451d-90c9-ed01b47f76ca",
                            TwoFactorEnabled = false,
                            UserName = "Admin201@gmail.com"
                        },
                        new
                        {
                            Id = "202",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d201226a-e227-404c-a26b-d0aae622b623",
                            Email = "Coordinator205@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Thanh Binh",
                            LastName = "Phan",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR205@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR205@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHnT8as3sdaGlFuHctuNTZMvNtox4dx2aD7yQNMx3Z1bCw9ri9TND865vrxWLf8cWw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "daf30207-e043-493b-bde9-2f5784b168ee",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator202@gmail.com"
                        },
                        new
                        {
                            Id = "203",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "760cc6ac-d847-406f-a258-9e8e18f54705",
                            Email = "Coordinator206@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Luan",
                            LastName = "Vo",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR206@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR206@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELvgK/J3h2ha01avJTVFRLsG/Bv35v8yEHbrXb43eAlkJR8Ss9m7FNbNRCTaLIVeSw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d3168551-975a-4ced-be31-ba845b8e6592",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator203@gmail.com"
                        },
                        new
                        {
                            Id = "204",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "71312621-319b-474e-87e0-c57f80b00325",
                            Email = "Manager203@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyen Thanh",
                            LastName = "Trung",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER203@GMAIL.COM",
                            NormalizedUserName = "MANAGER203@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENPLDUEUaBsjveJslm+E3PkDjt5egqashfIBdUtv2KwSiUecdv1CpoIMqx8K0SIILQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bdb1deb8-a830-4deb-a019-93f606755dcb",
                            TwoFactorEnabled = false,
                            UserName = "Manager204@gmail.com"
                        },
                        new
                        {
                            Id = "205",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9a171c89-1383-4a72-bdd1-4621be715236",
                            Email = "Staff204@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anh",
                            LastName = "Tuan",
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF204@GMAIL.COM",
                            NormalizedUserName = "STAFF204@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEF1tWg7K3VkkqscrNGZd6gk5yqo3TUTMDoPfqJ6gZdHpBWQGcSqB+cDqLPyEDBFk7g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a5acb3e6-f8b1-4413-b6ec-1697fc3a3b2a",
                            TwoFactorEnabled = false,
                            UserName = "Staff205@gmail.com"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.CategoryModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FinalClosureDate")
                        .HasColumnType("datetime2");

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
                            Id = "5e7d5279-5f45-4f54-aa72-7edb471067fc",
                            CordinatorId = "204",
                            Name = "Biological Sciences"
                        },
                        new
                        {
                            Id = "34649af1-9d11-44c4-ba89-91aab0d5c216",
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

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAnonymous")
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
                            ConcurrencyStamp = "0f58c3ed-a427-4888-a4ac-b539d70e7a28",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "102",
                            ConcurrencyStamp = "7060ddf5-6fa5-4b9b-91ef-5b2700a50d3c",
                            Name = "Coordinator",
                            NormalizedName = "COORDINATOR"
                        },
                        new
                        {
                            Id = "103",
                            ConcurrencyStamp = "c83e1ef2-b7aa-4c7f-afef-8d38ccbf470d",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "104",
                            ConcurrencyStamp = "a0a0e3ad-858d-4b89-a5d2-2a7de2ff8b6d",
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
                            UserId = "202",
                            RoleId = "104"
                        },
                        new
                        {
                            UserId = "203",
                            RoleId = "102"
                        },
                        new
                        {
                            UserId = "203",
                            RoleId = "103"
                        },
                        new
                        {
                            UserId = "203",
                            RoleId = "104"
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
                            UserId = "205",
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
                        .WithMany("PostComments")
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
