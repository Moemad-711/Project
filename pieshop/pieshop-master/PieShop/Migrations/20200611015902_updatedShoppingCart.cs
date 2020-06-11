using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class updatedShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "ShoppingCarts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_userId",
                table: "ShoppingCarts",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_userId",
                table: "ShoppingCarts",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_userId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_userId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "ShoppingCarts");
        }
    }
}
