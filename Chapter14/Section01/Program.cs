using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            OpenReadSample();
        }

        public static void OpenReadSample() {
            var wc = new WebClient();
            using (var stream = wc.OpenRead(@"http://gihyo.jp/book/list"))
            using (var sr = new StreamReader(stream, Encoding.UTF8)) {
                string html = sr.ReadLine();
                // 最初の2000文字だけ出力
                Console.WriteLine(html);
            }
        }
    }
}
