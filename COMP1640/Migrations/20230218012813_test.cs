using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentModel_Users_CordinatorId",
                table: "DepartmentModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentModel",
                table: "DepartmentModel");

            migrationBuilder.DeleteData(
                table: "DepartmentModel",
                keyColumn: "Id",
                keyValue: "22741e69-75f1-47b3-bf71-40eb0cf44dfc");

            migrationBuilder.DeleteData(
                table: "DepartmentModel",
                keyColumn: "Id",
                keyValue: "28993515-2b25-4d98-a1c0-2d30328436a6");

            migrationBuilder.RenameTable(
                name: "DepartmentModel",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentModel_CordinatorId",
                table: "Department",
                newName: "IX_Department_CordinatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[,]
                {
                    { "93e8a37b-c593-4dfd-8295-7ad7ca3d5f35", "204", "Biological Sciences" },
                    { "cb868a0f-0aa3-4842-97aa-c9c74a5cb349", "205", "Biostatistics" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "101",
                column: "ConcurrencyStamp",
                value: "ce82ad6e-de3c-4e8f-be97-8a3c1fd868be");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "102",
                column: "ConcurrencyStamp",
                value: "3ebc2ac9-80b5-4baf-bb49-3cc8552c9bb0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "103",
                column: "ConcurrencyStamp",
                value: "faf75341-44ac-47a3-965e-396956ce2ab2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "104",
                column: "ConcurrencyStamp",
                value: "0dd4e576-c636-41c3-9eaf-97bfd1d8e4a6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "201",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bceddd85-cab1-42e2-ae88-ef6b2577fd83", "AQAAAAEAACcQAAAAECdQGustWF9N5kdwJap5mcxLlCGJChBDQxdYW4hLJUVNuprTOwgBb8SMblgE44r63w==", "4bedd29c-5542-4d5e-9821-148b14482c5d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "202",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccfdb506-cdfb-4a9f-8e52-8b78dd090558", "AQAAAAEAACcQAAAAEMBEFsISWA6R/ACAZhPdOn0oItML3XiWbAJHCWF16/2sHYtS9LEeK7Mi2x5B2LHUYA==", "ce900ac0-a70b-417b-86b2-813a38718bb4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "203",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da241e9b-15f9-43ff-a8b9-6be211f43479", "AQAAAAEAACcQAAAAEK/CF1NwEid+WuMfXGk+mVDxxrbVIeEE8VSYWEe/fPg82ObQybpH5AYVg2El9nSQbg==", "92fa403f-8930-4a42-8e5c-1d97a3296d3b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d522b28-b723-47a5-afd7-e8b53549a8c1", "AQAAAAEAACcQAAAAEGJ4FyBg2+xiutsjIBHCx9XLcWavknV86Q9W+d10e9xRzOB8L8bBbJVub8WT2ZH5zQ==", "53128d0e-8952-4c4b-9925-72436f9240d1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a608efbc-2f99-448a-9fa3-cf6b4f7c9304", "AQAAAAEAACcQAAAAECBxWucPWmG+vLOx/BNySVx7vrQDb8f3kbJej2WPM070ZXtbhlvr+upe8/fJpsbXaA==", "ae18f5eb-38a4-4dde-950b-38bd7c5e9aae" });

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Users_CordinatorId",
                table: "Department",
                column: "CordinatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Users_CordinatorId",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "93e8a37b-c593-4dfd-8295-7ad7ca3d5f35");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: "cb868a0f-0aa3-4842-97aa-c9c74a5cb349");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "DepartmentModel");

            migrationBuilder.RenameIndex(
                name: "IX_Department_CordinatorId",
                table: "DepartmentModel",
                newName: "IX_DepartmentModel_CordinatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentModel",
                table: "DepartmentModel",
                column: "Id");

            migrationBuilder.InsertData(
                table: "DepartmentModel",
                columns: new[] { "Id", "CordinatorId", "Name" },
                values: new object[,]
                {
                    { "28993515-2b25-4d98-a1c0-2d30328436a6", "204", "Biological Sciences" },
                    { "22741e69-75f1-47b3-bf71-40eb0cf44dfc", "205", "Biostatistics" }
                });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "205",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e5235df-9b5c-48b4-94e7-0d36c717f04a", "AQAAAAEAACcQAAAAEAODjOXHEf8MhnN5QlgYyGeNRiorOb4jvgyCHvZNPgkCfRxUgAJEyoC+aSj3jH4bsA==", "c327f8c9-408c-44ed-8c2d-f2c09f7cec3f" });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentModel_Users_CordinatorId",
                table: "DepartmentModel",
                column: "CordinatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
