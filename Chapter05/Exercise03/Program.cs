﻿using System;
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
            if (String.IsNullOrWhiteSpace(text)) {
                Console.WriteLine("空白ではない");
            } else {
                Console.WriteLine("空白");
            }
                
            
        }

        private static void Exercise3_2(string text) {
           var str = text.Replace("big","small");
            Console.WriteLine(str);
        }

        private static void Exercise3_3(object text) {
            
        }

        private static void Exercise3_4(object text) {
            
        }

        private static void Exercise3_5(object text) {
            
        }
    }
}