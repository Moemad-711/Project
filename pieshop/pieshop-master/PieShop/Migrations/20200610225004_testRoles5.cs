using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class testRoles5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "68e3822c-524c-4693-8100-5858a66adde7", "20866bff-487a-4f38-95bc-39e4dc76bede" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20866bff-487a-4f38-95bc-39e4dc76bede");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68e3822c-524c-4693-8100-5858a66adde7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20866bff-487a-4f38-95bc-39e4dc76bede", "5a3ab18e-2750-4f62-a93a-711a4847e948", "SuperUser", "SUPERUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68e3822c-524c-4693-8100-5858a66adde7", 0, "4e5669d6-c428-4c97-9de0-8ba54500b71e", "moemad.admin@admin.com", false, false, null, "MOEMAD.ADMIN@ADMIN.COM", "MOEMAD.ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENIpLZhj8t73hK7i7sjWNCQnIDsZeL0y6Wv5L2x8yk3B/x8RqWiWTUYNs5cyQsjitg==", null, false, "04f086c8-ba8d-491b-8975-01ad5ff6b469", false, "moemad.admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "68e3822c-524c-4693-8100-5858a66adde7", "20866bff-487a-4f38-95bc-39e4dc76bede" });
        }
    }
}
