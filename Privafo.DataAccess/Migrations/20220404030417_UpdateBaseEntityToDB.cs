using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class UpdateBaseEntityToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assets_users_ModifiedBy",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_branches_users_ModifiedBy",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_control_ctg_users_ModifiedBy",
                table: "control_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_control_library_users_ModifiedBy",
                table: "control_library");

            migrationBuilder.DropForeignKey(
                name: "FK_control_reg_users_ModifiedBy",
                table: "control_reg");

            migrationBuilder.DropForeignKey(
                name: "FK_control_source_users_ModifiedBy",
                table: "control_source");

            migrationBuilder.DropForeignKey(
                name: "FK_data_elements_users_ModifiedBy",
                table: "data_elements");

            migrationBuilder.DropForeignKey(
                name: "FK_data_subject_users_ModifiedBy",
                table: "data_subject");

            migrationBuilder.DropForeignKey(
                name: "FK_dpia_template_users_ModifiedBy",
                table: "dpia_template");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_ctg_users_ModifiedBy",
                table: "dte_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_source_users_ModifiedBy",
                table: "dte_source");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_transfer_users_ModifiedBy",
                table: "dte_transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_volume_users_ModifiedBy",
                table: "dte_volume");

            migrationBuilder.DropForeignKey(
                name: "FK_entities_users_ModifiedBy",
                table: "entities");

            migrationBuilder.DropForeignKey(
                name: "FK_org_sec_measure_users_ModifiedBy",
                table: "org_sec_measure");

            migrationBuilder.DropForeignKey(
                name: "FK_organization_users_ModifiedBy",
                table: "organization");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_ctg_users_ModifiedBy",
                table: "risk_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_library_users_ModifiedBy",
                table: "risk_library");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_matrix_score_users_ModifiedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_range_score_users_ModifiedBy",
                table: "risk_range_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_users_ModifiedBy",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_threats_users_ModifiedBy",
                table: "risk_threats");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_type_users_ModifiedBy",
                table: "risk_type");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_vulneries_users_ModifiedBy",
                table: "risk_vulneries");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_engage_users_ModifiedBy",
                table: "vendor_engage");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_location_users_ModifiedBy",
                table: "vendor_location");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_product_users_ModifiedBy",
                table: "vendor_product");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_product_ctg_users_ModifiedBy",
                table: "vendor_product_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_type_users_ModifiedBy",
                table: "vendor_type");

            migrationBuilder.DropForeignKey(
                name: "FK_vendors_users_ModifiedBy",
                table: "vendors");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendors",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_type",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_product_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_product",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_location",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_engage",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_vulneries",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_type",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_threats",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_register",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_range_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_matrix_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_library",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "organization",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "org_sec_measure",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "entities",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_volume",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_transfer",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_source",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dpia_template",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "data_subject",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "data_elements",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_source",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_reg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_library",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "branches",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "assets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_users_ModifiedBy",
                table: "assets",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_branches_users_ModifiedBy",
                table: "branches",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_control_ctg_users_ModifiedBy",
                table: "control_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_control_library_users_ModifiedBy",
                table: "control_library",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_control_reg_users_ModifiedBy",
                table: "control_reg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_control_source_users_ModifiedBy",
                table: "control_source",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_data_elements_users_ModifiedBy",
                table: "data_elements",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_data_subject_users_ModifiedBy",
                table: "data_subject",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dpia_template_users_ModifiedBy",
                table: "dpia_template",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dte_ctg_users_ModifiedBy",
                table: "dte_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dte_source_users_ModifiedBy",
                table: "dte_source",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dte_transfer_users_ModifiedBy",
                table: "dte_transfer",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dte_volume_users_ModifiedBy",
                table: "dte_volume",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_entities_users_ModifiedBy",
                table: "entities",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_org_sec_measure_users_ModifiedBy",
                table: "org_sec_measure",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_organization_users_ModifiedBy",
                table: "organization",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_ctg_users_ModifiedBy",
                table: "risk_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_library_users_ModifiedBy",
                table: "risk_library",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_matrix_score_users_ModifiedBy",
                table: "risk_matrix_score",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_range_score_users_ModifiedBy",
                table: "risk_range_score",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_users_ModifiedBy",
                table: "risk_register",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_threats_users_ModifiedBy",
                table: "risk_threats",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_type_users_ModifiedBy",
                table: "risk_type",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_vulneries_users_ModifiedBy",
                table: "risk_vulneries",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_engage_users_ModifiedBy",
                table: "vendor_engage",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_location_users_ModifiedBy",
                table: "vendor_location",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_product_users_ModifiedBy",
                table: "vendor_product",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_product_ctg_users_ModifiedBy",
                table: "vendor_product_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_type_users_ModifiedBy",
                table: "vendor_type",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendors_users_ModifiedBy",
                table: "vendors",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assets_users_ModifiedBy",
                table: "assets");

            migrationBuilder.DropForeignKey(
                name: "FK_branches_users_ModifiedBy",
                table: "branches");

            migrationBuilder.DropForeignKey(
                name: "FK_control_ctg_users_ModifiedBy",
                table: "control_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_control_library_users_ModifiedBy",
                table: "control_library");

            migrationBuilder.DropForeignKey(
                name: "FK_control_reg_users_ModifiedBy",
                table: "control_reg");

            migrationBuilder.DropForeignKey(
                name: "FK_control_source_users_ModifiedBy",
                table: "control_source");

            migrationBuilder.DropForeignKey(
                name: "FK_data_elements_users_ModifiedBy",
                table: "data_elements");

            migrationBuilder.DropForeignKey(
                name: "FK_data_subject_users_ModifiedBy",
                table: "data_subject");

            migrationBuilder.DropForeignKey(
                name: "FK_dpia_template_users_ModifiedBy",
                table: "dpia_template");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_ctg_users_ModifiedBy",
                table: "dte_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_source_users_ModifiedBy",
                table: "dte_source");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_transfer_users_ModifiedBy",
                table: "dte_transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_dte_volume_users_ModifiedBy",
                table: "dte_volume");

            migrationBuilder.DropForeignKey(
                name: "FK_entities_users_ModifiedBy",
                table: "entities");

            migrationBuilder.DropForeignKey(
                name: "FK_org_sec_measure_users_ModifiedBy",
                table: "org_sec_measure");

            migrationBuilder.DropForeignKey(
                name: "FK_organization_users_ModifiedBy",
                table: "organization");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_ctg_users_ModifiedBy",
                table: "risk_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_library_users_ModifiedBy",
                table: "risk_library");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_matrix_score_users_ModifiedBy",
                table: "risk_matrix_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_range_score_users_ModifiedBy",
                table: "risk_range_score");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_users_ModifiedBy",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_threats_users_ModifiedBy",
                table: "risk_threats");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_type_users_ModifiedBy",
                table: "risk_type");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_vulneries_users_ModifiedBy",
                table: "risk_vulneries");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_engage_users_ModifiedBy",
                table: "vendor_engage");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_location_users_ModifiedBy",
                table: "vendor_location");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_product_users_ModifiedBy",
                table: "vendor_product");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_product_ctg_users_ModifiedBy",
                table: "vendor_product_ctg");

            migrationBuilder.DropForeignKey(
                name: "FK_vendor_type_users_ModifiedBy",
                table: "vendor_type");

            migrationBuilder.DropForeignKey(
                name: "FK_vendors_users_ModifiedBy",
                table: "vendors");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendors",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_type",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_product_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_product",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_location",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "vendor_engage",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_vulneries",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_type",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_threats",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_register",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_range_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_matrix_score",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_library",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "risk_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "organization",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "org_sec_measure",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "entities",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_volume",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_transfer",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_source",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dte_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "dpia_template",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "data_subject",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "data_elements",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_source",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_reg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_library",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "control_ctg",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "branches",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "assets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_assets_users_ModifiedBy",
                table: "assets",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_branches_users_ModifiedBy",
                table: "branches",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_control_ctg_users_ModifiedBy",
                table: "control_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_control_library_users_ModifiedBy",
                table: "control_library",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_control_reg_users_ModifiedBy",
                table: "control_reg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_control_source_users_ModifiedBy",
                table: "control_source",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_data_elements_users_ModifiedBy",
                table: "data_elements",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_data_subject_users_ModifiedBy",
                table: "data_subject",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dpia_template_users_ModifiedBy",
                table: "dpia_template",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dte_ctg_users_ModifiedBy",
                table: "dte_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dte_source_users_ModifiedBy",
                table: "dte_source",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dte_transfer_users_ModifiedBy",
                table: "dte_transfer",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dte_volume_users_ModifiedBy",
                table: "dte_volume",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_entities_users_ModifiedBy",
                table: "entities",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_org_sec_measure_users_ModifiedBy",
                table: "org_sec_measure",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_organization_users_ModifiedBy",
                table: "organization",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_ctg_users_ModifiedBy",
                table: "risk_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_library_users_ModifiedBy",
                table: "risk_library",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_matrix_score_users_ModifiedBy",
                table: "risk_matrix_score",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_range_score_users_ModifiedBy",
                table: "risk_range_score",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_users_ModifiedBy",
                table: "risk_register",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_threats_users_ModifiedBy",
                table: "risk_threats",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_type_users_ModifiedBy",
                table: "risk_type",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_vulneries_users_ModifiedBy",
                table: "risk_vulneries",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_engage_users_ModifiedBy",
                table: "vendor_engage",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_location_users_ModifiedBy",
                table: "vendor_location",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_product_users_ModifiedBy",
                table: "vendor_product",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_product_ctg_users_ModifiedBy",
                table: "vendor_product_ctg",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendor_type_users_ModifiedBy",
                table: "vendor_type",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendors_users_ModifiedBy",
                table: "vendors",
                column: "ModifiedBy",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
