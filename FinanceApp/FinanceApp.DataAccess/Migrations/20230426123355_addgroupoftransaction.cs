using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addgroupoftransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupOfTransactionId",
                table: "Money",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GroupOfTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOfTransaction", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Money_GroupOfTransactionId",
                table: "Money",
                column: "GroupOfTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money",
                column: "GroupOfTransactionId",
                principalTable: "GroupOfTransaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money");

            migrationBuilder.DropTable(
                name: "GroupOfTransaction");

            migrationBuilder.DropIndex(
                name: "IX_Money_GroupOfTransactionId",
                table: "Money");

            migrationBuilder.DropColumn(
                name: "GroupOfTransactionId",
                table: "Money");
        }
    }
}
