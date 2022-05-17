using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class FixTablesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_risk_matrix_score_InherentRiskMx",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_risk_matrix_score_TargetRiskMx",
                table: "risk_register");

            migrationBuilder.RenameColumn(
                name: "ProvinceCode",
                table: "cities",
                newName: "CityCode");

            migrationBuilder.AlterColumn<int>(
                name: "TargetRiskMx",
                table: "risk_register",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InherentRiskMx",
                table: "risk_register",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_risk_matrix_score_InherentRiskMx",
                table: "risk_register",
                column: "InherentRiskMx",
                principalTable: "risk_matrix_score",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_risk_matrix_score_TargetRiskMx",
                table: "risk_register",
                column: "TargetRiskMx",
                principalTable: "risk_matrix_score",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_risk_matrix_score_InherentRiskMx",
                table: "risk_register");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_risk_matrix_score_TargetRiskMx",
                table: "risk_register");

            migrationBuilder.RenameColumn(
                name: "CityCode",
                table: "cities",
                newName: "ProvinceCode");

            migrationBuilder.AlterColumn<int>(
                name: "TargetRiskMx",
                table: "risk_register",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InherentRiskMx",
                table: "risk_register",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_risk_matrix_score_InherentRiskMx",
                table: "risk_register",
                column: "InherentRiskMx",
                principalTable: "risk_matrix_score",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_risk_matrix_score_TargetRiskMx",
                table: "risk_register",
                column: "TargetRiskMx",
                principalTable: "risk_matrix_score",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
