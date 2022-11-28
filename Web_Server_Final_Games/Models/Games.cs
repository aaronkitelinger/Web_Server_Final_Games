using System.ComponentModel.DataAnnotations;

namespace Web_Server_Final_Games.Models
{
    public class Games
    {
        [Key]
        public int gameId { get; set; }
        public string gameTitle { get; set; }

        public string gameCategory { get; set; }

        public string gameRating { get; set; }
    }
}
