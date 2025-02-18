using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complete_Bank_System.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loans_employees_EmployeeId",
                table: "loans");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_loans_LoansId",
                table: "transactions");

            migrationBuilder.DropIndex(
                name: "IX_loans_EmployeeId",
                table: "loans");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "loans");

            migrationBuilder.RenameColumn(
                name: "LoansId",
                table: "transactions",
                newName: "LoanId");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_LoansId",
                table: "transactions",
                newName: "IX_transactions_LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_loans_LoanId",
                table: "transactions",
                column: "LoanId",
                principalTable: "loans",
                principalColumn: "LoansId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_loans_LoanId",
                table: "transactions");

            migrationBuilder.RenameColumn(
                name: "LoanId",
                table: "transactions",
                newName: "LoansId");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_LoanId",
                table: "transactions",
                newName: "IX_transactions_LoansId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "loans",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_loans_EmployeeId",
                table: "loans",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_loans_employees_EmployeeId",
                table: "loans",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_loans_LoansId",
                table: "transactions",
                column: "LoansId",
                principalTable: "loans",
                principalColumn: "LoansId");
        }
    }
}
