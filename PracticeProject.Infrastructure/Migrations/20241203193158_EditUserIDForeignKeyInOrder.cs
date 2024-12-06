using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditUserIDForeignKeyInOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_User_ID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ID",
                table: "Orders",
                newName: "IX_Orders_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_User_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_User_UserID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                newName: "IX_Orders_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_User_ID",
                table: "Orders",
                column: "ID",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
