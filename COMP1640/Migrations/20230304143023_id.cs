using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "170d569e-6339-4b8d-afef-76d531d001eb", "204", "Biological Sciences" },
                    { "a9361726-f0ac-48ba-baaf-712d1ad01019", "205", "Biostatistics" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "f0fe822a-ee88-471d-b845-ff6a3fbb09a4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "124c6b7b-7a36-4bf4-8c6a-2bd59ea3b3bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "02fcec22-a1e0-4176-a84b-fe4e056d04d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "c4602489-7139-446e-ba54-0170dd4390bf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06ab1c76-57ee-4855-ad7d-d2bc59136359", "AQAAAAEAACcQAAAAEGvTjex7Kg6qgrIrZoG0ryXdoZHbjpSsopM9OuQw9ZkRUyNbGYAtQipDbGqeBpz1dQ==", "fa87ef04-145f-435a-a629-45112c1ca212" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8560a156-e3f3-47e0-8ff4-840ed8de77d4", "AQAAAAEAACcQAAAAECb4pJ6LTU7yqCRfFeqtbQnBGcAu/VfxBZtXQjPTFnPUXypXdJ646IWFWPiNHHK5yg==", "5f4ba3b0-db7a-42c6-878a-9a91b8633d5d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3bc6b859-365c-4968-8bbe-72da38190aff", "aff95cee-1651-40e0-b5d8-40846e33f97e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5268db43-812f-4eb9-be69-21ddb3395c5e", "AQAAAAEAACcQAAAAEGUp6j+PC0MfTTu3uz74RIizKzudzDXGMFPIVqff6Tpq2dcNOaUgyGuS/Vs4eWV2hg==", "e898a0bd-4fed-4090-a53b-314ecf0b2d0d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcdd7f51-87e0-4b9b-865e-11d720c90f65", "AQAAAAEAACcQAAAAED5jvJH0e/wYPdioAEi6kKKS7pQtHS/BV0HMr+6irX4IXYEnQ2J4UYxCZPER9fPhQw==", "73f271e0-188e-4092-a6f6-3331d6dfabb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "170d569e-6339-4b8d-afef-76d531d001eb");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "a9361726-f0ac-48ba-baaf-712d1ad01019");

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c948ab1-3e7e-46ef-b68e-2cd008f7f126", "16d60277-2b00-41c0-aa68-2ae4f959958c" });

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
    }
}
