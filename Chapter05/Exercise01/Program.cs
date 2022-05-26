using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("入力1");
            var str1 = Console.ReadLine();
            Console.WriteLine("入力2");
            var str2 = Console.ReadLine();

            var result = string.Compare(str1, str2, true);

            if (result == 0) {
                Console.WriteLine("一致しています");
            } else {
                Console.WriteLine("一致していません");
            }

        }
    }
}
