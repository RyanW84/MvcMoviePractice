using Microsoft.EntityFrameworkCore;

namespace MvcMoviePractice.Data
{
    public class MvcMoviePracticeContext(DbContextOptions<MvcMoviePracticeContext> options) : DbContext(options)
    {
        public DbSet<MvcMoviePractice.Models.Movie> Movie { get; set; } = default!;
    }
}
