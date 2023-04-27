using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdateEntityMoney : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Money_Bills_SalaryId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_Expenses_ExpensesId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_Salary_BillsId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_Savings_SavingsId",
                table: "Money");

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

            migrationBuilder.AlterColumn<int>(
                name: "GroupOfTransactionId",
                table: "Money",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money",
                column: "GroupOfTransactionId",
                principalTable: "GroupOfTransaction",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money");

            migrationBuilder.AlterColumn<int>(
                name: "GroupOfTransactionId",
                table: "Money",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_Money_GroupOfTransaction_GroupOfTransactionId",
                table: "Money",
                column: "GroupOfTransactionId",
                principalTable: "GroupOfTransaction",
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
    }
}
