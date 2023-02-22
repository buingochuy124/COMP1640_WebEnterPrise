using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "2defbe43-0f27-4142-8d87-4cc2d7807452");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "cabeaf07-fec5-4733-bf39-84bfc377ff97");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PostComments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[,]
                {
                    { "ceaa33f0-bf3a-415d-8055-2190d0a0a9ca", "204", "Biological Sciences" },
                    { "b07d042c-c7c7-4bfc-b9fe-fbe3882530d0", "205", "Biostatistics" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "be27e28a-2ff5-48b7-93b5-2db800f799c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "c8407c86-ab69-4e7a-a8a7-fef2acfd8aaf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "80229a3d-6be5-4f58-a19d-601b6d4e6d2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "f817ff81-00c7-4068-b7a3-8d4a01044696");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a66f9d9d-7980-4573-a4e1-91ec3985d56b", "AQAAAAEAACcQAAAAEGDss8iU4MbDzcD+f39NDfEqsR8W7AYxjCqSdZu/Y6z/+64FbkONEkBWIS//dCe6Hg==", "389da5ab-5754-47b4-afc4-1a334b4d5315" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47c8843-2928-419a-b265-abf683077bc7", "AQAAAAEAACcQAAAAEB2w43SRPDwIU2UiS4SWrI6cy+dw7FtNv3dlo6ULz5njodCC1aIZXmUprJaMnQUkjA==", "dd968a34-7f91-421d-906c-77b22e5f80ac" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6daf9535-304a-4e9a-923f-d0d2876be48c", "AQAAAAEAACcQAAAAEPZjA7gkmaSiHQl2mBfOXOE1U8CbGySNBzqy8bY1hbC5IvvwrOaDzmfGeMRyrPZ3Ew==", "4ba5d808-3eb7-4e8c-bc01-3a66287bdad0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa887e7-70c8-4c04-a695-84233311fe58", "AQAAAAEAACcQAAAAEB99qoT7iCdUykM24iJzdDB/faLF4eEwPk0M7BzEEpMR3TTQekDMDzjnL69WGbvkig==", "40f747fd-49e9-4379-af0b-cb45190c79ff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d18e397-b5cd-42c5-9d13-580621f2c2fa", "AQAAAAEAACcQAAAAEALSWwWsYdybFNgJbWjgCOHe/ExM8RQpv4nkyvmnStkIlYZAuXgeCfGFdG+yulDO1Q==", "61c99594-45a5-42a9-9f9d-99b4bb34e27e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "b07d042c-c7c7-4bfc-b9fe-fbe3882530d0");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "ceaa33f0-bf3a-415d-8055-2190d0a0a9ca");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PostComments");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[,]
                {
                    { "2defbe43-0f27-4142-8d87-4cc2d7807452", "204", "Biological Sciences" },
                    { "cabeaf07-fec5-4733-bf39-84bfc377ff97", "205", "Biostatistics" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "e4bdac1a-6d52-456f-b293-a03c21bfca5a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "21043f57-062e-4309-861c-afa7b60d5539");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "917fdd8b-5899-457f-b155-177107563fdd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "9ea988f2-5066-4d57-97c8-e0d64162f6c2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "161256d1-6052-438c-bcde-8865d47ea3ee", "AQAAAAEAACcQAAAAEAU517WG4NW2FYvyMLzSsAkt11tO2pmlRCvZwbLvjy64kUs+nLTmJ2fR5cSK4tKBUw==", "d6cfe634-d7a9-40de-95e7-b92dc26297ce" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb058e4-c468-46de-b6bf-9aba8fa0a56c", "AQAAAAEAACcQAAAAEAXRqBGZfcbbkw5wCgLxmBV7F3Rgmw0CyOQ3ASS1ky9HUFtcRxebUffUgYekmEihrw==", "ea2ac4f8-da63-458d-b816-aecc028a0dbc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d70c6e-481a-4554-88a9-6760f22da943", "AQAAAAEAACcQAAAAEC2QYb8m3yU8VXEb3lLSqGB4Llheb1aKO5GaP1rR4VK9RaNReI3Svz2R6ZKwInQ1eQ==", "d3c85f67-15b3-4521-9c81-5de242bbea69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c66483a2-8cbd-438d-a091-1dc1eebd1d0f", "AQAAAAEAACcQAAAAEOTh2OU/9EuDhPwLqjraFCC3EAj/+ROfHLRTSw1tbIrC/8DK2HclPwdzsdmHkN8vng==", "7ac35c0b-9d45-4c7a-9804-eda0799c442d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcbda334-e044-4ea8-aa90-1c5e47d7ea7d", "AQAAAAEAACcQAAAAEOhUewCaR7M7P1O3ebTsbSr6xkogMWueTPha8YXePDM2Fpl6Or3yItlgefPaDFf1Ug==", "0fb0fb57-e963-4ed8-b89f-c67e49c95b45" });
        }
    }
}
