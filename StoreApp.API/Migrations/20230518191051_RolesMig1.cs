using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class RolesMig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29", "c6c23124-0ea5-4bed-a2a0-fc258081e9a9", "Visitor", "VISITOR" },
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "5678eda4-a329-45f0-a48d-e62c63512942", "Admin", "ADMIN" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "16de53e1-9c4a-4afe-bf4b-307af5f4ce5b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthLevel", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, 2, "4a4ede88-e535-4dfe-859e-acadad979d40", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN", "123!Qaz123", "AQAAAAEAACcQAAAAEO5VBLLu9gbo0gya3Gzk5Xdgw5ax3PCnNZ5atuhyIz3hqR4g29QXjh8bgWetaQNTDA==", null, false, "0b1e9e7f-bfa1-418c-bf9f-4c0497d9e080", false, "Admin" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", 0, 1, "a12134c6-7551-4327-bed9-22a72311b420", "yoni@email.com", true, false, null, "YONI@EMAIL.COM", "YONI", "123!Qaz123", "AQAAAAEAACcQAAAAEF5LubERfhkdhvZ0VUSBem+m5ceGfQJRtmkPdP1WVLvPVEkqy+UBAym2z1eZBm/0lQ==", null, false, "a99251ef-e5f7-4cae-804d-b9090f50e0df", false, "Yoni" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6");
        }
    }
}
