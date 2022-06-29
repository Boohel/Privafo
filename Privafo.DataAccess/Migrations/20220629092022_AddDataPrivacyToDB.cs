using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class AddDataPrivacyToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_cities_CityID",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_branches_Address_AddressID",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_entities_Address_AddressID",
                table: "entities");

            migrationBuilder.DropForeignKey(
                name: "FK_organization_branches_BranchID",
                table: "organization");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_location_Address_AddressID",
                table: "vendor_location");

            migrationBuilder.DropForeignKey(
                name: "FK_vendors_Address_AddressID",
                table: "vendors");

            migrationBuilder.DropIndex(
                name: "IX_organization_BranchID",
                table: "organization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "organization");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "address");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CityID",
                table: "address",
                newName: "IX_address_CityID");

            migrationBuilder.AddColumn<int>(
                name: "EntityID",
                table: "branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AggregateRiskMx",
                table: "assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechSecMeasureID",
                table: "assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_address",
                table: "address",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "privacy_req_type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privacy_req_type", x => x.ID);
                    table.ForeignKey(
                        name: "FK_privacy_req_type_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_privacy_req_type_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "privacy_subject",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privacy_subject", x => x.ID);
                    table.ForeignKey(
                        name: "FK_privacy_subject_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_privacy_subject_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TechSecMeasure",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechSecMeasureName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechSecMeasure", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TechSecMeasure_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechSecMeasure_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "privacy_request",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestorName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    SubjectTypeID = table.Column<int>(type: "int", nullable: false),
                    RequestTypeID = table.Column<int>(type: "int", nullable: false),
                    RequestDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Resolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privacy_request", x => x.ID);
                    table.ForeignKey(
                        name: "FK_privacy_request_branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "branches",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_privacy_request_countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "countries",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_privacy_request_privacy_req_type_RequestTypeID",
                        column: x => x.RequestTypeID,
                        principalTable: "privacy_req_type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_privacy_request_privacy_subject_SubjectTypeID",
                        column: x => x.SubjectTypeID,
                        principalTable: "privacy_subject",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_privacy_request_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_privacy_request_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "privacy_req_extend",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivacyReqID = table.Column<int>(type: "int", nullable: false),
                    ExtendedDays = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privacy_req_extend", x => x.ID);
                    table.ForeignKey(
                        name: "FK_privacy_req_extend_privacy_request_PrivacyReqID",
                        column: x => x.PrivacyReqID,
                        principalTable: "privacy_request",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_privacy_req_extend_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_privacy_req_extend_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_branches_EntityID",
                table: "branches",
                column: "EntityID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_AggregateRiskMx",
                table: "assets",
                column: "AggregateRiskMx");

            migrationBuilder.CreateIndex(
                name: "IX_assets_TechSecMeasureID",
                table: "assets",
                column: "TechSecMeasureID");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_req_extend_CreatedBy",
                table: "privacy_req_extend",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_req_extend_ModifiedBy",
                table: "privacy_req_extend",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_req_extend_PrivacyReqID",
                table: "privacy_req_extend",
                column: "PrivacyReqID");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_req_type_CreatedBy",
                table: "privacy_req_type",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_req_type_ModifiedBy",
                table: "privacy_req_type",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_request_BranchID",
                table: "privacy_request",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_request_CountryID",
                table: "privacy_request",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_request_CreatedBy",
                table: "privacy_request",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_request_ModifiedBy",
                table: "privacy_request",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_request_RequestTypeID",
                table: "privacy_request",
                column: "RequestTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_request_SubjectTypeID",
                table: "privacy_request",
                column: "SubjectTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_subject_CreatedBy",
                table: "privacy_subject",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_privacy_subject_ModifiedBy",
                table: "privacy_subject",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TechSecMeasure_CreatedBy",
                table: "TechSecMeasure",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TechSecMeasure_ModifiedBy",
                table: "TechSecMeasure",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_address_cities_CityID",
                table: "address",
                column: "CityID",
                principalTable: "cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_risk_matrix_score_AggregateRiskMx",
                table: "assets",
                column: "AggregateRiskMx",
                principalTable: "risk_matrix_score",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_assets_TechSecMeasure_TechSecMeasureID",
                table: "assets",
                column: "TechSecMeasureID",
                principalTable: "TechSecMeasure",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_branches_address_AddressID",
                table: "branches",
                column: "AddressID",
                principalTable: "address",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_branches_entities_EntityID",
                table: "branches",
                column: "EntityID",
                principalTable: "entities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_entities_address_AddressID",
                table: "entities",
                column: "AddressID",
                principalTable: "address",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_location_address_AddressID",
                table: "vendor_location",
                column: "AddressID",
                principalTable: "address",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_vendors_address_AddressID",
                table: "vendors",
                column: "AddressID",
                principalTable: "address",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_address_cities_CityID",
                table: "address");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_risk_matrix_score_AggregateRiskMx",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_TechSecMeasure_TechSecMeasureID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_branches_address_AddressID",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_branches_entities_EntityID",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_entities_address_AddressID",
                table: "entities");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_location_address_AddressID",
                table: "vendor_location");

            migrationBuilder.DropForeignKey(
                name: "FK_vendors_address_AddressID",
                table: "vendors");

            migrationBuilder.DropTable(
                name: "privacy_req_extend");

            migrationBuilder.DropTable(
                name: "TechSecMeasure");

            migrationBuilder.DropTable(
                name: "privacy_request");

            migrationBuilder.DropTable(
                name: "privacy_req_type");

            migrationBuilder.DropTable(
                name: "privacy_subject");

            migrationBuilder.DropIndex(
                name: "IX_branches_EntityID",
                table: "branches");

            migrationBuilder.DropIndex(
                name: "IX_assets_AggregateRiskMx",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_TechSecMeasureID",
                table: "assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_address",
                table: "address");

            migrationBuilder.DropColumn(
                name: "EntityID",
                table: "branches");

            migrationBuilder.DropColumn(
                name: "AggregateRiskMx",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "TechSecMeasureID",
                table: "assets");

            migrationBuilder.RenameTable(
                name: "address",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_address_CityID",
                table: "Address",
                newName: "IX_Address_CityID");

            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "organization",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_organization_BranchID",
                table: "organization",
                column: "BranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_cities_CityID",
                table: "Address",
                column: "CityID",
                principalTable: "cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_branches_Address_AddressID",
                table: "branches",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_entities_Address_AddressID",
                table: "entities",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_organization_branches_BranchID",
                table: "organization",
                column: "BranchID",
                principalTable: "branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_location_Address_AddressID",
                table: "vendor_location",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendors_Address_AddressID",
                table: "vendors",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
