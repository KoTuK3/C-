using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace L07_Task01
{
    public class Model1 : DbContext
    {
        
        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer(new Initializer());
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }

    }

    public class Artist
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Name} {Surname} - {Country}";
        }
    }

    public class Album
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public DateTime Date { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Name} - {Artist} ({Date}) {Genre}";
        }
    }

    public class Track
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Album Album { get; set; }
        public int Duration { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Name} - {Album} {Duration}s";
        }
    }

    public class Playlist
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            string res = $"{Id}. {Name} - {Category}";

            foreach (var item in Tracks)
            {
                res += item;
            }

            return res;
        }
    }
}