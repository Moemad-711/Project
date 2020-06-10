using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class TestAddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "SuperUser-123", "65bfa191-cb7c-4727-94b4-e3b3d0671141", "SuperUser", "SUPERUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b23e4ac9-a92d-4202-98d3-2e343f1ce6b8", 0, "acd0b1ac-4cbe-4909-877d-e57381088a46", "moemad.admin@admin.com", false, false, null, null, null, null, null, false, "c4483d9d-f7a6-4496-a1ef-59e5dffc285c", false, "moemad.admin@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperUser-123");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b23e4ac9-a92d-4202-98d3-2e343f1ce6b8");
        }
    }
}
