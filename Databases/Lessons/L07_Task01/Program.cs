using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 context = new Model1();

            Console.WriteLine("\nArtists");
            foreach (var item in context.Artists)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAlbums");
            foreach (var item in context.Albums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTracks");
            foreach (var item in context.Tracks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPlaylists");
            foreach (var item in context.Playlists)
            {
                Console.WriteLine(item);
            }
        }
    }
}
