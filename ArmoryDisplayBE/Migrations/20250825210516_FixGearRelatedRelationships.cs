using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmoryDisplayBE.Migrations
{
    /// <inheritdoc />
    public partial class FixGearRelatedRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GearStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BonusStatsId = table.Column<int>(type: "int", nullable: true),
                    BonusStatsValue = table.Column<int>(type: "int", nullable: true),
                    IsTwoPiece = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearSets_GearStats_BonusStatsId",
                        column: x => x.BonusStatsId,
                        principalTable: "GearStats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserHeroGears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserHeroId = table.Column<int>(type: "int", nullable: false),
                    GearTypeId = table.Column<int>(type: "int", nullable: false),
                    GearSetId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    UserHeroHeroId = table.Column<int>(type: "int", nullable: false),
                    UserHeroUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHeroGears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHeroGears_GearSets_GearSetId",
                        column: x => x.GearSetId,
                        principalTable: "GearSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHeroGears_GearTypes_GearTypeId",
                        column: x => x.GearTypeId,
                        principalTable: "GearTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHeroGears_UserHeroes_UserHeroHeroId_UserHeroUserId",
                        columns: x => new { x.UserHeroHeroId, x.UserHeroUserId },
                        principalTable: "UserHeroes",
                        principalColumns: new[] { "HeroId", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserHeroGearStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserHeroGearId = table.Column<int>(type: "int", nullable: false),
                    GearStatsId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    IsMainStat = table.Column<bool>(type: "bit", nullable: false),
                    IsPercent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHeroGearStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHeroGearStats_GearStats_GearStatsId",
                        column: x => x.GearStatsId,
                        principalTable: "GearStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHeroGearStats_UserHeroGears_UserHeroGearId",
                        column: x => x.UserHeroGearId,
                        principalTable: "UserHeroGears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GearSets_BonusStatsId",
                table: "GearSets",
                column: "BonusStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroGears_GearSetId",
                table: "UserHeroGears",
                column: "GearSetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroGears_GearTypeId",
                table: "UserHeroGears",
                column: "GearTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroGears_UserHeroHeroId_UserHeroUserId",
                table: "UserHeroGears",
                columns: new[] { "UserHeroHeroId", "UserHeroUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroGearStats_GearStatsId",
                table: "UserHeroGearStats",
                column: "GearStatsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroGearStats_UserHeroGearId",
                table: "UserHeroGearStats",
                column: "UserHeroGearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHeroGearStats");

            migrationBuilder.DropTable(
                name: "UserHeroGears");

            migrationBuilder.DropTable(
                name: "GearSets");

            migrationBuilder.DropTable(
                name: "GearTypes");

            migrationBuilder.DropTable(
                name: "GearStats");
        }
    }
}
