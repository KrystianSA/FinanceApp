using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ValidationInBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Money",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Money",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Money",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Money",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Money",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Money",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Money",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Money",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
