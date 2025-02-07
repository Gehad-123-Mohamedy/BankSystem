using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complete_Bank_System.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Loans",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_EmployeeId",
                table: "Loans",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_employees_EmployeeId",
                table: "Loans",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_employees_EmployeeId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_EmployeeId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Loans");
        }
    }
}
