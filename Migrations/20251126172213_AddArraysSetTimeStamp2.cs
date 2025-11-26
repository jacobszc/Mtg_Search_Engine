using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddArraysSetTimeStamp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "DeckSet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeckSet_SetId",
                table: "DeckSet",
                column: "SetId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeckSet_Set_SetId",
                table: "DeckSet",
                column: "SetId",
                principalTable: "Set",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckSet_Set_SetId",
                table: "DeckSet");

            migrationBuilder.DropIndex(
                name: "IX_DeckSet_SetId",
                table: "DeckSet");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "DeckSet");
        }
    }
}
