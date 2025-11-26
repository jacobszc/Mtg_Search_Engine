using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddArraysSetTimeStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardSet_PurchaseUrls_PurchaseUrlsId",
                table: "CardSet");

            migrationBuilder.DropForeignKey(
                name: "FK_CardToken_Set_SetId",
                table: "CardToken");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckSet_Set_SetId",
                table: "DeckSet");

            migrationBuilder.DropForeignKey(
                name: "FK_Rulings_CardSet_CardSetId",
                table: "Rulings");

            migrationBuilder.DropForeignKey(
                name: "FK_SealedProduct_PurchaseUrls_PurchaseUrlsId",
                table: "SealedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SealedProduct_Set_SetId",
                table: "SealedProduct");

            migrationBuilder.DropTable(
                name: "PurchaseUrls");

            migrationBuilder.DropIndex(
                name: "IX_SealedProduct_SetId",
                table: "SealedProduct");

            migrationBuilder.DropIndex(
                name: "IX_Rulings_CardSetId",
                table: "Rulings");

            migrationBuilder.DropIndex(
                name: "IX_DeckSet_SetId",
                table: "DeckSet");

            migrationBuilder.DropIndex(
                name: "IX_CardToken_SetId",
                table: "CardToken");

            migrationBuilder.DropColumn(
                name: "etched",
                table: "SourceProducts");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "SealedProduct");

            migrationBuilder.DropColumn(
                name: "CardSetId",
                table: "Rulings");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "DeckSet");

            migrationBuilder.DropColumn(
                name: "SetId",
                table: "CardToken");

            migrationBuilder.DropColumn(
                name: "RebalancedPrintings",
                table: "CardSet");

            migrationBuilder.DropColumn(
                name: "Subsets",
                table: "CardSet");

            migrationBuilder.DropColumn(
                name: "Subtypes",
                table: "CardSet");

            migrationBuilder.DropColumn(
                name: "Supertypes",
                table: "CardSet");

            migrationBuilder.RenameColumn(
                name: "nonfoil",
                table: "SourceProducts",
                newName: "Nonfoil");

            migrationBuilder.RenameColumn(
                name: "foil",
                table: "SourceProducts",
                newName: "Foil");

            migrationBuilder.RenameColumn(
                name: "PurchaseUrlsId",
                table: "SealedProduct",
                newName: "PurchaceUrlsId");

            migrationBuilder.RenameIndex(
                name: "IX_SealedProduct_PurchaseUrlsId",
                table: "SealedProduct",
                newName: "IX_SealedProduct_PurchaceUrlsId");

            migrationBuilder.RenameColumn(
                name: "PurchaseUrlsId",
                table: "CardSet",
                newName: "PurchaceUrlsId");

            migrationBuilder.RenameIndex(
                name: "IX_CardSet_PurchaseUrlsId",
                table: "CardSet",
                newName: "IX_CardSet_PurchaceUrlsId");

            migrationBuilder.AlterColumn<string>(
                name: "Nonfoil",
                table: "SourceProducts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Foil",
                table: "SourceProducts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "PurchaceUrls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardKingdom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomEtched = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomFoil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cardmarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tcgplayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcgplayerEtched = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaceUrls", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CardSet_PurchaceUrls_PurchaceUrlsId",
                table: "CardSet",
                column: "PurchaceUrlsId",
                principalTable: "PurchaceUrls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SealedProduct_PurchaceUrls_PurchaceUrlsId",
                table: "SealedProduct",
                column: "PurchaceUrlsId",
                principalTable: "PurchaceUrls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardSet_PurchaceUrls_PurchaceUrlsId",
                table: "CardSet");

            migrationBuilder.DropForeignKey(
                name: "FK_SealedProduct_PurchaceUrls_PurchaceUrlsId",
                table: "SealedProduct");

            migrationBuilder.DropTable(
                name: "PurchaceUrls");

            migrationBuilder.RenameColumn(
                name: "Nonfoil",
                table: "SourceProducts",
                newName: "nonfoil");

            migrationBuilder.RenameColumn(
                name: "Foil",
                table: "SourceProducts",
                newName: "foil");

            migrationBuilder.RenameColumn(
                name: "PurchaceUrlsId",
                table: "SealedProduct",
                newName: "PurchaseUrlsId");

            migrationBuilder.RenameIndex(
                name: "IX_SealedProduct_PurchaceUrlsId",
                table: "SealedProduct",
                newName: "IX_SealedProduct_PurchaseUrlsId");

            migrationBuilder.RenameColumn(
                name: "PurchaceUrlsId",
                table: "CardSet",
                newName: "PurchaseUrlsId");

            migrationBuilder.RenameIndex(
                name: "IX_CardSet_PurchaceUrlsId",
                table: "CardSet",
                newName: "IX_CardSet_PurchaseUrlsId");

            migrationBuilder.AlterColumn<string>(
                name: "nonfoil",
                table: "SourceProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "foil",
                table: "SourceProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "etched",
                table: "SourceProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "Set",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "SealedProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CardSetId",
                table: "Rulings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "DeckSet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SetId",
                table: "CardToken",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RebalancedPrintings",
                table: "CardSet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subsets",
                table: "CardSet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtypes",
                table: "CardSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Supertypes",
                table: "CardSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PurchaseUrls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardKingdom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomEtched = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardKingdomFoil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cardmarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tcgplayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcgplayerEtched = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseUrls", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SealedProduct_SetId",
                table: "SealedProduct",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_Rulings_CardSetId",
                table: "Rulings",
                column: "CardSetId");

            migrationBuilder.CreateIndex(
                name: "IX_DeckSet_SetId",
                table: "DeckSet",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_CardToken_SetId",
                table: "CardToken",
                column: "SetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardSet_PurchaseUrls_PurchaseUrlsId",
                table: "CardSet",
                column: "PurchaseUrlsId",
                principalTable: "PurchaseUrls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Rulings_CardSet_CardSetId",
                table: "Rulings",
                column: "CardSetId",
                principalTable: "CardSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SealedProduct_PurchaseUrls_PurchaseUrlsId",
                table: "SealedProduct",
                column: "PurchaseUrlsId",
                principalTable: "PurchaseUrls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SealedProduct_Set_SetId",
                table: "SealedProduct",
                column: "SetId",
                principalTable: "Set",
                principalColumn: "Id");
        }
    }
}
