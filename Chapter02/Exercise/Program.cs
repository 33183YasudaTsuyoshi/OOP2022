using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            /*List<Song> songs = new List<Song>();

            var songs1 = new Song("a", "b", 5);
            songs.Add(songs1);*/

            var songs = new Song[] {
                new Song("a", "b", 594),
                new Song("c", "d", 432),
                new Song("e", "f", 343),
                new Song("g", "h", 255),
            };

            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2:m\\:ss}",
                    song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
