using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public static class FeetConverter {

        private const double ratio = 0.3048; //定数ratioを定義

        //public  static readonly ratio = 0.3048; « 外部からもアクセスさせたい場合

        //静的メソッド
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //静的メソッド
        public static double ToMeter(double feet) {
            return feet * ratio; //ratioマジックナンバー
        }
    }
}
