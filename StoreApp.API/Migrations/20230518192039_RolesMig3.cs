using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class RolesMig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "e0dcc82c-76be-49b3-aae0-25afe6db3a36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "9651a708-9b0a-45c3-a1e7-1a5390df3b09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "03c4f32e-0b3d-4d80-ad66-e1ec530580ab");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "ddc1ddb9-2495-40d6-b278-633bc6ca29c6" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21d5279a-c9d1-4444-a5e8-0c6a1f87a2ee", "AQAAAAEAACcQAAAAEDB1xSQDYxWUqkiO3AfOgVxUw+HCTLsEKcXwtXUAj77KUal2dQsvb6MWukmukYVpoA==", "cfc8be49-f793-424f-b89e-0ff8971487e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6708c064-891a-4c41-ad88-7ed1ec369ef9", "AQAAAAEAACcQAAAAEDPkXOX5i4ItMST1qTNlyKmJ2/nDpVqUoKBnXNl5VFuy3WisM2f9TitXoLxBwkSHUA==", "e5cce59d-5ee2-4a27-8d7b-310db078c934" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "ddc1ddb9-2495-40d6-b278-633bc6ca29c6" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "cbb371d0-4837-4eaa-9285-80bc88a904a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "0bf2810a-9bd8-4866-afce-499b3229a72e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "d5245216-dbbd-4447-85b0-62b73ab3100b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dcab904-614d-416f-91fe-cb1b2f47c03a", "AQAAAAEAACcQAAAAECEoLt5O3+N77X/cG0NOxssW9JohbWl+enLD/cii6mKQIeZvfKUvNNhJ8DD8UUA8vA==", "f66c0265-3d0f-4327-a2cb-2f6ad262da47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99cd9bfc-6e56-458a-aa0d-e0f70ed21aee", "AQAAAAEAACcQAAAAEJDxCd76WTaoB04bsEcntpzJl8RfOumITFQKS1Z36RZE6dXZC3PzGDR4a73ohL3Ngw==", "e8bb49b8-3f18-466d-85c3-c54e050c8747" });
        }
    }
}
