using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class AddCtrlDEProcAsstVenToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assets_users_UserID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_dpia_template_users_UserID",
                table: "dpia_template");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_risk_ctg_RiskCtgID",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_users_Approver",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_Approver",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_RiskCtgID",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "Approver",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "RiskCtgID",
                table: "risk_register");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "dpia_template",
                newName: "ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_dpia_template_UserID",
                table: "dpia_template",
                newName: "IX_dpia_template_ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "assets",
                newName: "Owner");

            migrationBuilder.RenameIndex(
                name: "IX_assets_UserID",
                table: "assets",
                newName: "IX_assets_Owner");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_vulneries",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_vulneries",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_type",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "risk_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "risk_type",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_type",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_threats",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_threats",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "risk_register",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_register",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_register",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_range_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "risk_range_score",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "risk_range_score",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_range_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_matrix_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "risk_matrix_score",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "risk_matrix_score",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_matrix_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_library",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_library",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "risk_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "risk_ctg",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "risk_ctg",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "risk_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "organization",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "organization",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "entities",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "entities",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Welcome",
                table: "dpia_template",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "QuestionJSON",
                table: "dpia_template",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "dpia_template",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "dpia_template",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "branches",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "branches",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "AssetName",
                table: "assets",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "ActiveStatusID",
                table: "assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AstDisposalID",
                table: "assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AstStorageFormatID",
                table: "assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AstTypeID",
                table: "assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "assets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DataRetention",
                table: "assets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DteVolumeID",
                table: "assets",
                type: "int",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Emplacement",
                table: "assets",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HostIPAddress",
                table: "assets",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HostingProvider",
                table: "assets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HostingType",
                table: "assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMaster",
                table: "assets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MasterRecord",
                table: "assets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "assets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrgID",
                table: "assets",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrgSecMeasureID",
                table: "assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherSecurity",
                table: "assets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ownership",
                table: "assets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VendorID",
                table: "assets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "asset_disposal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AstDisposalName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_disposal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "asset_storage_format",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AstStorFormatName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_storage_format", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "asset_type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AstTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "control_ctg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtrCtgName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_ctg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_ctg_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_ctg_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "control_source",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtrSourceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_source", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_source_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_source_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "data_subject",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSubjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_subject", x => x.ID);
                    table.ForeignKey(
                        name: "FK_data_subject_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_data_subject_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_ctg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteCtgName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_ctg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_ctg_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_ctg_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_source",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteSourceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_source", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_source_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_source_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_transfer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteTransferName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_transfer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_transfer_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_transfer_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_volume",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteVolumeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MinVol = table.Column<double>(type: "float", nullable: false),
                    MaxVol = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_volume", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_volume_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_volume_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "org_sec_measure",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgSecMeasureName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_org_sec_measure", x => x.ID);
                    table.ForeignKey(
                        name: "FK_org_sec_measure_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_org_sec_measure_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "risk_approver",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskRegID = table.Column<int>(type: "int", nullable: false),
                    Approver = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_approver", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_approver_risk_register_RiskRegID",
                        column: x => x.RiskRegID,
                        principalTable: "risk_register",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_approver_users_Approver",
                        column: x => x.Approver,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "risk_asset",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskRegID = table.Column<int>(type: "int", nullable: false),
                    AssetID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_asset", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_asset_assets_AssetID",
                        column: x => x.AssetID,
                        principalTable: "assets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_asset_risk_register_RiskRegID",
                        column: x => x.RiskRegID,
                        principalTable: "risk_register",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "risk_reg_ctg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskRegID = table.Column<int>(type: "int", nullable: false),
                    RiskCtgID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_reg_ctg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_reg_ctg_risk_ctg_RiskCtgID",
                        column: x => x.RiskCtgID,
                        principalTable: "risk_ctg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_reg_ctg_risk_register_RiskRegID",
                        column: x => x.RiskRegID,
                        principalTable: "risk_register",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActiveStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "vendor_product_ctg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenProdCtgName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor_product_ctg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vendor_product_ctg_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_product_ctg_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "vendor_type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor_type", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vendor_type_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_type_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "control_reg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtrRegName = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtrRegStandard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    OrgID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CtrSourceID = table.Column<int>(type: "int", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reminder = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_reg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_reg_control_source_CtrSourceID",
                        column: x => x.CtrSourceID,
                        principalTable: "control_source",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_control_reg_organization_OrgID",
                        column: x => x.OrgID,
                        principalTable: "organization",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_control_reg_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_reg_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_reg_users_Owner",
                        column: x => x.Owner,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "data_elements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataElementName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DteCtgID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_elements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_data_elements_dte_ctg_DteCtgID",
                        column: x => x.DteCtgID,
                        principalTable: "dte_ctg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_data_elements_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_data_elements_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "control_library",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtrRegName = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtrCtgID = table.Column<int>(type: "int", nullable: false),
                    ControlCtgID = table.Column<int>(type: "int", nullable: false),
                    CtrRegStandard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtrSourceID = table.Column<int>(type: "int", nullable: false),
                    ActiveStatusID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_library", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_library_control_ctg_ControlCtgID",
                        column: x => x.ControlCtgID,
                        principalTable: "control_ctg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_control_library_control_source_CtrSourceID",
                        column: x => x.CtrSourceID,
                        principalTable: "control_source",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_control_library_status_ActiveStatusID",
                        column: x => x.ActiveStatusID,
                        principalTable: "status",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_control_library_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_library_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "vendor_product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenProdCtgID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor_product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vendor_product_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_product_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_product_vendor_product_ctg_VenProdCtgID",
                        column: x => x.VenProdCtgID,
                        principalTable: "vendor_product_ctg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vendors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    VenTypeID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorPIC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    ActiveStatusID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vendors_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendors_status_ActiveStatusID",
                        column: x => x.ActiveStatusID,
                        principalTable: "status",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vendors_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendors_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendors_vendor_type_VenTypeID",
                        column: x => x.VenTypeID,
                        principalTable: "vendor_type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "control_approver",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtrRegID = table.Column<int>(type: "int", nullable: false),
                    Approver = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_approver", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_approver_control_reg_CtrRegID",
                        column: x => x.CtrRegID,
                        principalTable: "control_reg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_approver_users_Approver",
                        column: x => x.Approver,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "control_asset",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtrRegID = table.Column<int>(type: "int", nullable: false),
                    AssetID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_asset", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_asset_assets_AssetID",
                        column: x => x.AssetID,
                        principalTable: "assets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_asset_control_reg_CtrRegID",
                        column: x => x.CtrRegID,
                        principalTable: "control_reg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "control_reg_ctg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlID = table.Column<int>(type: "int", nullable: false),
                    CtrCtgID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_reg_ctg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_reg_ctg_control_ctg_CtrCtgID",
                        column: x => x.CtrCtgID,
                        principalTable: "control_ctg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_reg_ctg_control_reg_ControlID",
                        column: x => x.ControlID,
                        principalTable: "control_reg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_asset",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteID = table.Column<int>(type: "int", nullable: false),
                    AssetID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_asset", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_asset_assets_AssetID",
                        column: x => x.AssetID,
                        principalTable: "assets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_asset_data_elements_DteID",
                        column: x => x.DteID,
                        principalTable: "data_elements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_data_subject",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteID = table.Column<int>(type: "int", nullable: false),
                    DataSubjectID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_data_subject", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_data_subject_data_elements_DteID",
                        column: x => x.DteID,
                        principalTable: "data_elements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_data_subject_data_subject_DataSubjectID",
                        column: x => x.DataSubjectID,
                        principalTable: "data_subject",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_process",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteID = table.Column<int>(type: "int", nullable: false),
                    AssetID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_process", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_process_assets_AssetID",
                        column: x => x.AssetID,
                        principalTable: "assets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_process_data_elements_DteID",
                        column: x => x.DteID,
                        principalTable: "data_elements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "control_process",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlRegID = table.Column<int>(type: "int", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_process", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_process_control_reg_ControlRegID",
                        column: x => x.ControlRegID,
                        principalTable: "control_reg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_process_vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "vendors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "control_vendor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlRegID = table.Column<int>(type: "int", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_control_vendor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_control_vendor_control_reg_ControlRegID",
                        column: x => x.ControlRegID,
                        principalTable: "control_reg",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_control_vendor_vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "vendors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "dte_vendor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DteID = table.Column<int>(type: "int", nullable: false),
                    vendorID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dte_vendor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dte_vendor_data_elements_DteID",
                        column: x => x.DteID,
                        principalTable: "data_elements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dte_vendor_vendors_vendorID",
                        column: x => x.vendorID,
                        principalTable: "vendors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "risk_process",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskRegID = table.Column<int>(type: "int", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_process", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_process_risk_register_RiskRegID",
                        column: x => x.RiskRegID,
                        principalTable: "risk_register",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_process_vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "vendors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "risk_vendor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskRegID = table.Column<int>(type: "int", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_vendor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_vendor_risk_register_RiskRegID",
                        column: x => x.RiskRegID,
                        principalTable: "risk_register",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_vendor_vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "vendors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "vendor_engage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenEngageName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    VenStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VenEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reminder = table.Column<bool>(type: "bit", nullable: false),
                    VenContactDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenContactFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor_engage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vendor_engage_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_engage_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_engage_vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "vendors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vendor_location",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    VenLocName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    VendorPIC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    ActiveStatusID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor_location", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vendor_location_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_location_status_ActiveStatusID",
                        column: x => x.ActiveStatusID,
                        principalTable: "status",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vendor_location_users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_location_users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_vendor_location_vendors_VendorID",
                        column: x => x.VendorID,
                        principalTable: "vendors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_risk_vulneries_CreatedBy",
                table: "risk_vulneries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_vulneries_ModifiedBy",
                table: "risk_vulneries",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_type_CreatedBy",
                table: "risk_type",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_type_ModifiedBy",
                table: "risk_type",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_threats_CreatedBy",
                table: "risk_threats",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_threats_ModifiedBy",
                table: "risk_threats",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_CreatedBy",
                table: "risk_register",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_ModifiedBy",
                table: "risk_register",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_range_score_CreatedBy",
                table: "risk_range_score",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_range_score_ModifiedBy",
                table: "risk_range_score",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_matrix_score_CreatedBy",
                table: "risk_matrix_score",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_matrix_score_ModifiedBy",
                table: "risk_matrix_score",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_CreatedBy",
                table: "risk_library",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_ModifiedBy",
                table: "risk_library",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_ctg_CreatedBy",
                table: "risk_ctg",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_ctg_ModifiedBy",
                table: "risk_ctg",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_organization_CreatedBy",
                table: "organization",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_organization_ModifiedBy",
                table: "organization",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_entities_CreatedBy",
                table: "entities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_entities_ModifiedBy",
                table: "entities",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dpia_template_CreatedBy",
                table: "dpia_template",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_branches_CreatedBy",
                table: "branches",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_branches_ModifiedBy",
                table: "branches",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_assets_ActiveStatusID",
                table: "assets",
                column: "ActiveStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_AstDisposalID",
                table: "assets",
                column: "AstDisposalID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_AstStorageFormatID",
                table: "assets",
                column: "AstStorageFormatID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_AstTypeID",
                table: "assets",
                column: "AstTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_CountryID",
                table: "assets",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_CreatedBy",
                table: "assets",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_assets_DteVolumeID",
                table: "assets",
                column: "DteVolumeID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_ModifiedBy",
                table: "assets",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_assets_OrgID",
                table: "assets",
                column: "OrgID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_OrgSecMeasureID",
                table: "assets",
                column: "OrgSecMeasureID");

            migrationBuilder.CreateIndex(
                name: "IX_assets_VendorID",
                table: "assets",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_control_approver_Approver",
                table: "control_approver",
                column: "Approver");

            migrationBuilder.CreateIndex(
                name: "IX_control_approver_CtrRegID",
                table: "control_approver",
                column: "CtrRegID");

            migrationBuilder.CreateIndex(
                name: "IX_control_asset_AssetID",
                table: "control_asset",
                column: "AssetID");

            migrationBuilder.CreateIndex(
                name: "IX_control_asset_CtrRegID",
                table: "control_asset",
                column: "CtrRegID");

            migrationBuilder.CreateIndex(
                name: "IX_control_ctg_CreatedBy",
                table: "control_ctg",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_ctg_ModifiedBy",
                table: "control_ctg",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_library_ActiveStatusID",
                table: "control_library",
                column: "ActiveStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_control_library_ControlCtgID",
                table: "control_library",
                column: "ControlCtgID");

            migrationBuilder.CreateIndex(
                name: "IX_control_library_CreatedBy",
                table: "control_library",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_library_CtrSourceID",
                table: "control_library",
                column: "CtrSourceID");

            migrationBuilder.CreateIndex(
                name: "IX_control_library_ModifiedBy",
                table: "control_library",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_process_ControlRegID",
                table: "control_process",
                column: "ControlRegID");

            migrationBuilder.CreateIndex(
                name: "IX_control_process_VendorID",
                table: "control_process",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_control_reg_CreatedBy",
                table: "control_reg",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_reg_CtrSourceID",
                table: "control_reg",
                column: "CtrSourceID");

            migrationBuilder.CreateIndex(
                name: "IX_control_reg_ModifiedBy",
                table: "control_reg",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_reg_OrgID",
                table: "control_reg",
                column: "OrgID");

            migrationBuilder.CreateIndex(
                name: "IX_control_reg_Owner",
                table: "control_reg",
                column: "Owner");

            migrationBuilder.CreateIndex(
                name: "IX_control_reg_ctg_ControlID",
                table: "control_reg_ctg",
                column: "ControlID");

            migrationBuilder.CreateIndex(
                name: "IX_control_reg_ctg_CtrCtgID",
                table: "control_reg_ctg",
                column: "CtrCtgID");

            migrationBuilder.CreateIndex(
                name: "IX_control_source_CreatedBy",
                table: "control_source",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_source_ModifiedBy",
                table: "control_source",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_control_vendor_ControlRegID",
                table: "control_vendor",
                column: "ControlRegID");

            migrationBuilder.CreateIndex(
                name: "IX_control_vendor_VendorID",
                table: "control_vendor",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_data_elements_CreatedBy",
                table: "data_elements",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_data_elements_DteCtgID",
                table: "data_elements",
                column: "DteCtgID");

            migrationBuilder.CreateIndex(
                name: "IX_data_elements_ModifiedBy",
                table: "data_elements",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_data_subject_CreatedBy",
                table: "data_subject",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_data_subject_ModifiedBy",
                table: "data_subject",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_asset_AssetID",
                table: "dte_asset",
                column: "AssetID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_asset_DteID",
                table: "dte_asset",
                column: "DteID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_ctg_CreatedBy",
                table: "dte_ctg",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_ctg_ModifiedBy",
                table: "dte_ctg",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_data_subject_DataSubjectID",
                table: "dte_data_subject",
                column: "DataSubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_data_subject_DteID",
                table: "dte_data_subject",
                column: "DteID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_process_AssetID",
                table: "dte_process",
                column: "AssetID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_process_DteID",
                table: "dte_process",
                column: "DteID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_source_CreatedBy",
                table: "dte_source",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_source_ModifiedBy",
                table: "dte_source",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_transfer_CreatedBy",
                table: "dte_transfer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_transfer_ModifiedBy",
                table: "dte_transfer",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_vendor_DteID",
                table: "dte_vendor",
                column: "DteID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_vendor_vendorID",
                table: "dte_vendor",
                column: "vendorID");

            migrationBuilder.CreateIndex(
                name: "IX_dte_volume_CreatedBy",
                table: "dte_volume",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_dte_volume_ModifiedBy",
                table: "dte_volume",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_org_sec_measure_CreatedBy",
                table: "org_sec_measure",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_org_sec_measure_ModifiedBy",
                table: "org_sec_measure",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_risk_approver_Approver",
                table: "risk_approver",
                column: "Approver");

            migrationBuilder.CreateIndex(
                name: "IX_risk_approver_RiskRegID",
                table: "risk_approver",
                column: "RiskRegID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_asset_AssetID",
                table: "risk_asset",
                column: "AssetID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_asset_RiskRegID",
                table: "risk_asset",
                column: "RiskRegID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_process_RiskRegID",
                table: "risk_process",
                column: "RiskRegID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_process_VendorID",
                table: "risk_process",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_reg_ctg_RiskCtgID",
                table: "risk_reg_ctg",
                column: "RiskCtgID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_reg_ctg_RiskRegID",
                table: "risk_reg_ctg",
                column: "RiskRegID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_vendor_RiskRegID",
                table: "risk_vendor",
                column: "RiskRegID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_vendor_VendorID",
                table: "risk_vendor",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_engage_CreatedBy",
                table: "vendor_engage",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_engage_ModifiedBy",
                table: "vendor_engage",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_engage_VendorID",
                table: "vendor_engage",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_location_ActiveStatusID",
                table: "vendor_location",
                column: "ActiveStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_location_AddressID",
                table: "vendor_location",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_location_CreatedBy",
                table: "vendor_location",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_location_ModifiedBy",
                table: "vendor_location",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_location_VendorID",
                table: "vendor_location",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_product_CreatedBy",
                table: "vendor_product",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_product_ModifiedBy",
                table: "vendor_product",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_product_VenProdCtgID",
                table: "vendor_product",
                column: "VenProdCtgID");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_product_ctg_CreatedBy",
                table: "vendor_product_ctg",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_product_ctg_ModifiedBy",
                table: "vendor_product_ctg",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_type_CreatedBy",
                table: "vendor_type",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_type_ModifiedBy",
                table: "vendor_type",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendors_ActiveStatusID",
                table: "vendors",
                column: "ActiveStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_vendors_AddressID",
                table: "vendors",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_vendors_CreatedBy",
                table: "vendors",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendors_ModifiedBy",
                table: "vendors",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_vendors_VenTypeID",
                table: "vendors",
                column: "VenTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_assets_asset_disposal_AstDisposalID",
                table: "assets",
                column: "AstDisposalID",
                principalTable: "asset_disposal",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_assets_asset_storage_format_AstStorageFormatID",
                table: "assets",
                column: "AstStorageFormatID",
                principalTable: "asset_storage_format",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_asset_type_AstTypeID",
                table: "assets",
                column: "AstTypeID",
                principalTable: "asset_type",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_countries_CountryID",
                table: "assets",
                column: "CountryID",
                principalTable: "countries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_dte_volume_DteVolumeID",
                table: "assets",
                column: "DteVolumeID",
                principalTable: "dte_volume",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_assets_org_sec_measure_OrgSecMeasureID",
                table: "assets",
                column: "OrgSecMeasureID",
                principalTable: "org_sec_measure",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_assets_organization_OrgID",
                table: "assets",
                column: "OrgID",
                principalTable: "organization",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_assets_status_ActiveStatusID",
                table: "assets",
                column: "ActiveStatusID",
                principalTable: "status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_users_CreatedBy",
                table: "assets",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_users_ModifiedBy",
                table: "assets",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_users_Owner",
                table: "assets",
                column: "Owner",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_vendors_VendorID",
                table: "assets",
                column: "VendorID",
                principalTable: "vendors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_branches_users_CreatedBy",
                table: "branches",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_branches_users_ModifiedBy",
                table: "branches",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_dpia_template_users_CreatedBy",
                table: "dpia_template",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_dpia_template_users_ModifiedBy",
                table: "dpia_template",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_entities_users_CreatedBy",
                table: "entities",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_entities_users_ModifiedBy",
                table: "entities",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_organization_users_CreatedBy",
                table: "organization",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_organization_users_ModifiedBy",
                table: "organization",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_ctg_users_CreatedBy",
                table: "risk_ctg",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_ctg_users_ModifiedBy",
                table: "risk_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_library_users_CreatedBy",
                table: "risk_library",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_library_users_ModifiedBy",
                table: "risk_library",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_matrix_score_users_CreatedBy",
                table: "risk_matrix_score",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_matrix_score_users_ModifiedBy",
                table: "risk_matrix_score",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_range_score_users_CreatedBy",
                table: "risk_range_score",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_range_score_users_ModifiedBy",
                table: "risk_range_score",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_users_CreatedBy",
                table: "risk_register",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_users_ModifiedBy",
                table: "risk_register",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_threats_users_CreatedBy",
                table: "risk_threats",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_threats_users_ModifiedBy",
                table: "risk_threats",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_type_users_CreatedBy",
                table: "risk_type",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_type_users_ModifiedBy",
                table: "risk_type",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_vulneries_users_CreatedBy",
                table: "risk_vulneries",
                column: "CreatedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_vulneries_users_ModifiedBy",
                table: "risk_vulneries",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assets_asset_disposal_AstDisposalID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_asset_storage_format_AstStorageFormatID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_asset_type_AstTypeID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_countries_CountryID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_dte_volume_DteVolumeID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_org_sec_measure_OrgSecMeasureID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_organization_OrgID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_status_ActiveStatusID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_users_CreatedBy",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_users_ModifiedBy",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_users_Owner",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_assets_vendors_VendorID",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_branches_users_CreatedBy",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_branches_users_ModifiedBy",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_dpia_template_users_CreatedBy",
                table: "dpia_template");

            migrationBuilder.DropForeignKey(
                name: "FK_dpia_template_users_ModifiedBy",
                table: "dpia_template");

            migrationBuilder.DropForeignKey(
                name: "FK_entities_users_CreatedBy",
                table: "entities");

            migrationBuilder.DropForeignKey(
                name: "FK_entities_users_ModifiedBy",
                table: "entities");

            migrationBuilder.DropForeignKey(
                name: "FK_organization_users_CreatedBy",
                table: "organization");

            migrationBuilder.DropForeignKey(
                name: "FK_organization_users_ModifiedBy",
                table: "organization");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_ctg_users_CreatedBy",
                table: "risk_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_ctg_users_ModifiedBy",
                table: "risk_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_library_users_CreatedBy",
                table: "risk_library");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_library_users_ModifiedBy",
                table: "risk_library");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_matrix_score_users_CreatedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_matrix_score_users_ModifiedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_range_score_users_CreatedBy",
                table: "risk_range_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_range_score_users_ModifiedBy",
                table: "risk_range_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_users_CreatedBy",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_users_ModifiedBy",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_threats_users_CreatedBy",
                table: "risk_threats");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_threats_users_ModifiedBy",
                table: "risk_threats");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_type_users_CreatedBy",
                table: "risk_type");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_type_users_ModifiedBy",
                table: "risk_type");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_vulneries_users_CreatedBy",
                table: "risk_vulneries");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_vulneries_users_ModifiedBy",
                table: "risk_vulneries");

            migrationBuilder.DropTable(
                name: "asset_disposal");

            migrationBuilder.DropTable(
                name: "asset_storage_format");

            migrationBuilder.DropTable(
                name: "asset_type");

            migrationBuilder.DropTable(
                name: "control_approver");

            migrationBuilder.DropTable(
                name: "control_asset");

            migrationBuilder.DropTable(
                name: "control_library");

            migrationBuilder.DropTable(
                name: "control_process");

            migrationBuilder.DropTable(
                name: "control_reg_ctg");

            migrationBuilder.DropTable(
                name: "control_vendor");

            migrationBuilder.DropTable(
                name: "dte_asset");

            migrationBuilder.DropTable(
                name: "dte_data_subject");

            migrationBuilder.DropTable(
                name: "dte_process");

            migrationBuilder.DropTable(
                name: "dte_source");

            migrationBuilder.DropTable(
                name: "dte_transfer");

            migrationBuilder.DropTable(
                name: "dte_vendor");

            migrationBuilder.DropTable(
                name: "dte_volume");

            migrationBuilder.DropTable(
                name: "org_sec_measure");

            migrationBuilder.DropTable(
                name: "risk_approver");

            migrationBuilder.DropTable(
                name: "risk_asset");

            migrationBuilder.DropTable(
                name: "risk_process");

            migrationBuilder.DropTable(
                name: "risk_reg_ctg");

            migrationBuilder.DropTable(
                name: "risk_vendor");

            migrationBuilder.DropTable(
                name: "vendor_engage");

            migrationBuilder.DropTable(
                name: "vendor_location");

            migrationBuilder.DropTable(
                name: "vendor_product");

            migrationBuilder.DropTable(
                name: "control_ctg");

            migrationBuilder.DropTable(
                name: "control_reg");

            migrationBuilder.DropTable(
                name: "data_subject");

            migrationBuilder.DropTable(
                name: "data_elements");

            migrationBuilder.DropTable(
                name: "vendors");

            migrationBuilder.DropTable(
                name: "vendor_product_ctg");

            migrationBuilder.DropTable(
                name: "control_source");

            migrationBuilder.DropTable(
                name: "dte_ctg");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "vendor_type");

            migrationBuilder.DropIndex(
                name: "IX_risk_vulneries_CreatedBy",
                table: "risk_vulneries");

            migrationBuilder.DropIndex(
                name: "IX_risk_vulneries_ModifiedBy",
                table: "risk_vulneries");

            migrationBuilder.DropIndex(
                name: "IX_risk_type_CreatedBy",
                table: "risk_type");

            migrationBuilder.DropIndex(
                name: "IX_risk_type_ModifiedBy",
                table: "risk_type");

            migrationBuilder.DropIndex(
                name: "IX_risk_threats_CreatedBy",
                table: "risk_threats");

            migrationBuilder.DropIndex(
                name: "IX_risk_threats_ModifiedBy",
                table: "risk_threats");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_CreatedBy",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_ModifiedBy",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_range_score_CreatedBy",
                table: "risk_range_score");

            migrationBuilder.DropIndex(
                name: "IX_risk_range_score_ModifiedBy",
                table: "risk_range_score");

            migrationBuilder.DropIndex(
                name: "IX_risk_matrix_score_CreatedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropIndex(
                name: "IX_risk_matrix_score_ModifiedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropIndex(
                name: "IX_risk_library_CreatedBy",
                table: "risk_library");

            migrationBuilder.DropIndex(
                name: "IX_risk_library_ModifiedBy",
                table: "risk_library");

            migrationBuilder.DropIndex(
                name: "IX_risk_ctg_CreatedBy",
                table: "risk_ctg");

            migrationBuilder.DropIndex(
                name: "IX_risk_ctg_ModifiedBy",
                table: "risk_ctg");

            migrationBuilder.DropIndex(
                name: "IX_organization_CreatedBy",
                table: "organization");

            migrationBuilder.DropIndex(
                name: "IX_organization_ModifiedBy",
                table: "organization");

            migrationBuilder.DropIndex(
                name: "IX_entities_CreatedBy",
                table: "entities");

            migrationBuilder.DropIndex(
                name: "IX_entities_ModifiedBy",
                table: "entities");

            migrationBuilder.DropIndex(
                name: "IX_dpia_template_CreatedBy",
                table: "dpia_template");

            migrationBuilder.DropIndex(
                name: "IX_branches_CreatedBy",
                table: "branches");

            migrationBuilder.DropIndex(
                name: "IX_branches_ModifiedBy",
                table: "branches");

            migrationBuilder.DropIndex(
                name: "IX_assets_ActiveStatusID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_AstDisposalID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_AstStorageFormatID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_AstTypeID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_CountryID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_CreatedBy",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_DteVolumeID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_ModifiedBy",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_OrgID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_OrgSecMeasureID",
                table: "assets");

            migrationBuilder.DropIndex(
                name: "IX_assets_VendorID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_vulneries");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_vulneries");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_type");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "risk_type");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "risk_type");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_type");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_threats");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_threats");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_range_score");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "risk_range_score");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "risk_range_score");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_range_score");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "risk_matrix_score");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "risk_matrix_score");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_library");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_library");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "risk_ctg");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "risk_ctg");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "risk_ctg");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "risk_ctg");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "organization");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "organization");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "entities");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "entities");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "dpia_template");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "branches");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "branches");

            migrationBuilder.DropColumn(
                name: "ActiveStatusID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "AstDisposalID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "AstStorageFormatID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "AstTypeID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "DataRetention",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "DteVolumeID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "Emplacement",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "HostIPAddress",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "HostingProvider",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "HostingType",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "IsMaster",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "MasterRecord",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "OrgID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "OrgSecMeasureID",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "OtherSecurity",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "Ownership",
                table: "assets");

            migrationBuilder.DropColumn(
                name: "VendorID",
                table: "assets");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "dpia_template",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_dpia_template_ModifiedBy",
                table: "dpia_template",
                newName: "IX_dpia_template_UserID");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "assets",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_assets_Owner",
                table: "assets",
                newName: "IX_assets_UserID");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "risk_register",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddColumn<string>(
                name: "Approver",
                table: "risk_register",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RiskCtgID",
                table: "risk_register",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Welcome",
                table: "dpia_template",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuestionJSON",
                table: "dpia_template",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "dpia_template",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssetName",
                table: "assets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_Approver",
                table: "risk_register",
                column: "Approver");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_RiskCtgID",
                table: "risk_register",
                column: "RiskCtgID");

            migrationBuilder.AddForeignKey(
                name: "FK_assets_users_UserID",
                table: "assets",
                column: "UserID",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dpia_template_users_UserID",
                table: "dpia_template",
                column: "UserID",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_risk_ctg_RiskCtgID",
                table: "risk_register",
                column: "RiskCtgID",
                principalTable: "risk_ctg",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_users_Approver",
                table: "risk_register",
                column: "Approver",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
