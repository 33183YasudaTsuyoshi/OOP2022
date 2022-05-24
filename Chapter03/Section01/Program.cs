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

            Console.WriteLine("-----------");

            var name = list.Find(s => s.Length == 6); //一つ6文字を出力
            Console.WriteLine(name);

            Console.WriteLine("-----------");

            /* var names = list.FindAll(s => s.Length <= 5); //5文字以下すべて
             foreach (var s in names) {
                 Console.WriteLine(s);
             }*/

            //条件と一致するすべての要素を取り出す
            var names = list.FindAll(s => s.Length <= 5);
            names.ForEach(s => Console.WriteLine(s));

            Console.WriteLine("-----------");

            //条件と一致するすべての要素をリストから削除
            var removedCount = list.RemoveAll(s => s.Contains("on"));
            Console.WriteLine(removedCount);

            Console.WriteLine("-----------");
            
            list.ForEach(s => Console.WriteLine(s));

            Console.WriteLine("-----------");

            //リスト内の要素を小文字に変換
            var LowerList = list.ConvertAll(s => s.ToLower());
            LowerList.ForEach(s => Console.WriteLine(s));
        }
    }
}
