using Microsoft.EntityFrameworkCore;
using HelloAspNetCore.Models;

namespace HelloAspNetCore.Data
{
    public class HelloAspNetCoreMovieContext : DbContext
    {
        public HelloAspNetCoreMovieContext(DbContextOptions<HelloAspNetCoreMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}