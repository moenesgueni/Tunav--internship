using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientClicks",
                table: "ClientClicks");

            migrationBuilder.RenameTable(
                name: "ClientClicks",
                newName: "ClientClick");

            migrationBuilder.RenameIndex(
                name: "IX_ClientClicks_CompteId",
                table: "ClientClick",
                newName: "IX_ClientClick_CompteId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientClicks_ClientId",
                table: "ClientClick",
                newName: "IX_ClientClick_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientClick",
                table: "ClientClick",
                column: "ClientClickId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClick_Clients_ClientId",
                table: "ClientClick",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClick_Comptes_CompteId",
                table: "ClientClick",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "CompteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientClick_Clients_ClientId",
                table: "ClientClick");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientClick_Comptes_CompteId",
                table: "ClientClick");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientClick",
                table: "ClientClick");

            migrationBuilder.RenameTable(
                name: "ClientClick",
                newName: "ClientClicks");

            migrationBuilder.RenameIndex(
                name: "IX_ClientClick_CompteId",
                table: "ClientClicks",
                newName: "IX_ClientClicks_CompteId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientClick_ClientId",
                table: "ClientClicks",
                newName: "IX_ClientClicks_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientClicks",
                table: "ClientClicks",
                column: "ClientClickId");

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
                principalColumn: "CompteId");
        }
    }
}
