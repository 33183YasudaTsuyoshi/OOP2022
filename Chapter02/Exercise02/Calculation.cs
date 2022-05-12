using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Calculation {

        private int inch;
        private const double meter = 0.0254;

        public static double FromMeter(double inch) {

            return inch * meter;

        }
        
    }
}
