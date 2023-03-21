using COMP1640.Data.SeedData;
using COMP1640.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP1640.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUserModel,RoleModel,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<AppUserModel> Users { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<PostInteractModel> PostInteracts{ get; set; }
        public DbSet<PostCommentModel> PostComments { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            //xoa chu asp trong dbo name neu can
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
            var keysProperties = builder.Model.GetEntityTypes()
                .Select(x => x.FindPrimaryKey())
                .SelectMany(x => x.Properties);
            foreach (var property in keysProperties)
            {
                property.ValueGenerated = ValueGenerated.OnAdd;
            }

            SeedDataToDb.Seed(builder);
        }
    }
}
