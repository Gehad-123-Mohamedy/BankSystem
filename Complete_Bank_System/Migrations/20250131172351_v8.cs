using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complete_Bank_System.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_customers_CustomerId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_employees_EmployeeId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_Loans_LoansId",
                table: "transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loans",
                table: "Loans");

            migrationBuilder.RenameTable(
                name: "Loans",
                newName: "loans");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_EmployeeId",
                table: "loans",
                newName: "IX_loans_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Loans_CustomerId",
                table: "loans",
                newName: "IX_loans_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_loans",
                table: "loans",
                column: "LoansId");

            migrationBuilder.AddForeignKey(
                name: "FK_loans_customers_CustomerId",
                table: "loans",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loans_customers_CustomerId",
                table: "loans");

            migrationBuilder.DropForeignKey(
                name: "FK_loans_employees_EmployeeId",
                table: "loans");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_loans_LoansId",
                table: "transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_loans",
                table: "loans");

            migrationBuilder.RenameTable(
                name: "loans",
                newName: "Loans");

            migrationBuilder.RenameIndex(
                name: "IX_loans_EmployeeId",
                table: "Loans",
                newName: "IX_Loans_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_loans_CustomerId",
                table: "Loans",
                newName: "IX_Loans_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loans",
                table: "Loans",
                column: "LoansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_customers_CustomerId",
                table: "Loans",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_employees_EmployeeId",
                table: "Loans",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_Loans_LoansId",
                table: "transactions",
                column: "LoansId",
                principalTable: "Loans",
                principalColumn: "LoansId");
        }
    }
}
