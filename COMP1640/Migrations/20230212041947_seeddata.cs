using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "101", "f2347172-1049-4fab-9131-9c430b2f08a1", "Admin", "ADMIN" },
                    { "102", "dcccbdd8-4aa8-41a2-bb21-76e5927afe54", "Coordinator", "COORDINATOR" },
                    { "103", "d8260298-4b9a-49a9-b7fe-65015d330b30", "Manager", "MANAGER" },
                    { "104", "6b3f1c97-c749-4308-9083-6847389d4d38", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "201", 0, null, "2ee92e37-ea41-457b-8750-1611842277fd", "Admin201@gmail.com", false, "Ngoc Huy", "Bui", false, null, "ADMIN201@GMAIL.COM", "ADMIN201@GMAIL.COM", "AQAAAAEAACcQAAAAEARVICKZVHJy7fm2d/v7U5tQkK0eZV9/7acxtAiIU/XNINQurfPmR1GkjYqo6k/yyQ==", null, false, "bc67b20d-82cb-469d-906c-b4619c30b223", false, "Admin201@gmail.com" },
                    { "202", 0, null, "6c210b15-7aab-4860-8a8a-fb690f74c5cf", "Manager202@gmail.com", false, "Thanh Binh", "Phan", false, null, "MANAGER202@GMAIL.COM", "MANAGER202@GMAIL.COM", "AQAAAAEAACcQAAAAECouEq4gyJ1Ks4Jc4ItZd5vI2qFU+n2KbcQzW/mLJiA3DB3qZIt8MXsdAOiP5dECvA==", null, false, "0b96bbbb-3e4a-4ed9-81c7-19bd363b8c73", false, "Manager202@gmail.com" },
                    { "203", 0, null, "9f608c6d-99f8-4ea2-a374-21e609bf0d15", "Staff203@gmail.com", false, "Nguyen Thanh", "Trung", false, null, "STAFF203@GMAIL.COM", "STAFF203@GMAIL.COM", "AQAAAAEAACcQAAAAEPQzZbNdHU5kO61u3wN1llmKDR62mSAXvuJd92ySuWzY1exxR49ezTdZ0doeNbd6pA==", null, false, "7064a3cc-1f8e-4e00-91c4-291f9db1a0d7", false, "Staff203@gmail.com" },
                    { "204", 0, null, "3fbb85fe-23ec-42c0-b578-42bbdf8652ee", "Coordinator204@gmail.com", false, "Anh", "Tuan", false, null, "COORDINATOR204@GMAIL.COM", "COORDINATOR204@GMAIL.COM", "AQAAAAEAACcQAAAAELq942ob+nO1X4Z1Nzj/IdUHYbweML0BCw13R+skCj6DK+XS9JkpjBUgc7cJTUZRPQ==", null, false, "b6f61a6b-f532-4611-9156-471da59c24ea", false, "Coordinator204@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "201", "101" },
                    { "201", "102" },
                    { "201", "103" },
                    { "201", "104" },
                    { "202", "102" },
                    { "202", "103" },
                    { "203", "104" },
                    { "204", "102" },
                    { "204", "103" },
                    { "204", "104" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "201", "101" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "201", "102" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "201", "103" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "201", "104" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "202", "102" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "202", "103" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "203", "104" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "204", "102" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "204", "103" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "204", "104" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204");
        }
    }
}
