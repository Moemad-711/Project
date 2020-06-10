using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class TestAddRole3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "628f6279-0f5c-4b62-8c45-00d3137ea096", "SuperUser-123" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperUser-123");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "628f6279-0f5c-4b62-8c45-00d3137ea096");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "SuperUser-123", "cb74fa5f-729f-4da4-a6ca-087d83e94ec0", "SuperUser", "SUPERUSER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "628f6279-0f5c-4b62-8c45-00d3137ea096", 0, "f7ed79fa-c102-4b43-851c-911200edf903", "moemad.admin@admin.com", false, false, null, "MOEMAD.ADMIN@ADMIN.COM", "MOEMAD.ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBz3OCBCdOyM9AR6+n8UIJLBCBjpmNoKF5WQ1o2CwmJ6DKEsS/WYQzJP5mN5OdTM9g==", null, false, "0bd96150-5495-42c6-84a6-a9e0003e743f", false, "moemad.admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "628f6279-0f5c-4b62-8c45-00d3137ea096", "SuperUser-123" });
        }
    }
}
