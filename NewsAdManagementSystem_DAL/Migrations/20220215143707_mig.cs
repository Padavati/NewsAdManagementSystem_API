using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsAdManagementSystem_DAL.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailID",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pwd",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailID",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Pwd",
                table: "CustomerDetails");
        }
    }
}
