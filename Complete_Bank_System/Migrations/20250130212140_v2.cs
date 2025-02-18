using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Complete_Bank_System.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "employees",
                newName: "Employee_Name");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "employees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Employee_Name",
                table: "employees",
                column: "Employee_Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_employees_Employee_Name",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "password",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "customers");

            migrationBuilder.RenameColumn(
                name: "Employee_Name",
                table: "employees",
                newName: "FullName");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
