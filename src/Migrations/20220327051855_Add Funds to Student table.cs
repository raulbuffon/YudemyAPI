using Microsoft.EntityFrameworkCore.Migrations;

namespace YudemyAPI.Migrations
{
    public partial class AddFundstoStudenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Funds",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Funds",
                table: "Students");
        }
    }
}
