using Microsoft.EntityFrameworkCore;
using SpotifyBrowser.Models;

namespace SpotifyBrowser.Data
{
    public class SpotifyBrowserContext : DbContext
    {
        public SpotifyBrowserContext (DbContextOptions<SpotifyBrowserContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}