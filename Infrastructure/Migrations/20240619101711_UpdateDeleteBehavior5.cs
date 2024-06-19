using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDeleteBehavior5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "CompteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "CompteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
