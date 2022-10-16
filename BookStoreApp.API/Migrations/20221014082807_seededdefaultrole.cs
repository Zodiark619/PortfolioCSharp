using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class seededdefaultrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59cbc1ba-3586-49f0-9eb5-f67dc977b8d0", "4a6c9f73-a93c-4dc5-8d98-064cac0f0b84", "Administrator", "ADMINISTRATOR" },
                    { "bc0301cd-074e-47b9-b82b-574dbfa22d47", "00db92cb-5f48-4f2a-bb69-f2d97ee88d13", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "871de0c6-8dbb-4e43-b4de-5c1a41c735bd", 0, "461b7f46-3974-46d9-8aa3-4ccb2b0e2a3f", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMINBOOKSTORE.COM", "ADMINBOOKSTORE.COM", "AQAAAAEAACcQAAAAEIMFG6mcC8kuJQX3DKfNjC4qgp38nbsEzd1qMD3AfMWQyXqN8+9Lw9Bsf5qph5khqQ==", null, false, "5f934753-f228-4110-88ca-34feaa97693f", false, "admin@bookstore.com" },
                    { "dd2bf4e1-2d7c-4011-985f-638bffc646dc", 0, "9db70d7d-9220-4f62-8d95-5843b642f842", "admin@bookstore.com", false, "System", "User", false, null, "ADMINBOOKSTORE.COM", "USERBOOKSTORE.COM", "AQAAAAEAACcQAAAAEHVfwnGcpFab7AYYcLaMxuc8/gU8IFhAZNNtcBl3dqBHni2z1NBVn1rR4qPItJIByQ==", null, false, "8edc7f48-a38a-426e-a398-b809ecefaf8d", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bc0301cd-074e-47b9-b82b-574dbfa22d47", "871de0c6-8dbb-4e43-b4de-5c1a41c735bd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "59cbc1ba-3586-49f0-9eb5-f67dc977b8d0", "dd2bf4e1-2d7c-4011-985f-638bffc646dc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc0301cd-074e-47b9-b82b-574dbfa22d47", "871de0c6-8dbb-4e43-b4de-5c1a41c735bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59cbc1ba-3586-49f0-9eb5-f67dc977b8d0", "dd2bf4e1-2d7c-4011-985f-638bffc646dc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59cbc1ba-3586-49f0-9eb5-f67dc977b8d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc0301cd-074e-47b9-b82b-574dbfa22d47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871de0c6-8dbb-4e43-b4de-5c1a41c735bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd2bf4e1-2d7c-4011-985f-638bffc646dc");
        }
    }
}
