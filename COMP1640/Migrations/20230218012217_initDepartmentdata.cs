using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class initDepartmentdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CordinatorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentModel_Users_CordinatorId",
                        column: x => x.CordinatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DepartmentModel",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[] { "28993515-2b25-4d98-a1c0-2d30328436a6", "204", "Biological Sciences" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "b6186ecb-19da-4a90-a3be-23afc2c5be4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "70dc5e2a-9ea7-4978-b33c-b5981729a00f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "815b2dc1-855f-4645-8459-5efacf10efc2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "11aedc58-7ff2-438c-ab29-6754a0a2548a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8842d053-6556-478a-9585-568c66349b35", "AQAAAAEAACcQAAAAEKp+q/Icuv67wfR2lVCuPzhmtqpu12gX9r01HnHyd+iZcbgmQCp1H+NEPrtmukPQcQ==", "bcace10d-00e0-421d-96f1-bfadf9862934" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b7fad2d-c5c0-4d26-a773-ad09df658f25", "AQAAAAEAACcQAAAAECNxYQIs1/tGqU32hMMbz3H/brpRdLu9qi6MavsPXh/l/6zin96z4K5aEij19sbblw==", "466a14bf-ab39-4ff4-ae21-a4de6205fcdb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7d8a5e7-78c7-4f1d-99a7-9e7445c3ec30", "AQAAAAEAACcQAAAAEO7WfTbOco0fiWYUn4i/ejmKA9NOw96QKl8BB5g8T/jqTlyKvHw+pcl5F/FZlYSdTQ==", "d0b45427-229e-46ba-98b6-9def314e503b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1ca99a2-6795-4f6d-980e-134768c10f99", "AQAAAAEAACcQAAAAEHIvp18auYHyrOFyLfOJMh4WGlk4c6QRb3T8rBPeS2AbnXLG5j8/nX/SVtlorgswDA==", "6f7845bd-bc63-4882-af6f-56aeeb3aa339" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "205", 0, null, "9e5235df-9b5c-48b4-94e7-0d36c717f04a", "Coordinator205@gmail.com", true, "Luan", "Vo", false, null, "COORDINATOR205@GMAIL.COM", "COORDINATOR205@GMAIL.COM", "AQAAAAEAACcQAAAAEAODjOXHEf8MhnN5QlgYyGeNRiorOb4jvgyCHvZNPgkCfRxUgAJEyoC+aSj3jH4bsA==", null, false, "c327f8c9-408c-44ed-8c2d-f2c09f7cec3f", false, "Coordinator205@gmail.com" });

            migrationBuilder.InsertData(
                table: "DepartmentModel",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[] { "22741e69-75f1-47b3-bf71-40eb0cf44dfc", "205", "Biostatistics" });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentModel_CordinatorId",
                table: "DepartmentModel",
                column: "CordinatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentModel");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b78404ee-929f-4911-ae49-eafd1c2f61bb", "AQAAAAEAACcQAAAAEAdzMvXU5U9Wch1FHlmySIAno42Ygisk28PHmJc35lefK8vLtiT6WoNmrRxiobxzQQ==", "fb32044e-3556-493a-9516-228d6b8c7389" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "006c56ad-d514-435a-9a5d-bd60873c6a87", "AQAAAAEAACcQAAAAEEsXmm3Djon+CDbT4zw+Se4w5w5X1cTfprWplzRofd6OOvWY0M7A7bBXs+Max+X/yw==", "4ad9b9de-7901-4498-87c1-61d48e985d46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4765cbaa-b438-4748-88b2-3bb1af12abee", "AQAAAAEAACcQAAAAECDbLjGtQ0QT3nB4YUnPaLuASe28yqcju5xRm0tH+0TH+RAJqqZyxW0Y6Bv6z7iNTQ==", "f7ffe064-264d-4acc-a47e-feb279ad075e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c057b949-e682-4cf3-bebb-0ed7383e5f51", "AQAAAAEAACcQAAAAEK93LlDJl3yckI1KCMfMk6/3kQP8Ii8MBptg3iRGLYTsaCMGkqpyuu6qrYrhwrfGwA==", "c23f71de-44ae-4c10-abd3-c4bfe34694b5" });
        }
    }
}
