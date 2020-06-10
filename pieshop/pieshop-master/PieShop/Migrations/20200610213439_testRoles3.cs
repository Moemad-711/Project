using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class testRoles3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "474f3fda-2778-4fbc-bcdd-0e4bd655aad8", "a6d479ab-1f0b-47e3-85a4-55b746079764" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6d479ab-1f0b-47e3-85a4-55b746079764");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "474f3fda-2778-4fbc-bcdd-0e4bd655aad8");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "a6d479ab-1f0b-47e3-85a4-55b746079764", "7c7ae802-25da-4340-9310-c31a91ceae7e", "SuperUser", "SUPERUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "474f3fda-2778-4fbc-bcdd-0e4bd655aad8", 0, "89820287-7a41-401e-b992-1be51147cd87", "moemad.admin@admin.com", false, false, null, "MOEMAD.ADMIN@ADMIN.COM", "MOEMAD.ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHw88776v5VfcnSvWCiSsQPAwCaLjSA46qky9lNcnh75cYdCp+Cs3RgW1YwyQHHTaw==", null, false, "7894854e-6bd4-408d-8353-657287cacb47", false, "moemad.admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "474f3fda-2778-4fbc-bcdd-0e4bd655aad8", "a6d479ab-1f0b-47e3-85a4-55b746079764" });
        }
    }
}
