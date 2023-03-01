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
                            ConcurrencyStamp = "f4d065c1-0940-4bb4-bab7-4d9547b53535",
                            Email = "Admin201@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ngoc Huy",
                            LastName = "Bui",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN201@GMAIL.COM",
                            NormalizedUserName = "ADMIN201@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJek0yGjhbWksIcAPGDa96+3LP8KLl/hmmVG0evjDN7SHakqzPfH02Lj5M+MruxdLQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b423e376-e8bc-4a2c-bfbe-062e43f2ada1",
                            TwoFactorEnabled = false,
                            UserName = "Admin201@gmail.com"
                        },
                        new
                        {
                            Id = "202",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cd954783-85a9-4d24-ac98-05ae2074eb75",
                            Email = "Coordinator205@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Thanh Binh",
                            LastName = "Phan",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR205@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR205@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEG25+187gJe0/gEHhQScPZJjL9UFSFPygAD/O8NZS9INDDAowztybDkkzaTDGlwDig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95394a06-ce3a-4b8e-b268-cc633a8641c3",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator202@gmail.com"
                        },
                        new
                        {
                            Id = "203",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3d14c01f-c245-454f-b7df-b4460d1d7d53",
                            Email = "Coordinator206@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Luan",
                            LastName = "Vo",
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR206@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR206@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFUvahwYKySDTDlai4d/tXujFN0CSWA95Pp/mSglogz5mpws2Y2kJvU2kO2lY4gjkA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8385d2b0-c59c-4a64-8ad3-9ed983fa265e",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator203@gmail.com"
                        },
                        new
                        {
                            Id = "204",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "136d43ec-9bc6-4306-83ad-3be6dfe9e581",
                            Email = "Manager203@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyen Thanh",
                            LastName = "Trung",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER203@GMAIL.COM",
                            NormalizedUserName = "MANAGER203@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAED9tUniqWuF/GE7o2nAiLWI24jpY6eS/Ju5yAO2kvPjVH2NpkT/8KHIVgIGf6PE0fg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e07de8e1-bbd2-4ad5-a0ad-b814c37abab3",
                            TwoFactorEnabled = false,
                            UserName = "Manager204@gmail.com"
                        },
                        new
                        {
                            Id = "205",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dc17bedc-2c98-4c21-867a-fc4fc559f27a",
                            Email = "Staff204@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Anh",
                            LastName = "Tuan",
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF204@GMAIL.COM",
                            NormalizedUserName = "STAFF204@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBsRwR3lmPTY6wGpz8WIk4CMykTHYvQDsl+7Huu5zzh747qiAhARdLCytUoJgLLpWQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "82acdf0a-1a27-4281-9442-1bf666f0f7ce",
                            TwoFactorEnabled = false,
                            UserName = "Staff205@gmail.com"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.CategoryModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ClosureDate")
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
                            Id = "0ba0be92-bc02-497f-87ae-359b2ce64815",
                            CordinatorId = "204",
                            Name = "Biological Sciences"
                        },
                        new
                        {
                            Id = "bd136159-3e66-4652-b482-8977eb774ec2",
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

                    b.Property<DateTime>("CategoryClosureDate")
                        .HasColumnType("datetime2");

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
                            ConcurrencyStamp = "2ba8f4ff-e9ac-4af2-84c1-686eb236e23b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "102",
                            ConcurrencyStamp = "9ea2ca8f-3f04-4369-a4c5-284a7c05d76e",
                            Name = "Coordinator",
                            NormalizedName = "COORDINATOR"
                        },
                        new
                        {
                            Id = "103",
                            ConcurrencyStamp = "ee3e7a8b-db41-420e-826b-07c6825eefb9",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "104",
                            ConcurrencyStamp = "58c3db16-84e1-4e9b-9e1c-c91c90d9dc99",
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
