using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdateEntityGroupOfTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money");

            migrationBuilder.DropIndex(
                name: "IX_Money_GroupOfTransactionId",
                table: "Money");

            migrationBuilder.DropColumn(
                name: "GroupOfTransactionId",
                table: "Money");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupOfTransactionId",
                table: "Money",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Money_GroupOfTransactionId",
                table: "Money",
                column: "GroupOfTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money",
                column: "GroupOfTransactionId",
                principalTable: "GroupOfTransaction",
                principalColumn: "Id");
        }
    }
}
