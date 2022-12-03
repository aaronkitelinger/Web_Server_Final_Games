using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Server_Final_Games.Migrations
{
    public partial class Games : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    gameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gameTitle = table.Column<string>(nullable: false),
                    gameCategory = table.Column<string>(nullable: false),
                    gameRating = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.gameId);
                });
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "gameTitle", "gameCategory", "gameRating" },
                values: new object[,]
                {
                    { "Elden Ring", "Video Game", "M17"},
                    { "Outer Wilds", "Video Game", "E" },
                    { "Just Dance", "Video Game", "E"},
                    { "EverDell", "TTRPG", "E" },
                    { "DnD", "TTRPG", "E" },
                    { "Cards Against Humanity", "Card Game", "NSFW" },
                    { "Magic the Gathering", "Card Game", "E"}
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
