using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("入力1");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:#,0.0}", num));
             
        }
    }
}
