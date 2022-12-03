using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Server_Final_Games.Models
{
    public class GamesConfig : IEntityTypeConfiguration<Games>
    {
        public void Configure(EntityTypeBuilder<Games> entity)
        {
            entity.HasData(
                new Games { gameId = 1, gameTitle = "Elden Ring", gameCategory = "Video Game", gameRating = "M17" },
                new Games { gameId = 2, gameTitle = "Outer Wilds", gameCategory = "Video Game", gameRating = "E" },
                new Games { gameId = 3, gameTitle = "Just Dance", gameCategory = "Video Game", gameRating = "E" },
                new Games { gameId = 4, gameTitle = "EverDell", gameCategory = "TTRPG", gameRating = "E" },
                new Games { gameId = 5, gameTitle = "DnD", gameCategory = "TTRPG", gameRating = "E" },
                new Games { gameId = 6, gameTitle = "Cards Against Humanity", gameCategory = "Card Game", gameRating = "NSFW" },
                new Games { gameId = 7, gameTitle = "Magic the Gathering", gameCategory = "Card Game", gameRating = "E" }
                );
        }
    }
}
