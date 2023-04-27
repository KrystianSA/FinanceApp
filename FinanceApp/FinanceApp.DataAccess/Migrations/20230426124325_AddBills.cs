using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillMoney",
                columns: table => new
                {
                    BillsId = table.Column<int>(type: "int", nullable: false),
                    MoneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillMoney", x => new { x.BillsId, x.MoneyId });
                    table.ForeignKey(
                        name: "FK_BillMoney_Bills_BillsId",
                        column: x => x.BillsId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillMoney_Money_MoneyId",
                        column: x => x.MoneyId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillMoney_MoneyId",
                table: "BillMoney",
                column: "MoneyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillMoney");

            migrationBuilder.DropTable(
                name: "Bills");
        }
    }
}
