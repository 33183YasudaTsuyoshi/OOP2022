using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        public delegate bool Judgement(int value); //デリゲートの宣言

        static void Main(string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            var exissts = list.Exists(s => s[0] == 'A');//最初の文字がAの時
            Console.WriteLine(exissts);

            var name = list.Find(s => s.Length == 6); //一つ6文字を出力
            Console.WriteLine(name);

           /* var names = list.FindAll(s => s.Length <= 5); //5文字以下すべて
            foreach (var s in names) {
                Console.WriteLine(s);
            }*/

            var names = list.FindAll(s => s.Length <= 5);
            names.ForEach(s => Console.WriteLine(s));


        }
    }
}
