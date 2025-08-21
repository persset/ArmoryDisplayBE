using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmoryDisplayBE.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationshipUserServer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_ServerId",
                table: "Users",
                column: "ServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Servers_ServerId",
                table: "Users",
                column: "ServerId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Servers_ServerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ServerId",
                table: "Users");
        }
    }
}
