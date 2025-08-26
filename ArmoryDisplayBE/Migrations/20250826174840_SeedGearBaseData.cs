using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmoryDisplayBE.Migrations
{
    /// <inheritdoc />
    public partial class SeedGearBaseData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GearSets_GearStats_BonusStatsId",
                table: "GearSets"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserHeroGearStats_GearStats_GearStatsId",
                table: "UserHeroGearStats"
            );

            migrationBuilder.DropTable(name: "GearStats");

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                }
            );

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Health" },
                    { 2, "Attack" },
                    { 3, "Defense" },
                    { 4, "Speed" },
                    { 5, "Critical Rate" },
                    { 6, "Critical Damage" },
                    { 7, "Effectiveness" },
                    { 8, "Effect Resistance" },
                    { 9, "Dual Attack Chance" },
                }
            );

            migrationBuilder.AddForeignKey(
                name: "FK_GearSets_Stats_BonusStatsId",
                table: "GearSets",
                column: "BonusStatsId",
                principalTable: "Stats",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserHeroGearStats_Stats_GearStatsId",
                table: "UserHeroGearStats",
                column: "GearStatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GearSets_Stats_BonusStatsId",
                table: "GearSets"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserHeroGearStats_Stats_GearStatsId",
                table: "UserHeroGearStats"
            );

            migrationBuilder.DropTable(name: "Stats");

            migrationBuilder.CreateTable(
                name: "GearStats",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearStats", x => x.Id);
                }
            );

            migrationBuilder.InsertData(
                table: "GearStats",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Health" },
                    { 2, "Attack" },
                    { 3, "Defense" },
                    { 4, "Speed" },
                    { 5, "Critical Rate" },
                    { 6, "Critical Damage" },
                    { 7, "Effectiveness" },
                    { 8, "Effect Resistance" },
                }
            );

            migrationBuilder.AddForeignKey(
                name: "FK_GearSets_GearStats_BonusStatsId",
                table: "GearSets",
                column: "BonusStatsId",
                principalTable: "GearStats",
                principalColumn: "Id"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserHeroGearStats_GearStats_GearStatsId",
                table: "UserHeroGearStats",
                column: "GearStatsId",
                principalTable: "GearStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade
            );
        }
    }
}
