using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            PrintMeterToInList(1, 10);

        }

        private static void PrintMeterToInList(int start, int stop) {

            for (int inch = start; inch <= stop; inch++) {
                double meter = Calculation.FromMeter(inch);
                Console.WriteLine("{0}in  ={1:0.0000} m", inch, meter);
            }

        }
    }
}
