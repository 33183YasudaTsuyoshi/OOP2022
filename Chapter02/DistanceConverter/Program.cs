using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom"{
                PrintFeetToMeterList();
            }

            
        }

        static void PrintFeetToMeterList(int start,int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft ={1:0.0000} m", feet, meter);
            }
        }

        static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} ft ={1:0.0000} ft", meter, );
            }
        }




    }
}
