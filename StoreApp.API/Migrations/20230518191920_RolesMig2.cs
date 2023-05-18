using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class RolesMig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "c6c23124-0ea5-4bed-a2a0-fc258081e9a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "5678eda4-a329-45f0-a48d-e62c63512942");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "16de53e1-9c4a-4afe-bf4b-307af5f4ce5b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4ede88-e535-4dfe-859e-acadad979d40", "AQAAAAEAACcQAAAAEO5VBLLu9gbo0gya3Gzk5Xdgw5ax3PCnNZ5atuhyIz3hqR4g29QXjh8bgWetaQNTDA==", "0b1e9e7f-bfa1-418c-bf9f-4c0497d9e080" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a12134c6-7551-4327-bed9-22a72311b420", "AQAAAAEAACcQAAAAEF5LubERfhkdhvZ0VUSBem+m5ceGfQJRtmkPdP1WVLvPVEkqy+UBAym2z1eZBm/0lQ==", "a99251ef-e5f7-4cae-804d-b9090f50e0df" });
        }
    }
}
