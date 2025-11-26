using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddArraysSetTimeStamp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "Set",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "SealedProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "CardToken",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_SetId",
                table: "SealedProduct",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_CardToken_SetId",
                table: "CardToken",
                column: "SetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardToken_Set_SetId",
                table: "CardToken",
                column: "SetId",
                principalTable: "Set",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SealedProduct_Set_SetId",
                table: "SealedProduct",
                column: "SetId",
                principalTable: "Set",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardToken_Set_SetId",
                table: "CardToken");

            migrationBuilder.DropForeignKey(
                name: "FK_SealedProduct_Set_SetId",
                table: "SealedProduct");

            migrationBuilder.DropIndex(
                name: "IX_SealedProduct_SetId",
                table: "SealedProduct");

            migrationBuilder.DropIndex(
                name: "IX_CardToken_SetId",
                table: "CardToken");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "SealedProduct");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "CardToken");
        }
    }
}
