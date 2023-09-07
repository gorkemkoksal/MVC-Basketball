using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketballMVC.Migrations
{
    public partial class college : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlayerCollege",
                table: "Raptors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerCollege",
                table: "Raptors");
        }
    }
}
