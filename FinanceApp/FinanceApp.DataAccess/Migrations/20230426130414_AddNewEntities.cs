using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillMoney");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "GroupOfTransaction",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoneyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Money_MoneyId",
                        column: x => x.MoneyId,
                        principalTable: "Money",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "Savings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoneyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Savings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Savings_Money_MoneyId",
                        column: x => x.MoneyId,
                        principalTable: "Money",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_MoneyId",
                table: "Expenses",
                column: "MoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneySalary_MoneyId",
                table: "MoneySalary",
                column: "MoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_Savings_MoneyId",
                table: "Savings",
                column: "MoneyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "MoneySalary");

            migrationBuilder.DropTable(
                name: "Savings");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "GroupOfTransaction",
                newName: "Number");

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
    }
}
