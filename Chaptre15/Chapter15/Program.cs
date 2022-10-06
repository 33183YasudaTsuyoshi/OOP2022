using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();
            int year;

            Console.WriteLine("出力したい西暦を入力(終了：-1)");
            year = int.Parse(Console.ReadLine());

            while (year != -1) {
                
                years.Add(year);
                year = int.Parse(Console.ReadLine());
              
            }

            Console.Write("昇順:1 降順:2 => ");
            int select = int.Parse(Console.ReadLine());
            if (select == 1) {
                var books = Library.Books
                       .Where(b => years.Contains(b.PublishedYear)).OrderBy(b => b.PublishedYear);
                foreach (var book in books) {
                    Console.WriteLine(book);
                }
            }
            if (select == 2) {
                var books = Library.Books
                       .Where(b => years.Contains(b.PublishedYear)).OrderByDescending(b => b.PublishedYear);
                foreach (var book in books) {
                    Console.WriteLine(book);
                }
            }

            var groups = Library.Books
                                .Where(b => years.Contains(b.PublishedYear)).GroupBy(b => b.PublishedYear)
                                .OrderBy(g => g.Key);
            foreach (var g in groups) {
                Console.WriteLine("");
                Console.WriteLine($"{g.Key}年");
                foreach (var book in g) {
                    Console.WriteLine($" {book}");
                }
            }
        }
    }
}
