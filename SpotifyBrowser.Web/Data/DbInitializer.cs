using SpotifyBrowser.Models;
using System;
using System.Linq;

namespace SpotifyBrowser.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SpotifyBrowserContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Songs.
            if (context.Songs.Any())
            {
                return;
            }

            var artists = new Artist[]
            {
                new Artist { Name="Third Eye Blind" },
                new Artist { Name="Dayshell" },
                new Artist { Name="The Band CAMINO" },
                new Artist { Name="Bring Me The Horizon" },
            };

            foreach (var artist in artists)
            {
                context.Artists.Add(artist);
            }
            context.SaveChanges();

            var songs = new Song[]
            {
                new Song { Title="Sharp Knife", Runtime="4:28", ArtistId=1 },
                new Song { Title="My Hit and Run", Runtime="4:21", ArtistId=1 },
                new Song { Title="Car Sick", Runtime="3:16", ArtistId=2 },
                new Song { Title="Haunted", Runtime="4:23", ArtistId=3 },
                new Song { Title="sugar honey ice & tea", Runtime="4:22", ArtistId=4 },
            };

            foreach (var song in songs)
            {
                context.Songs.Add(song);
            }
            context.SaveChanges();
        }
    }
}