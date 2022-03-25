using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class ExtendNavToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Highlight",
                table: "modules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AreaName",
                table: "menus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasChild",
                table: "menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PageName",
                table: "menus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Highlight",
                table: "modules");

            migrationBuilder.DropColumn(
                name: "AreaName",
                table: "menus");

            migrationBuilder.DropColumn(
                name: "HasChild",
                table: "menus");

            migrationBuilder.DropColumn(
                name: "PageName",
                table: "menus");
        }
    }
}
