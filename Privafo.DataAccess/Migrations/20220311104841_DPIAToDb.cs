using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class DPIAToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_branches_BranchID",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_Organization_OrgID",
                table: "risk_register");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organization",
                table: "Organization");

            migrationBuilder.RenameTable(
                name: "Organization",
                newName: "organization");

            migrationBuilder.RenameIndex(
                name: "IX_Organization_BranchID",
                table: "organization",
                newName: "IX_organization_BranchID");

            migrationBuilder.AlterColumn<string>(
                name: "OrgID",
                table: "risk_register",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_organization",
                table: "organization",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "assets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_assets_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dpia_template",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Welcome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionJSON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dpia_template", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dpia_template_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dpia_asset",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateID = table.Column<int>(type: "int", nullable: false),
                    AssetID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dpia_asset", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dpia_asset_assets_AssetID",
                        column: x => x.AssetID,
                        principalTable: "assets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dpia_asset_dpia_template_TemplateID",
                        column: x => x.TemplateID,
                        principalTable: "dpia_template",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_assets_UserID",
                table: "assets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_dpia_asset_AssetID",
                table: "dpia_asset",
                column: "AssetID");

            migrationBuilder.CreateIndex(
                name: "IX_dpia_asset_TemplateID",
                table: "dpia_asset",
                column: "TemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_dpia_template_UserID",
                table: "dpia_template",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_organization_branches_BranchID",
                table: "organization",
                column: "BranchID",
                principalTable: "branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_organization_OrgID",
                table: "risk_register",
                column: "OrgID",
                principalTable: "organization",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_organization_branches_BranchID",
                table: "organization");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_organization_OrgID",
                table: "risk_register");

            migrationBuilder.DropTable(
                name: "dpia_asset");

            migrationBuilder.DropTable(
                name: "assets");

            migrationBuilder.DropTable(
                name: "dpia_template");

            migrationBuilder.DropPrimaryKey(
                name: "PK_organization",
                table: "organization");

            migrationBuilder.RenameTable(
                name: "organization",
                newName: "Organization");

            migrationBuilder.RenameIndex(
                name: "IX_organization_BranchID",
                table: "Organization",
                newName: "IX_Organization_BranchID");

            migrationBuilder.AlterColumn<string>(
                name: "OrgID",
                table: "risk_register",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organization",
                table: "Organization",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_branches_BranchID",
                table: "Organization",
                column: "BranchID",
                principalTable: "branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_Organization_OrgID",
                table: "risk_register",
                column: "OrgID",
                principalTable: "Organization",
                principalColumn: "ID");
        }
    }
}
