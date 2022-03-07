using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Privafo.DataAccess.Migrations
{
    public partial class AddRiskDataToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "risk_impact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskImpactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LevelSort = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_impact", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "risk_probability",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskProbabilityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LevelSort = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_probability", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "risk_range_score",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinRange = table.Column<double>(type: "float", nullable: false),
                    MaxRange = table.Column<double>(type: "float", nullable: false),
                    RiskLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_range_score", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "risk_threats",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThreatName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_threats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "risk_type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "risk_vulneries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VulnerabilityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_vulneries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "risk_matrix_score",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskProbID = table.Column<int>(type: "int", nullable: false),
                    RiskImpactID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_matrix_score", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_matrix_score_risk_impact_RiskImpactID",
                        column: x => x.RiskImpactID,
                        principalTable: "risk_impact",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_risk_matrix_score_risk_probability_RiskProbID",
                        column: x => x.RiskProbID,
                        principalTable: "risk_probability",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "risk_library",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskRegName = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Threat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vulnerability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidualRiskMx = table.Column<int>(type: "int", nullable: false),
                    InherentRiskMx = table.Column<int>(type: "int", nullable: false),
                    TargetRiskMx = table.Column<int>(type: "int", nullable: false),
                    TreatmentPlan = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_library", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_library_risk_matrix_score_InherentRiskMx",
                        column: x => x.InherentRiskMx,
                        principalTable: "risk_matrix_score",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_library_risk_matrix_score_ResidualRiskMx",
                        column: x => x.ResidualRiskMx,
                        principalTable: "risk_matrix_score",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_library_risk_matrix_score_TargetRiskMx",
                        column: x => x.TargetRiskMx,
                        principalTable: "risk_matrix_score",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "risk_register",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskRegName = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Threat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vulnerability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidualRiskMx = table.Column<int>(type: "int", nullable: false),
                    InherentRiskMx = table.Column<int>(type: "int", nullable: false),
                    TargetRiskMx = table.Column<int>(type: "int", nullable: false),
                    TreatmentPlan = table.Column<int>(type: "int", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reminder = table.Column<bool>(type: "bit", nullable: false),
                    Approver = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_risk_register", x => x.ID);
                    table.ForeignKey(
                        name: "FK_risk_register_risk_matrix_score_InherentRiskMx",
                        column: x => x.InherentRiskMx,
                        principalTable: "risk_matrix_score",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_register_risk_matrix_score_ResidualRiskMx",
                        column: x => x.ResidualRiskMx,
                        principalTable: "risk_matrix_score",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_register_risk_matrix_score_TargetRiskMx",
                        column: x => x.TargetRiskMx,
                        principalTable: "risk_matrix_score",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_register_users_Approver",
                        column: x => x.Approver,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_risk_register_users_Owner",
                        column: x => x.Owner,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_InherentRiskMx",
                table: "risk_library",
                column: "InherentRiskMx");

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_ResidualRiskMx",
                table: "risk_library",
                column: "ResidualRiskMx");

            migrationBuilder.CreateIndex(
                name: "IX_risk_library_TargetRiskMx",
                table: "risk_library",
                column: "TargetRiskMx");

            migrationBuilder.CreateIndex(
                name: "IX_risk_matrix_score_RiskImpactID",
                table: "risk_matrix_score",
                column: "RiskImpactID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_matrix_score_RiskProbID",
                table: "risk_matrix_score",
                column: "RiskProbID");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_Approver",
                table: "risk_register",
                column: "Approver");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_InherentRiskMx",
                table: "risk_register",
                column: "InherentRiskMx");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_Owner",
                table: "risk_register",
                column: "Owner");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_ResidualRiskMx",
                table: "risk_register",
                column: "ResidualRiskMx");

            migrationBuilder.CreateIndex(
                name: "IX_risk_register_TargetRiskMx",
                table: "risk_register",
                column: "TargetRiskMx");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "risk_library");

            migrationBuilder.DropTable(
                name: "risk_range_score");

            migrationBuilder.DropTable(
                name: "risk_register");

            migrationBuilder.DropTable(
                name: "risk_threats");

            migrationBuilder.DropTable(
                name: "risk_type");

            migrationBuilder.DropTable(
                name: "risk_vulneries");

            migrationBuilder.DropTable(
                name: "risk_matrix_score");

            migrationBuilder.DropTable(
                name: "risk_impact");

            migrationBuilder.DropTable(
                name: "risk_probability");
        }
    }
}
