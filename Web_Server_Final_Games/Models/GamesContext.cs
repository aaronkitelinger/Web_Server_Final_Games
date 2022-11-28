
using Microsoft.EntityFrameworkCore;

namespace Web_Server_Final_Games.Models
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        { }

        public DbSet<Games> Games { get; set; }

    }
}
