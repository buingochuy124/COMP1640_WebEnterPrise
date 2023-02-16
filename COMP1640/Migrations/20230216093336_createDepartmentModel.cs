using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class createDepartmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "7eec89c1-819a-41bf-a0ac-2bb734a8a553");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "39431739-fe8e-423d-bd77-5c2ad254e3bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "d8eecc13-77a0-4478-bf07-fad00ff9712a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "b8d5e3f4-c3c8-400f-9043-2c563ebc2799");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b78404ee-929f-4911-ae49-eafd1c2f61bb", true, "AQAAAAEAACcQAAAAEAdzMvXU5U9Wch1FHlmySIAno42Ygisk28PHmJc35lefK8vLtiT6WoNmrRxiobxzQQ==", "fb32044e-3556-493a-9516-228d6b8c7389" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "006c56ad-d514-435a-9a5d-bd60873c6a87", true, "AQAAAAEAACcQAAAAEEsXmm3Djon+CDbT4zw+Se4w5w5X1cTfprWplzRofd6OOvWY0M7A7bBXs+Max+X/yw==", "4ad9b9de-7901-4498-87c1-61d48e985d46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4765cbaa-b438-4748-88b2-3bb1af12abee", true, "AQAAAAEAACcQAAAAECDbLjGtQ0QT3nB4YUnPaLuASe28yqcju5xRm0tH+0TH+RAJqqZyxW0Y6Bv6z7iNTQ==", "f7ffe064-264d-4acc-a47e-feb279ad075e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c057b949-e682-4cf3-bebb-0ed7383e5f51", true, "AQAAAAEAACcQAAAAEK93LlDJl3yckI1KCMfMk6/3kQP8Ii8MBptg3iRGLYTsaCMGkqpyuu6qrYrhwrfGwA==", "c23f71de-44ae-4c10-abd3-c4bfe34694b5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "f2347172-1049-4fab-9131-9c430b2f08a1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "dcccbdd8-4aa8-41a2-bb21-76e5927afe54");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "d8260298-4b9a-49a9-b7fe-65015d330b30");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "6b3f1c97-c749-4308-9083-6847389d4d38");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ee92e37-ea41-457b-8750-1611842277fd", false, "AQAAAAEAACcQAAAAEARVICKZVHJy7fm2d/v7U5tQkK0eZV9/7acxtAiIU/XNINQurfPmR1GkjYqo6k/yyQ==", "bc67b20d-82cb-469d-906c-b4619c30b223" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c210b15-7aab-4860-8a8a-fb690f74c5cf", false, "AQAAAAEAACcQAAAAECouEq4gyJ1Ks4Jc4ItZd5vI2qFU+n2KbcQzW/mLJiA3DB3qZIt8MXsdAOiP5dECvA==", "0b96bbbb-3e4a-4ed9-81c7-19bd363b8c73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f608c6d-99f8-4ea2-a374-21e609bf0d15", false, "AQAAAAEAACcQAAAAEPQzZbNdHU5kO61u3wN1llmKDR62mSAXvuJd92ySuWzY1exxR49ezTdZ0doeNbd6pA==", "7064a3cc-1f8e-4e00-91c4-291f9db1a0d7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fbb85fe-23ec-42c0-b578-42bbdf8652ee", false, "AQAAAAEAACcQAAAAELq942ob+nO1X4Z1Nzj/IdUHYbweML0BCw13R+skCj6DK+XS9JkpjBUgc7cJTUZRPQ==", "b6f61a6b-f532-4611-9156-471da59c24ea" });
        }
    }
}
