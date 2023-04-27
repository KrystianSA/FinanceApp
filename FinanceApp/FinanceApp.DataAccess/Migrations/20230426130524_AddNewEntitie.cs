using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntitie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoneySalary");

            migrationBuilder.AddColumn<int>(
                name: "MoneyId",
                table: "Bills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_MoneyId",
                table: "Bills",
                column: "MoneyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Money_MoneyId",
                table: "Bills",
                column: "MoneyId",
                principalTable: "Money",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Money_MoneyId",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_MoneyId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "MoneyId",
                table: "Bills");

            migrationBuilder.CreateTable(
                name: "MoneySalary",
                columns: table => new
                {
                    BillsId = table.Column<int>(type: "int", nullable: false),
                    MoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneySalary", x => new { x.BillsId, x.MoneyId });
                    table.ForeignKey(
                        name: "FK_MoneySalary_Bills_BillsId",
                        column: x => x.BillsId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoneySalary_Money_MoneyId",
                        column: x => x.MoneyId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoneySalary_MoneyId",
                table: "MoneySalary",
                column: "MoneyId");
        }
    }
}
