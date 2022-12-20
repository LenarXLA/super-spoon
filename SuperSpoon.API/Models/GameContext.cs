using Microsoft.EntityFrameworkCore;

namespace SuperSpoon.API.Models
{
    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<GameItem> GameItems { get; set; } = null!;
    }
}
