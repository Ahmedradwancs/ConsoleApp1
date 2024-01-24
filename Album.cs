using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Album
    {
        // Input Fields
        private String albumName;
        private String artistName;
        private int numOfTracks;



        // Read album name from the user
        public void ReadAlbumName()
        {
            Console.WriteLine("What is the name of your favorit music album? ");
            albumName = Console.ReadLine();
        }

        // Read artist name from the user
        public void ReadArtistName()
        {
           Console.WriteLine($"What is the name of the Artist or Band for {albumName}? ");
            artistName = Console.ReadLine();
        }

        // Read tracks from the user
        public void ReadTracks()
        {
            Console.WriteLine($"How many tracks does {albumName} have? ");
            numOfTracks = Convert.ToInt32(Console.ReadLine());
        }

        // Display the album info
        public void DisplayAlbumInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Album name: {this.albumName}");
            Console.WriteLine($"Artist/Band: {this.artistName}");
            Console.WriteLine($"Number of tracks: {this.numOfTracks}");
            Console.WriteLine("Enjoy listening!");
            Console.WriteLine();
        }

        // Create the start method
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();
            ReadAlbumName();
            ReadArtistName();
            ReadTracks();
            DisplayAlbumInfo();
            
        }   
    }
}
