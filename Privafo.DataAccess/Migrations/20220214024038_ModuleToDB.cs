using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class ModuleToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "module_ctg",
                columns: table => new
                {
                    ModuleCtgID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleCtgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleCtgSort = table.Column<int>(type: "int", nullable: false),
                    ModuleCtgImg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_module_ctg", x => x.ModuleCtgID);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    ModuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleSort = table.Column<int>(type: "int", nullable: false),
                    ModuleImageClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModuleCtgID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.ModuleID);
                    table.ForeignKey(
                        name: "FK_modules_module_ctg_ModuleCtgID",
                        column: x => x.ModuleCtgID,
                        principalTable: "module_ctg",
                        principalColumn: "ModuleCtgID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "menus",
                columns: table => new
                {
                    MenuID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuSort = table.Column<int>(type: "int", nullable: false),
                    MenuImageClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_menus_modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
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
