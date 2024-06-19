using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientClicks_Clients_ClientId",
                table: "ClientClicks");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClicks_Clients_ClientId",
                table: "ClientClicks",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "CompteId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientClicks_Clients_ClientId",
                table: "ClientClicks");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClicks_Clients_ClientId",
                table: "ClientClicks",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClicks_Comptes_CompteId",
                table: "ClientClicks",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "CompteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
