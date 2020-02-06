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

        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<Song>().ToTable("Song");
        }
    }
}