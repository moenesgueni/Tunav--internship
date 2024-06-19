using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientClick_Comptes_CompteId",
                table: "ClientClick");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClick_Comptes_CompteId",
                table: "ClientClick",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "CompteId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientClick_Comptes_CompteId",
                table: "ClientClick");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClick_Comptes_CompteId",
                table: "ClientClick",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "CompteId");
        }
    }
}
