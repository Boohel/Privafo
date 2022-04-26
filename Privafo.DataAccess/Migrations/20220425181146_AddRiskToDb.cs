using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class AddRiskToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RiskRegName",
                table: "risk_library");

            migrationBuilder.AlterColumn<string>(
                name: "RiskRegName",
                table: "risk_register",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 300);

            migrationBuilder.AddColumn<int>(
                name: "ActiveStatusID",
                table: "risk_register",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ActiveStatusID",
                table: "risk_library",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RiskLibName",
                table: "risk_library",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_ActiveStatusID",
                table: "risk_register",
                column: "ActiveStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_ActiveStatusID",
                table: "risk_library",
                column: "ActiveStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_risk_library_status_ActiveStatusID",
                table: "risk_library",
                column: "ActiveStatusID",
                principalTable: "status",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_risk_register_status_ActiveStatusID",
                table: "risk_register",
                column: "ActiveStatusID",
                principalTable: "status",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_risk_library_status_ActiveStatusID",
                table: "risk_library");

            migrationBuilder.DropForeignKey(
                name: "FK_risk_register_status_ActiveStatusID",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_register_ActiveStatusID",
                table: "risk_register");

            migrationBuilder.DropIndex(
                name: "IX_risk_library_ActiveStatusID",
                table: "risk_library");

            migrationBuilder.DropColumn(
                name: "ActiveStatusID",
                table: "risk_register");

            migrationBuilder.DropColumn(
                name: "ActiveStatusID",
                table: "risk_library");

            migrationBuilder.DropColumn(
                name: "RiskLibName",
                table: "risk_library");

            migrationBuilder.AlterColumn<int>(
                name: "RiskRegName",
                table: "risk_register",
                type: "int",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AddColumn<int>(
                name: "RiskRegName",
                table: "risk_library",
                type: "int",
                maxLength: 300,
                nullable: false,
                defaultValue: 0);
        }
    }
}
