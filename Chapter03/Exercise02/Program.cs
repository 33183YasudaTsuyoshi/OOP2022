using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var names = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Exercise2_1(names);
            Console.WriteLine("---------");

            Exercise2_2(names);
            Console.WriteLine("---------");

            Exercise2_3(names);
            Console.WriteLine("---------");

            Exercise2_4(names);
            Console.WriteLine("---------");
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                var line = Console.ReadLine();
                //文字列がnullかどうかをチェックし、さらにnullでない場合は、空の文字列ではないかをチェックします。
                if (string.IsNullOrEmpty(line)) 
                    break;

                //Listを先頭から検索して最初に一致する要素のインデックス番号を返します
                var index = names.FindIndex(s => s == line);
                    Console.WriteLine(index);

                
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {

            //Containsメソッドは文字列内に指定の文字、文字列が含まれるか確認することができます
            int count = names.Count(n => n.Contains("o"));
            Console.WriteLine(count);
 
            
        }

        private static void Exercise2_3(List<string> names) {
            var selected = names.Where(s => s.Contains("o")).ToArray();//配列として抽出

            foreach (var name in selected) {
                Console.WriteLine(name);
            }
            
        }

        private static void Exercise2_4(List<string> names) {
            //StartsWithメソッドで始まりの文字列を判定する方法,文字数で返す
            var selected = names.Where(s => s.StartsWith("B")).Select (s=>s.Length);

            foreach (var name in selected) {
                Console.WriteLine(name);
            }
        }
    }
}
