using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class deleteDupsAndUpdatePkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardSet_Set_SetId",
                table: "CardSet");

            migrationBuilder.DropForeignKey(
                name: "FK_CardToken_Set_SetId",
                table: "CardToken");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckSet_Set_SetId",
                table: "DeckSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SealedProduct_Set_SetId",
                table: "SealedProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Set",
                table: "Set");

            migrationBuilder.DropIndex(
                name: "IX_SealedProduct_SetId",
                table: "SealedProduct");

            migrationBuilder.DropIndex(
                name: "IX_DeckSet_SetId",
                table: "DeckSet");

            migrationBuilder.DropIndex(
                name: "IX_CardToken_SetId",
                table: "CardToken");

            migrationBuilder.DropIndex(
                name: "IX_CardSet_SetId",
                table: "CardSet");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "SealedProduct");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "DeckSet");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "CardToken");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "CardSet");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Set",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Set",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "SetCode",
                table: "SealedProduct",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SetCode",
                table: "DeckSet",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetCode",
                table: "CardToken",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SetCode",
                table: "CardSet",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Set",
                table: "Set",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_SetCode",
                table: "SealedProduct",
                column: "SetCode");

            migrationBuilder.CreateIndex(
                name: "IX_DeckSet_SetCode",
                table: "DeckSet",
                column: "SetCode");

            migrationBuilder.CreateIndex(
                name: "IX_CardToken_SetCode",
                table: "CardToken",
                column: "SetCode");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_SetCode",
                table: "CardSet",
                column: "SetCode");

            migrationBuilder.AddForeignKey(
                name: "FK_CardSet_Set_SetCode",
                table: "CardSet",
                column: "SetCode",
                principalTable: "Set",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardToken_Set_SetCode",
                table: "CardToken",
                column: "SetCode",
                principalTable: "Set",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeckSet_Set_SetCode",
                table: "DeckSet",
                column: "SetCode",
                principalTable: "Set",
                principalColumn: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_SealedProduct_Set_SetCode",
                table: "SealedProduct",
                column: "SetCode",
                principalTable: "Set",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardSet_Set_SetCode",
                table: "CardSet");

            migrationBuilder.DropForeignKey(
                name: "FK_CardToken_Set_SetCode",
                table: "CardToken");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckSet_Set_SetCode",
                table: "DeckSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SealedProduct_Set_SetCode",
                table: "SealedProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Set",
                table: "Set");

            migrationBuilder.DropIndex(
                name: "IX_SealedProduct_SetCode",
                table: "SealedProduct");

            migrationBuilder.DropIndex(
                name: "IX_DeckSet_SetCode",
                table: "DeckSet");

            migrationBuilder.DropIndex(
                name: "IX_CardToken_SetCode",
                table: "CardToken");

            migrationBuilder.DropIndex(
                name: "IX_CardSet_SetCode",
                table: "CardSet");

            migrationBuilder.DropColumn(
                name: "SetCode",
                table: "SealedProduct");

            migrationBuilder.DropColumn(
                name: "SetCode",
                table: "DeckSet");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Set",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Set",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "SealedProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "DeckSet",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetCode",
                table: "CardToken",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "CardToken",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetCode",
                table: "CardSet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "CardSet",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Set",
                table: "Set",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_SetId",
                table: "SealedProduct",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_DeckSet_SetId",
                table: "DeckSet",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_CardToken_SetId",
                table: "CardToken",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_CardSet_SetId",
                table: "CardSet",
                column: "SetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardSet_Set_SetId",
                table: "CardSet",
                column: "SetId",
                principalTable: "Set",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardToken_Set_SetId",
                table: "CardToken",
                column: "SetId",
                principalTable: "Set",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeckSet_Set_SetId",
                table: "DeckSet",
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
    }
}
