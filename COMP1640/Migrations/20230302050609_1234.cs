using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class _1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "4159ad3d-3a13-4169-a4aa-5ead58f1bdcb");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "af6f62b6-3b1b-404c-a449-5f432940ac9e");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[,]
                {
                    { "0090b4be-1875-44af-9db7-5a94c99770fe", "204", "Biological Sciences" },
                    { "998ae05e-6885-40fb-a944-f91bd3acd1e4", "205", "Biostatistics" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "666caa29-dbe3-44cb-badf-e871f458cad7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "03d0f214-59b4-4dbe-a1ca-99480a5835c3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "893e80c1-b949-4986-98db-f1a91b2001ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "7468ae14-b019-44fb-a6e6-1f63b35d9019");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a460386-014e-4b75-a404-ba3f7824e907", "AQAAAAEAACcQAAAAEKbUMusApcbZrYYlAlKmxNcAtrpueTCHmV1fo0cBvlWWS7nKVqCnTodEqOHauSjpQQ==", "a43a1392-c892-4724-97b9-8b8c443fff81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c818603e-3638-4785-af76-5551f2677d22", "AQAAAAEAACcQAAAAEMbjaVNtZMdZ7FhJh45XlmL6Dh5JyzguYTHpE+A4ABYRLgZYqPcSDaopqLDImygt4A==", "7750f47b-e355-4b82-8565-9fb95e2b2eba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c948ab1-3e7e-46ef-b68e-2cd008f7f126", "Default@123", "16d60277-2b00-41c0-aa68-2ae4f959958c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd71c6c-10c5-4323-8b4c-f6b3c79d98f3", "AQAAAAEAACcQAAAAEFCCAlRSSEIEYl8WnJg205mDE52epKdLywB9jDVfGtEtZVGNrpQP81TxaPTZZ81oYw==", "9ff73b7c-da17-45ee-be64-aa8f1880c1a1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c19eca0-2301-4dd3-9d2d-686fae8cca4d", "AQAAAAEAACcQAAAAENRG9U12qf6lPjnwaEYhhb9QHZ6pEVlRwt88U7RMV6NMfzIMpr1NAJ4AHpXeGdG1Yw==", "06e5ed35-f735-4de1-b1d2-33112f538412" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "0090b4be-1875-44af-9db7-5a94c99770fe");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "998ae05e-6885-40fb-a944-f91bd3acd1e4");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[,]
                {
                    { "af6f62b6-3b1b-404c-a449-5f432940ac9e", "204", "Biological Sciences" },
                    { "4159ad3d-3a13-4169-a4aa-5ead58f1bdcb", "205", "Biostatistics" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "7f2a0faf-fcd9-4e38-9076-a110c1d66664");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "87b1322a-2219-44d6-b2a3-1b49c991c905");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "a03a3184-0145-42cf-a2c2-0581c4ed54b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "386c7891-ac11-46be-9548-ead0caa2679d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e1b4d30-8ee9-4056-a64e-b18220e346c0", "AQAAAAEAACcQAAAAEKwHN1UCacbBUTHfswwZMG1I7zAjVv87s+YclkLknVSvN1y7vaM+WuPyep9cfNVmKg==", "ece8a27a-149f-411e-88fb-16f43fede30e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31502ae7-60f1-4470-bc14-a03a83b8b36f", "AQAAAAEAACcQAAAAECcJ0rK0aUS4s1GD3w5mnB7D9gfSuIWB8hmDbEdVaY7wrMMQXu7DY5llfROYbGa+ww==", "03219d5e-887b-4df2-bd67-a13e7fcb6c54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3e54b18-ebdb-407f-9b44-9e10719766de", "AQAAAAEAACcQAAAAEPVx3lhmSb2T95ZWHqKKx6Off0bg0bngyzW2iHOX275/M0fbsdhJk4H3g9HPOJBi5w==", "f05d7577-f02b-47a0-9e0f-1ce2f9026171" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30f0e306-747f-41c7-a3b3-70c78bc67ce1", "AQAAAAEAACcQAAAAEJkEtW07BEwee2vi7s8sAwKO28Pr/Gg+cKLZUlmkBt7nCTMnHQPCKn5JXLNegGa+pA==", "052a407f-50d0-4365-8cbb-6f6ffba3d2dc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42fff615-6333-4464-945e-bf5c4697eb0a", "AQAAAAEAACcQAAAAENsucUz/OkLjQrUqVDnGe2tdUhZPpE/I4aAjz60/NnmMuKNj1xXQ4Q+xdwwRgu773w==", "8f9c5a1e-1c58-4879-84fc-60e5ecaf42de" });
        }
    }
}
