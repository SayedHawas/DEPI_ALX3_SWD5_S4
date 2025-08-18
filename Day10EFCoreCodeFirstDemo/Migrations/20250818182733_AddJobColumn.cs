using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day10EFCoreCodeFirstDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddJobColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Job",
                table: "Employees");
        }
    }
}
