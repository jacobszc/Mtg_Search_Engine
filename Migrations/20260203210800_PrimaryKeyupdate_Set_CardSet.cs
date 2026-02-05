using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class PrimaryKeyupdate_Set_CardSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForeignData_CardSet_CardSetId",
                table: "ForeignData");

            migrationBuilder.DropIndex(
                name: "IX_ForeignData_CardSetId",
                table: "ForeignData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardSet",
                table: "CardSet");

            migrationBuilder.DropColumn(
                name: "CardSetId",
                table: "ForeignData");

            migrationBuilder.AddColumn<string>(
                name: "CardSetUuid",
                table: "ForeignData",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Uuid",
                table: "CardSet",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CardSet",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardSet",
                table: "CardSet",
                column: "Uuid");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignData_CardSetUuid",
                table: "ForeignData",
                column: "CardSetUuid");

            migrationBuilder.AddForeignKey(
                name: "FK_ForeignData_CardSet_CardSetUuid",
                table: "ForeignData",
                column: "CardSetUuid",
                principalTable: "CardSet",
                principalColumn: "Uuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForeignData_CardSet_CardSetUuid",
                table: "ForeignData");

            migrationBuilder.DropIndex(
                name: "IX_ForeignData_CardSetUuid",
                table: "ForeignData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardSet",
                table: "CardSet");

            migrationBuilder.DropColumn(
                name: "CardSetUuid",
                table: "ForeignData");

            migrationBuilder.AddColumn<int>(
                name: "CardSetId",
                table: "ForeignData",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CardSet",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Uuid",
                table: "CardSet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardSet",
                table: "CardSet",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignData_CardSetId",
                table: "ForeignData",
                column: "CardSetId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForeignData_CardSet_CardSetId",
                table: "ForeignData",
                column: "CardSetId",
                principalTable: "CardSet",
                principalColumn: "Id");
        }
    }
}
