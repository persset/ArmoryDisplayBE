using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmoryDisplayBE.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabaseSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Constellations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroRarities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseStars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroRarities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroBaseStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstellationId = table.Column<int>(type: "int", nullable: false),
                    HeroClassId = table.Column<int>(type: "int", nullable: false),
                    HeroRarityId = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CriticalHitChance = table.Column<double>(type: "float", nullable: false),
                    CriticalHitDamage = table.Column<int>(type: "int", nullable: false),
                    Effectiveness = table.Column<double>(type: "float", nullable: false),
                    EffectResistance = table.Column<double>(type: "float", nullable: false),
                    DualAttackChance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroBaseStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroBaseStats_Constellations_ConstellationId",
                        column: x => x.ConstellationId,
                        principalTable: "Constellations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroBaseStats_HeroClasses_HeroClassId",
                        column: x => x.HeroClassId,
                        principalTable: "HeroClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroBaseStats_HeroRarities_HeroRarityId",
                        column: x => x.HeroRarityId,
                        principalTable: "HeroRarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstellationId = table.Column<int>(type: "int", nullable: false),
                    ElementId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    RarityId = table.Column<int>(type: "int", nullable: false),
                    HeroClassId = table.Column<int>(type: "int", nullable: false),
                    HeroRarityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_Constellations_ConstellationId",
                        column: x => x.ConstellationId,
                        principalTable: "Constellations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heroes_Elements_ElementId",
                        column: x => x.ElementId,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heroes_HeroClasses_HeroClassId",
                        column: x => x.HeroClassId,
                        principalTable: "HeroClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heroes_HeroRarities_HeroRarityId",
                        column: x => x.HeroRarityId,
                        principalTable: "HeroRarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSocials",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SocialsId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSocials", x => new { x.SocialsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserSocials_Socials_SocialsId",
                        column: x => x.SocialsId,
                        principalTable: "Socials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSocials_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialtyChangeBonusStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CriticalHitChance = table.Column<double>(type: "float", nullable: false),
                    CriticalHitDamage = table.Column<int>(type: "int", nullable: false),
                    Effectiveness = table.Column<double>(type: "float", nullable: false),
                    EffectResistance = table.Column<double>(type: "float", nullable: false),
                    DualAttackChance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialtyChangeBonusStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialtyChangeBonusStats_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserHeroes",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CriticalHitChance = table.Column<double>(type: "float", nullable: false),
                    CriticalHitDamage = table.Column<int>(type: "int", nullable: false),
                    Effectiveness = table.Column<double>(type: "float", nullable: false),
                    EffectResistance = table.Column<double>(type: "float", nullable: false),
                    DualAttackChance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHeroes", x => new { x.HeroId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserHeroes_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHeroes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroBaseStats_ConstellationId",
                table: "HeroBaseStats",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroBaseStats_HeroClassId",
                table: "HeroBaseStats",
                column: "HeroClassId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroBaseStats_HeroRarityId",
                table: "HeroBaseStats",
                column: "HeroRarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_ConstellationId",
                table: "Heroes",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_ElementId",
                table: "Heroes",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_HeroClassId",
                table: "Heroes",
                column: "HeroClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_HeroRarityId",
                table: "Heroes",
                column: "HeroRarityId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialtyChangeBonusStats_HeroId",
                table: "SpecialtyChangeBonusStats",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroes_UserId",
                table: "UserHeroes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSocials_UserId",
                table: "UserSocials",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroBaseStats");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "SpecialtyChangeBonusStats");

            migrationBuilder.DropTable(
                name: "UserHeroes");

            migrationBuilder.DropTable(
                name: "UserSocials");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Constellations");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "HeroClasses");

            migrationBuilder.DropTable(
                name: "HeroRarities");
        }
    }
}
