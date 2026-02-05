using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class updatedMtgJson2_1_26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_Translations_TranslationsId",
                table: "Set");

            migrationBuilder.AddColumn<string>(
                name: "Etched",
                table: "SourceProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Set",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TranslationsId",
                table: "Set",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Translations_TranslationsId",
                table: "Set",
                column: "TranslationsId",
                principalTable: "Translations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_Translations_TranslationsId",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "Etched",
                table: "SourceProducts");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Set",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TranslationsId",
                table: "Set",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Translations_TranslationsId",
                table: "Set",
                column: "TranslationsId",
                principalTable: "Translations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
