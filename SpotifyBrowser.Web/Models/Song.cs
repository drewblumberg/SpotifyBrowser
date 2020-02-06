#nullable enable

using System;
using System.Collections.Generic;

namespace SpotifyBrowser.Models {
    public class Song {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? AlbumArt { get; set; }
        public string Runtime { get; set; }
        public int ArtistId { get; set; }

        // Relationships
        public virtual Artist Artist { get; set; }
    }
}