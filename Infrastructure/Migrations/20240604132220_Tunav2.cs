using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Tunav2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comptes_Clients_ClientId",
                table: "Comptes");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Comptes",
                newName: "ClientFk");

            migrationBuilder.RenameIndex(
                name: "IX_Comptes_ClientId",
                table: "Comptes",
                newName: "IX_Comptes_ClientFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Comptes_Clients_ClientFk",
                table: "Comptes",
                column: "ClientFk",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comptes_Clients_ClientFk",
                table: "Comptes");

            migrationBuilder.RenameColumn(
                name: "ClientFk",
                table: "Comptes",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Comptes_ClientFk",
                table: "Comptes",
                newName: "IX_Comptes_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comptes_Clients_ClientId",
                table: "Comptes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
