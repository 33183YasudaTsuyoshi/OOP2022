using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region
            Exercise1_1(numbers);
            Console.WriteLine("------------------");

            Exercise1_2(numbers);
            Console.WriteLine("------------------");

            Exercise1_3(numbers);
            Console.WriteLine("------------------");

            Exercise1_4(numbers);
            Console.WriteLine("------------------");

            Exercise1_5(numbers);
            #endregion
        }
        private static void Exercise1_1(int[] numbers) {
            //最大値
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        private static void Exercise1_2(int[] numbers) {
            //最後から２つの要素取り出し
            foreach (var n in numbers.Skip(numbers.Length - 2)) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            //数値を文字列へ変換(Select)
            var strs = numbers.Select(n => n.ToString());
            foreach (var s in strs) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            foreach (var s in numbers.OrderBy(x => x).Take(3)) {
                Console.WriteLine(s);
            }

        }

        private static void Exercise1_5(int[] numbers) {
            //重複を排除し１０より大きい数がいくつあるか
            var num = numbers.Distinct().Count(x => x <= 10);
            Console.WriteLine(num);

        }
    }
}
