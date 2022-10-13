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
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.Where(b => b.Price == max);
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
            var books = Library.Books.OrderByDescending(b => b.PublishedYear)
                               .ThenByDescending(b => b.Price)
                               .Join(Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => new {
                                        Titile = book.Title,
                                        Category = category.Name,
                                        PublishedYear = book.PublishedYear,
                                        Price = book.Price,
                                        Title = book.Title,
                                        CategoryName = category.Name
                                    }
                                );
            foreach (var book in books) {
                Console.WriteLine($"{book.PublishedYear}年　{book.Price}円　{book.Title}({book.CategoryName})");
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books.Where(b => b.PublishedYear == 2016)
                               .Join(Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => category.Name).Distinct(); 
                                                          
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
            var query = Library.Books
                               .Join(Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => new {
                                        book.Title,
                                        book.PublishedYear,
                                        book.Price,
                                        CategoryName = category.Name
                                    })
                                .GroupBy(x => x.CategoryName)
                                .OrderBy(x => x.Key);

            foreach (var group in query) {
                Console.WriteLine("#{0}",group.Key);
                foreach (var item in group) {
                    Console.WriteLine(" {0}",item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var categoryId = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books
                                .Where(b => b.CategoryId == categoryId)
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(b => b.Key);
                
            foreach (var group in groups) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var book in group) {
                    Console.WriteLine(" {0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories
                               .GroupJoin(Library.Books,
                                    c => c.Id,
                                    b => b.CategoryId,
                                    (c, b) => new { 
                                        CategoryName = c.Name,
                                        Count = b.Count()
                                    })
                               .Where(x => x.Count >= 4);

            foreach (var category in query) {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
