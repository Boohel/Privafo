using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class AddOrgToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrgID",
                table: "risk_register",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RiskCtgID",
                table: "risk_register",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RiskTypeID",
                table: "risk_register",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RangeColor",
                table: "risk_range_score",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RiskCtgID",
                table: "risk_library",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RiskTypeID",
                table: "risk_library",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "industries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_industries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "risk_ctg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskCtgName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_ctg", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_provinces_countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ProvinceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cities_provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "provinces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Add1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Add2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Add3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Address_cities_CityID",
                        column: x => x.CityID,
                        principalTable: "cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchPIC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_branches_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustryID = table.Column<int>(type: "int", nullable: false),
                    EntityPIC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_entities_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_entities_industries_IndustryID",
                        column: x => x.IndustryID,
                        principalTable: "industries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "organization",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OrgName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OrgSort = table.Column<int>(type: "int", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Organization_branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_OrgID",
                table: "risk_register",
                column: "OrgID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_RiskCtgID",
                table: "risk_register",
                column: "RiskCtgID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_RiskTypeID",
                table: "risk_register",
                column: "RiskTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_RiskCtgID",
                table: "risk_library",
                column: "RiskCtgID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_RiskTypeID",
                table: "risk_library",
                column: "RiskTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityID",
                table: "Address",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_branches_AddressID",
                table: "branches",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_cities_ProvinceID",
                table: "cities",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_entities_AddressID",
                table: "entities",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_entities_IndustryID",
                table: "entities",
                column: "IndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_BranchID",
                table: "organization",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_CountryID",
                table: "provinces",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_library_risk_ctg_RiskCtgID",
                table: "risk_library",
                column: "RiskCtgID",
                principalTable: "risk_ctg",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_library_risk_type_RiskTypeID",
                table: "risk_library",
                column: "RiskTypeID",
                principalTable: "risk_type",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_Organization_OrgID",
                table: "risk_register",
                column: "OrgID",
                principalTable: "organization",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_risk_ctg_RiskCtgID",
                table: "risk_register",
                column: "RiskCtgID",
                principalTable: "risk_ctg",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_risk_type_RiskTypeID",
                table: "risk_register",
                column: "RiskTypeID",
                principalTable: "risk_type",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_risk_library_risk_ctg_RiskCtgID",
                table: "risk_library");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_library_risk_type_RiskTypeID",
                table: "risk_library");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_Organization_OrgID",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_risk_ctg_RiskCtgID",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_risk_type_RiskTypeID",
                table: "risk_register");

            migrationBuilder.DropTable(
                name: "entities");

            migrationBuilder.DropTable(
                name: "industries");

            migrationBuilder.DropTable(
                name: "organization");

            migrationBuilder.DropTable(
                name: "risk_ctg");

            migrationBuilder.DropTable(
                name: "branches");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "provinces");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_OrgID",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_RiskCtgID",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_RiskTypeID",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_library_RiskCtgID",
                table: "risk_library");

            migrationBuilder.DropIndex(
                name: "IX_risk_library_RiskTypeID",
                table: "risk_library");

            migrationBuilder.DropColumn(
                name: "OrgID",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "RiskCtgID",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "RiskTypeID",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "RangeColor",
                table: "risk_range_score");

            migrationBuilder.DropColumn(
                name: "RiskCtgID",
                table: "risk_library");

            migrationBuilder.DropColumn(
                name: "RiskTypeID",
                table: "risk_library");
        }
    }
}
