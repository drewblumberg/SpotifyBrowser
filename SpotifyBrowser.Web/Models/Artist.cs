using System;
using System.Collections.Generic;

namespace SpotifyBrowser.Models {
    public class Artist {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public virtual ICollection<Song> Songs { get; set; }
    }
}