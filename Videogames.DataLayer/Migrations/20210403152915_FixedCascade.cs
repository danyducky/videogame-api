using Microsoft.EntityFrameworkCore.Migrations;

namespace Videogames.DataLayer.Migrations
{
    public partial class FixedCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_videogame_developer_DeveloperId",
                table: "videogame");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "videogame",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_videogame_developer_DeveloperId",
                table: "videogame",
                column: "DeveloperId",
                principalTable: "developer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_videogame_developer_DeveloperId",
                table: "videogame");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "videogame",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_videogame_developer_DeveloperId",
                table: "videogame",
                column: "DeveloperId",
                principalTable: "developer",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
