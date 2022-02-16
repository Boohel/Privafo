using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class NavigatesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "module_ctg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleCtgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModuleCtgSort = table.Column<int>(type: "int", nullable: false),
                    ModuleCtgImg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_module_ctg", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ModuleSort = table.Column<int>(type: "int", nullable: false),
                    ModuleImageClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModuleCtgID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_modules_module_ctg_ModuleCtgID",
                        column: x => x.ModuleCtgID,
                        principalTable: "module_ctg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "menus",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MenuSort = table.Column<int>(type: "int", nullable: false),
                    MenuImageClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MenuGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MenuKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParentID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ModuleID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_menus_modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "modules",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_menus_ModuleID",
                table: "menus",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_modules_ModuleCtgID",
                table: "modules",
                column: "ModuleCtgID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menus");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "module_ctg");
        }
    }
}
