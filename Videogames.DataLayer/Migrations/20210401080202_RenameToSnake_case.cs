using Microsoft.EntityFrameworkCore.Migrations;

namespace Videogames.DataLayer.Migrations
{
    public partial class RenameToSnake_case : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreVideogame_Genres_GenresId",
                table: "GenreVideogame");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreVideogame_Videogames_VideogamesId",
                table: "GenreVideogame");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Developers_DeveloperId",
                table: "Videogames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videogames",
                table: "Videogames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreVideogame",
                table: "GenreVideogame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.RenameTable(
                name: "Videogames",
                newName: "videogame");

            migrationBuilder.RenameTable(
                name: "GenreVideogame",
                newName: "genre_videogame");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "genre");

            migrationBuilder.RenameTable(
                name: "Developers",
                newName: "developer");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_DeveloperId",
                table: "videogame",
                newName: "IX_videogame_DeveloperId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreVideogame_VideogamesId",
                table: "genre_videogame",
                newName: "IX_genre_videogame_VideogamesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_videogame",
                table: "videogame",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genre_videogame",
                table: "genre_videogame",
                columns: new[] { "GenresId", "VideogamesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_genre",
                table: "genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_developer",
                table: "developer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_genre_videogame_genre_GenresId",
                table: "genre_videogame",
                column: "GenresId",
                principalTable: "genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genre_videogame_videogame_VideogamesId",
                table: "genre_videogame",
                column: "VideogamesId",
                principalTable: "videogame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_genre_videogame_genre_GenresId",
                table: "genre_videogame");

            migrationBuilder.DropForeignKey(
                name: "FK_genre_videogame_videogame_VideogamesId",
                table: "genre_videogame");

            migrationBuilder.DropForeignKey(
                name: "FK_videogame_developer_DeveloperId",
                table: "videogame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_videogame",
                table: "videogame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genre_videogame",
                table: "genre_videogame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genre",
                table: "genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_developer",
                table: "developer");

            migrationBuilder.RenameTable(
                name: "videogame",
                newName: "Videogames");

            migrationBuilder.RenameTable(
                name: "genre_videogame",
                newName: "GenreVideogame");

            migrationBuilder.RenameTable(
                name: "genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "developer",
                newName: "Developers");

            migrationBuilder.RenameIndex(
                name: "IX_videogame_DeveloperId",
                table: "Videogames",
                newName: "IX_Videogames_DeveloperId");

            migrationBuilder.RenameIndex(
                name: "IX_genre_videogame_VideogamesId",
                table: "GenreVideogame",
                newName: "IX_GenreVideogame_VideogamesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videogames",
                table: "Videogames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreVideogame",
                table: "GenreVideogame",
                columns: new[] { "GenresId", "VideogamesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreVideogame_Genres_GenresId",
                table: "GenreVideogame",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreVideogame_Videogames_VideogamesId",
                table: "GenreVideogame",
                column: "VideogamesId",
                principalTable: "Videogames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Developers_DeveloperId",
                table: "Videogames",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
