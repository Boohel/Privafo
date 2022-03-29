using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class ExtendMenuToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuLevel",
                table: "menus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuLevel",
                table: "menus");
        }
    }
}
