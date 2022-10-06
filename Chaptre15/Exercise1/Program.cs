using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }
        
        private static void Exercise1_2() {
            var books = Library.Books.Max(b => b.Price);
            var book = Library.Books.Where(b => b.Price == books);
            foreach (var b in book) {
                Console.WriteLine(b);
            }
        }

        private static void Exercise1_3() {
            var books = Library.Books.GroupBy(b => b.PublishedYear)
                                     .OrderBy(o => o.Key);
            foreach (var book in books) {
                Console.WriteLine($"{book.Key}年 {book.Count()}冊");
            }
            
        }

        private static void Exercise1_4() {
        }

        private static void Exercise1_5() {
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
