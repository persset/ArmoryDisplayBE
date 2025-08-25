using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArmoryDisplayBE.Migrations
{
    /// <inheritdoc />
    public partial class SeedGearRelatedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GearSets",
                columns: new[] { "Id", "BonusStatsId", "BonusStatsValue", "IsTwoPiece", "Name" },
                values: new object[,]
                {
                    { 7, null, null, false, "Protection Set" },
                    { 10, null, null, false, "Lifesteal Set" },
                    { 11, null, null, false, "Counter Set" },
                    { 12, null, null, true, "Unity Set" },
                    { 13, null, null, true, "Immunity Set" },
                    { 14, null, null, false, "Rage Set" },
                    { 16, null, null, true, "Penetration Set" },
                    { 17, null, null, true, "Torrent Set" },
                    { 18, null, null, false, "Injury Set" },
                    { 19, null, null, false, "Reversal Set" },
                    { 20, null, null, false, "Riposte Set" }
                });

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
                    { 8, "Effect Resistance" }
                });

            migrationBuilder.InsertData(
                table: "GearTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Helmet" },
                    { 2, "Armor" },
                    { 3, "Boots" },
                    { 4, "Weapon" },
                    { 5, "Necklace" },
                    { 6, "Ring" }
                });

            migrationBuilder.InsertData(
                table: "GearSets",
                columns: new[] { "Id", "BonusStatsId", "BonusStatsValue", "IsTwoPiece", "Name" },
                values: new object[,]
                {
                    { 1, 4, 25, false, "Speed Set" },
                    { 2, 5, 12, true, "Critical Set" },
                    { 3, 7, 20, true, "Hit Set" },
                    { 4, 1, 20, true, "Health Set" },
                    { 5, 2, 45, false, "Attack Set" },
                    { 6, 3, 20, true, "Defense Set" },
                    { 8, 8, 20, true, "Resist Set" },
                    { 9, 6, 60, false, "Destruction Set" },
                    { 15, 4, 12, false, "Revenge Set" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GearSets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GearTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GearTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GearTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GearTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GearTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GearTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GearStats",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
