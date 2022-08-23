using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Section02
{
    public class NovelCollection
    {
        public Novel[] Novels { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //SerializeToFile();
            Deserialize();
        }

        //List 12-6
        public static void SerializeToFile()
        {
            //var novel = new Novel
            //{
            //    Author = "ジェイムズ・P・ホーガン",
            //    Title = "星を継ぐもの",
            //    Published = 1977,
            //};

            var novels = new Novel[] {
               new Novel {
                  Author = "ジェイムズ・P・ホーガン",
                  Title = "星を継ぐもの",
                  Published = 1977,
               },
               new Novel {
                  Author = "H・G・ウェルズ",
                  Title = "タイム・マシン",
                  Published = 1895,
               },
            };

            var novelCollection = new NovelCollection
            {
                Novels = novels
            };


            using (var writer = XmlWriter.Create("novels.xml"))
            {
                var serializer = new XmlSerializer(novelCollection.GetType());
                serializer.Serialize(writer, novelCollection);
            }

            Display("novels.xml");

        }

        //List 12-7
        //逆シリアル化
        public static void Deserialize()
        {
            using (var reader = XmlReader.Create("novels.xml"))
            {
                var serializer = new XmlSerializer(typeof(NovelCollection));
                var novels = serializer.Deserialize(reader) as NovelCollection;
                // 以下、内容を確認するコード
                //Console.WriteLine(novel);
                foreach (var novel in novels.Novels)
                {
                    Console.WriteLine(novel);
                }
            }
        }

        //XMLファイルの中身表示用
        private static void Display(string filename)
        {
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
                Console.WriteLine(line);

        }

    }
}
