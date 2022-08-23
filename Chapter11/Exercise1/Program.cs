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
            Console.WriteLine("---------------");

            Exercise1_2(file);
            Console.WriteLine("---------------");

            Exercise1_3(file);
            Console.WriteLine("---------------");

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
                                    Name = x.Element("name").Attribute("kanji").Value,
                                    Firstplayeds = x.Element("firstplayed").Value,

                                })
                                .OrderBy(x => int.Parse(x.Firstplayeds));

            foreach (var novelist in novelists) {

                Console.WriteLine("{0}({1})", novelist.Name, novelist.Firstplayeds);

            }

        }

        private static void Exercise1_3(string file) {

            var xdoc = XDocument.Load(file);
            var novelists = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = x.Element("name").Value,
                                    Tseammember = (string)x.Element("teammembers").Value,
                                })
                                .OrderByDescending(X => int.Parse(X.Tseammember)).First();
            Console.WriteLine("{0}({1}人)",
                                novelists.Name,novelists.Tseammember);

        }

        private static void Exercise1_4(string file, string newfile) {

            var element = new XElement("ballsport",
                
                    new XElement("name","サッカー",new XAttribute("kanji","蹴球")),
                    new XElement("teammembers","11"),
                    new XElement("firstplayed", "1863")
                );

            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            //保存
            xdoc.Save(newfile);
        }
    }
}
