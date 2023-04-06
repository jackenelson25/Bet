using Microsoft.EntityFrameworkCore;

namespace BetApp.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }
        public DbSet<MovieData> Movies { get; set; }
    }
}
