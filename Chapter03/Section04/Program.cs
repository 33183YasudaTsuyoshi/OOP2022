using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //IEnumerableインターフェイス    //メソッドチェーン(繋げる)  
            //Where拡張メソッド、Slect拡張メソッド

            /*IEnumerable<string> query = names.Where(s => s.Contains("on")).Select(s =>s.ToUpper());
            foreach (string s in query) {
                Console.WriteLine(s);
            }*/

            //文字数を出力
            IEnumerable<int> query = names.Select(s => s.Length);
            foreach (int n in query) {
                Console.WriteLine("{0}",n);
            }
        }
    }
}
