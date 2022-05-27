using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            

            Exercise3_1(text);
            Console.WriteLine("--------------");

            Exercise3_2(text);
            Console.WriteLine("--------------");

            Exercise3_3(text);
            Console.WriteLine("--------------");

            Exercise3_4(text);
            Console.WriteLine("--------------");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {

            Console.WriteLine(text.Where(c => c == ' ').Count());


        }

        private static void Exercise3_2(string text) {
           var str = text.Replace("big","small");
            Console.WriteLine(str);
        }

        private static void Exercise3_3(string text) {
            Console.WriteLine(text.Trim().Split(' ').Count());
        }

        private static void Exercise3_4(string text) {

            var s = text.Split(' ').Where(word => word.Length <= 4);
            foreach (var item in s) {
                Console.WriteLine(item);
            }

            
        }

        private static void Exercise3_5(string text) {

            var s = text.Split(' ');
            var sb = new StringBuilder();

            foreach (var str1 in s) {
                sb.Append(str1);
            }
            var b = sb.ToString();
            Console.WriteLine(b);
        }
    }
}
