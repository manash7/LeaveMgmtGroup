using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementAPP.Migrations
{
    /// <inheritdoc />
    public partial class LMcontext3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpDesc",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "CategoryLeaveCount",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryLeaveCount",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "EmpDesc",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
