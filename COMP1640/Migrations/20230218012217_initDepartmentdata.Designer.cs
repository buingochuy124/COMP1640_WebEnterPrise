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
    [Migration("20230218012217_initDepartmentdata")]
    partial class initDepartmentdata
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
                            ConcurrencyStamp = "8842d053-6556-478a-9585-568c66349b35",
                            Email = "Admin201@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ngoc Huy",
                            LastName = "Bui",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN201@GMAIL.COM",
                            NormalizedUserName = "ADMIN201@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKp+q/Icuv67wfR2lVCuPzhmtqpu12gX9r01HnHyd+iZcbgmQCp1H+NEPrtmukPQcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bcace10d-00e0-421d-96f1-bfadf9862934",
                            TwoFactorEnabled = false,
                            UserName = "Admin201@gmail.com"
                        },
                        new
                        {
                            Id = "202",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7b7fad2d-c5c0-4d26-a773-ad09df658f25",
                            Email = "Manager202@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Thanh Binh",
                            LastName = "Phan",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER202@GMAIL.COM",
                            NormalizedUserName = "MANAGER202@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECNxYQIs1/tGqU32hMMbz3H/brpRdLu9qi6MavsPXh/l/6zin96z4K5aEij19sbblw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "466a14bf-ab39-4ff4-ae21-a4de6205fcdb",
                            TwoFactorEnabled = false,
                            UserName = "Manager202@gmail.com"
                        },
                        new
                        {
                            Id = "203",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f7d8a5e7-78c7-4f1d-99a7-9e7445c3ec30",
                            Email = "Staff203@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyen Thanh",
                            LastName = "Trung",
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF203@GMAIL.COM",
                            NormalizedUserName = "STAFF203@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEO7WfTbOco0fiWYUn4i/ejmKA9NOw96QKl8BB5g8T/jqTlyKvHw+pcl5F/FZlYSdTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d0b45427-229e-46ba-98b6-9def314e503b",
                            TwoFactorEnabled = false,
                            UserName = "Staff203@gmail.com"
                        },
                        new
                        {
                            Id = "204",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b1ca99a2-6795-4f6d-980e-134768c10f99",
                            Email = "Coordinator204@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anh",
                            LastName = "Tuan",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR204@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR204@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHIvp18auYHyrOFyLfOJMh4WGlk4c6QRb3T8rBPeS2AbnXLG5j8/nX/SVtlorgswDA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f7845bd-bc63-4882-af6f-56aeeb3aa339",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator204@gmail.com"
                        },
                        new
                        {
                            Id = "205",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e5235df-9b5c-48b4-94e7-0d36c717f04a",
                            Email = "Coordinator205@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Luan",
                            LastName = "Vo",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR205@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR205@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAODjOXHEf8MhnN5QlgYyGeNRiorOb4jvgyCHvZNPgkCfRxUgAJEyoC+aSj3jH4bsA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c327f8c9-408c-44ed-8c2d-f2c09f7cec3f",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator205@gmail.com"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.CategoryModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("DepartmentModel");

                    b.HasData(
                        new
                        {
                            Id = "28993515-2b25-4d98-a1c0-2d30328436a6",
                            CordinatorId = "204",
                            Name = "Biological Sciences"
                        },
                        new
                        {
                            Id = "22741e69-75f1-47b3-bf71-40eb0cf44dfc",
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
                            ConcurrencyStamp = "b6186ecb-19da-4a90-a3be-23afc2c5be4a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "102",
                            ConcurrencyStamp = "70dc5e2a-9ea7-4978-b33c-b5981729a00f",
                            Name = "Coordinator",
                            NormalizedName = "COORDINATOR"
                        },
                        new
                        {
                            Id = "103",
                            ConcurrencyStamp = "815b2dc1-855f-4645-8459-5efacf10efc2",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "104",
                            ConcurrencyStamp = "11aedc58-7ff2-438c-ab29-6754a0a2548a",
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
