using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementAPP.Migrations
{
    /// <inheritdoc />
    public partial class LMcontext1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeaveID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LeaveID",
                table: "Employees");
        }
    }
}
