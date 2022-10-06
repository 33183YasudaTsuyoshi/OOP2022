using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {

            //InsertBooks(); 
            //AddAuthors();
            //AddBooks();

            /*var books = Exercise_02();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}{book.Author.Name}");
            }*/

            /*var books = Exercise_03();
            foreach (var book in books) {
                Console.WriteLine(book.Title);
            }*/

            /*var books = Exercise_04();
            foreach (var book in books) {
                Console.WriteLine(book.PublishedYear);
            }*/

            var authers = Exercise_05_1();
            foreach (var auther in authers) {
                Console.WriteLine($"{auther.Name} {auther.Birthday.ToString("yyyy/MM")}");
                var books = Exercise_05_2(auther.Name);
                foreach (var book in books) {
                    Console.WriteLine($"  {book.Title} {book.PublishedYear}");
                }
                Console.WriteLine();
            }

            /*var books = GetBooks();
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}{book.Author.Name}");
            }*/
        }

        //List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {

                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                var book3 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book3);

                var book4 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book4);

                var book5 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = new Author {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book5);

                var book6 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = new Author {
                        Birthday = new DateTime(1896, 8, 27),
                        Gender = "M",
                        Name = "宮沢賢治",
                    }
                };
                db.Books.Add(book6);

                db.SaveChanges(); //データベースの更新
            }
        }

        static IEnumerable<Book> Exercise_03() {
            using (var db = new BooksDbContext()) {
                return db.Books
                    .Where(book => book.Title.Length == db.Books.Max(x => x.Title.Length))
                    .ToList();
            }
        }

        static IEnumerable<Book> Exercise_02() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author)).ToList();
            }
        }

        static IEnumerable<Book> Exercise_04() {
            using (var db = new BooksDbContext()) {
                return db.Books.OrderBy(book => book.PublishedYear).Take(3).ToList();
            }
        }

        static IEnumerable<Author> Exercise_05_1() {
            using (var db = new BooksDbContext()) {
                return db.Authors.OrderByDescending(a => a.Birthday).ToList();
            }
        }

        static IEnumerable<Book> Exercise_05_2(string name) {
            using (var db = new BooksDbContext()) {
                return db.Books
                    .Where(book => book.Author.Name == name)
                    .ToList();
            }
        }

        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);

                var author3 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author3);

                var author4 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author4);
                db.SaveChanges();
            }
        }

        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
    }
}
