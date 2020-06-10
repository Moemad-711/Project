using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class testRoles4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cb98711f-6511-49a2-8340-5a6197e57b8c", "c4ed20d3-f41e-492c-b57d-6c76ecfe4f98" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4ed20d3-f41e-492c-b57d-6c76ecfe4f98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb98711f-6511-49a2-8340-5a6197e57b8c");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4ed20d3-f41e-492c-b57d-6c76ecfe4f98", "6ece25c1-af4c-4935-8510-8924d41e48b9", "SuperUser", "SUPERUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cb98711f-6511-49a2-8340-5a6197e57b8c", 0, "43c3a8bf-d102-4ee5-ad99-72ed619b3767", "moemad.admin@admin.com", false, false, null, "MOEMAD.ADMIN@ADMIN.COM", "MOEMAD.ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOS3Flbl1Ahk8VfWYQxvJ2IwzDrLIAjWc9o+cJzEmmUhMGgtve0TDGIV48XCTV06Qg==", null, false, "3c1ee8a1-b29b-424a-91e8-d35f1af7a23c", false, "moemad.admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cb98711f-6511-49a2-8340-5a6197e57b8c", "c4ed20d3-f41e-492c-b57d-6c76ecfe4f98" });
        }
    }
}
