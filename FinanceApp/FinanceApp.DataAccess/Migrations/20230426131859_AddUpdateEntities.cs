using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdateEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Money_MoneyId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Money_MoneyId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Savings_Money_MoneyId",
                table: "Savings");

            migrationBuilder.DropIndex(
                name: "IX_Savings_MoneyId",
                table: "Savings");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_MoneyId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Bills_MoneyId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "MoneyId",
                table: "Savings");

            migrationBuilder.DropColumn(
                name: "MoneyId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "MoneyId",
                table: "Bills");

            migrationBuilder.AddColumn<int>(
                name: "BillsId",
                table: "Money",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpensesId",
                table: "Money",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaryId",
                table: "Money",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SavingsId",
                table: "Money",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Money_BillsId",
                table: "Money",
                column: "BillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Money_ExpensesId",
                table: "Money",
                column: "ExpensesId");

            migrationBuilder.CreateIndex(
                name: "IX_Money_SalaryId",
                table: "Money",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Money_SavingsId",
                table: "Money",
                column: "SavingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Money_Bills_SalaryId",
                table: "Money",
                column: "SalaryId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Money_Expenses_ExpensesId",
                table: "Money",
                column: "ExpensesId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Money_Salary_BillsId",
                table: "Money",
                column: "BillsId",
                principalTable: "Salary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Money_Savings_SavingsId",
                table: "Money",
                column: "SavingsId",
                principalTable: "Savings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Money_Bills_SalaryId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_Expenses_ExpensesId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_Salary_BillsId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_Savings_SavingsId",
                table: "Money");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropIndex(
                name: "IX_Money_BillsId",
                table: "Money");

            migrationBuilder.DropIndex(
                name: "IX_Money_ExpensesId",
                table: "Money");

            migrationBuilder.DropIndex(
                name: "IX_Money_SalaryId",
                table: "Money");

            migrationBuilder.DropIndex(
                name: "IX_Money_SavingsId",
                table: "Money");

            migrationBuilder.DropColumn(
                name: "BillsId",
                table: "Money");

            migrationBuilder.DropColumn(
                name: "ExpensesId",
                table: "Money");

            migrationBuilder.DropColumn(
                name: "SalaryId",
                table: "Money");

            migrationBuilder.DropColumn(
                name: "SavingsId",
                table: "Money");

            migrationBuilder.AddColumn<int>(
                name: "MoneyId",
                table: "Savings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MoneyId",
                table: "Expenses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MoneyId",
                table: "Bills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Savings_MoneyId",
                table: "Savings",
                column: "MoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_MoneyId",
                table: "Expenses",
                column: "MoneyId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Money_MoneyId",
                table: "Expenses",
                column: "MoneyId",
                principalTable: "Money",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Savings_Money_MoneyId",
                table: "Savings",
                column: "MoneyId",
                principalTable: "Money",
                principalColumn: "Id");
        }
    }
}
