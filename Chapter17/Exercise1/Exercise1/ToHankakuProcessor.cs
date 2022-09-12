using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using TextFileProcessor;
using Microsoft.VisualBasic;




namespace Exercise1 {
    class ToHankakuProcessor : TextProcessor {



        protected override void Execute(string line) {


            string s = Regex.Replace(line, "[０-９]", p => ((char)(p.Value[0] -'０'+ '0')).ToString());
            Console.WriteLine(s);

        }

    }
}
