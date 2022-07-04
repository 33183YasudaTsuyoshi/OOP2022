using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "sample.xml";

            Exercise1_1(file);
            Console.WriteLine();

            Exercise1_2(file);
            Console.WriteLine();

            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load(file);
            var novelists = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    teammember = (string)x.Element("teammembers"),
                                });

            foreach (var novelist in novelists) {

                Console.WriteLine("{0} {1}",
                                   novelist.Name, novelist.teammember);

            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load(file);
            var novelists = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name").Attribute("kanji"),
                                    firstplayeds = (string)x.Element("firstplayed"),

                                });

            foreach (var novelist in novelists.OrderBy(x => x.firstplayeds)) {

                Console.WriteLine("{0}({1})", novelist.Name, novelist.firstplayeds);

            }

        }

        private static void Exercise1_3(string file) {

            var xdoc = XDocument.Load(file);
            var novelists = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    teammember = (string)x.Element("teammembers"),
                                });
            Console.WriteLine();
            


        }

        private static void Exercise1_4(string file, string newfile) {
            
        }
    }
}
