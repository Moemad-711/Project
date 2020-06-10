using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class TestAddRole1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b23e4ac9-a92d-4202-98d3-2e343f1ce6b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperUser-123",
                column: "ConcurrencyStamp",
                value: "5318db0a-fa2f-4c5c-9da3-0321bb0f7305");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d52a1ae8-84ee-406f-b17c-bfc7eaec43d0", 0, "4b1ccbc3-7041-4a94-a03a-fd50b82ecb89", "moemad.admin@admin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEKAG88O+4WPbKyWJRMidnYWcc4VbFskXI/wB/VWEROa5+Ici6G+njHivG0BTZLt9Pw==", null, false, "6d5320ba-b52c-47d2-bcd7-9d39f6123dc7", false, "moemad.admin@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d52a1ae8-84ee-406f-b17c-bfc7eaec43d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperUser-123",
                column: "ConcurrencyStamp",
                value: "65bfa191-cb7c-4727-94b4-e3b3d0671141");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b23e4ac9-a92d-4202-98d3-2e343f1ce6b8", 0, "acd0b1ac-4cbe-4909-877d-e57381088a46", "moemad.admin@admin.com", false, false, null, null, null, null, null, false, "c4483d9d-f7a6-4496-a1ef-59e5dffc285c", false, "moemad.admin@admin.com" });
        }
    }
}
