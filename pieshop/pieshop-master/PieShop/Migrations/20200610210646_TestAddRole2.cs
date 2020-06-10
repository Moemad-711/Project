using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class TestAddRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "cb74fa5f-729f-4da4-a6ca-087d83e94ec0");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "628f6279-0f5c-4b62-8c45-00d3137ea096", 0, "f7ed79fa-c102-4b43-851c-911200edf903", "moemad.admin@admin.com", false, false, null, "MOEMAD.ADMIN@ADMIN.COM", "MOEMAD.ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBz3OCBCdOyM9AR6+n8UIJLBCBjpmNoKF5WQ1o2CwmJ6DKEsS/WYQzJP5mN5OdTM9g==", null, false, "0bd96150-5495-42c6-84a6-a9e0003e743f", false, "moemad.admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "628f6279-0f5c-4b62-8c45-00d3137ea096", "SuperUser-123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "628f6279-0f5c-4b62-8c45-00d3137ea096", "SuperUser-123" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "628f6279-0f5c-4b62-8c45-00d3137ea096");

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
    }
}
