using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class passwordMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "4f7f6aa3-1dc4-438f-8484-af7c40cdb67c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "701eb1f6-1aba-4966-a743-eca032de2705");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "5b89fe8a-40ad-4b15-84dd-23a6081e604c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31d5fc0b-6250-49df-afe3-3094caf05623", "AQAAAAEAACcQAAAAEDZT8rAgmPnN3PsIlOqVOBEU43RClY2BN1ndZav7LNJUDO5ruiyGoJfBGApB8EMJww==", "4ff43a65-f972-4603-8a7b-43f72f9ecbcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cf7b193-f7d8-4968-b32a-49050f0edfaa", "AQAAAAEAACcQAAAAEElxtj4gvcx3m2Pon6vrTemh0T7RkDR/MwLRzE9/bKvhXR6HQNySWZ6WUBFh3q9s5Q==", "4b268541-dfbd-4e99-b3c2-6f8e4ab964ca" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21d5279a-c9d1-4444-a5e8-0c6a1f87a2ee", "123!Qaz123", "AQAAAAEAACcQAAAAEDB1xSQDYxWUqkiO3AfOgVxUw+HCTLsEKcXwtXUAj77KUal2dQsvb6MWukmukYVpoA==", "cfc8be49-f793-424f-b89e-0ff8971487e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                columns: new[] { "ConcurrencyStamp", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6708c064-891a-4c41-ad88-7ed1ec369ef9", "123!Qaz123", "AQAAAAEAACcQAAAAEDPkXOX5i4ItMST1qTNlyKmJ2/nDpVqUoKBnXNl5VFuy3WisM2f9TitXoLxBwkSHUA==", "e5cce59d-5ee2-4a27-8d7b-310db078c934" });
        }
    }
}
