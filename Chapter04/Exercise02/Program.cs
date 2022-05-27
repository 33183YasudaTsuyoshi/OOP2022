
using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {


            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1982,1),
                new YearMonth(1990,4),
                new YearMonth(2000,3),
                new YearMonth(2010,9),
                new YearMonth(2020,5),//(P103)
             };


            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("-----------------");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("-----------------");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("-----------------");

            Exercise2_6(ymCollection);
            Console.WriteLine("-----------------");
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {

            foreach (var ym in ymCollection.Where( ym => DateTime.IsLeapYear(ym.Year))) {
                
                Console.WriteLine(ym);
            }

            var date = ymCollection.Max(ym => ym.Month);
            Console.WriteLine(date);
        }

        //4.2.3
        //最初に見つかった21世紀のオブジェクトを返す
        //見つからなかった場合nullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century == true) {
                    return ym;
                }
            }
            return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {

            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {

            var ym = FindFirst21C(ymCollection);
            if (ym != null) {
                Console.WriteLine(ym);
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }

        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth());
            foreach (var ym in array) {
                Console.WriteLine(ym);

            }
        }
    }
}
