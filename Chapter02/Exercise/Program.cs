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
                new Song("a", "b", 432),
                new Song("a", "b", 343),
                new Song("a", "b", 255),
            };

            PrintSongs(songs);

        }
        private static void PrintSongs(Song[] songs) {
            
        }

        private static void PrintSongs(List<Song> songs) {
            
        }
    }
}
