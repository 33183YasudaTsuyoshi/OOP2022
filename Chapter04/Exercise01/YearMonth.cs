using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {

        //4.1.1
        public int Year { get; private set; } //読み取り専用

        public int Month { get; private set; }　//読み取り専用

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        //4.1.2   bool型で返す場合、Isをつける
        public bool Is21Century {
            get {
                return 2001 <= Year && Year <= 2100;
            }
        }

        //4.1.3
        public YearMonth AddOneMonth() {
            if (Month == 12) {
                return new YearMonth(this.Year + 1,1);
            }
            else {
                return new YearMonth(this.Year,this.Month + 1);
            }
        }

        //4.1.4
        public override string ToString() {
            return $"{Year}年{Month}月";

        }



    }
}
