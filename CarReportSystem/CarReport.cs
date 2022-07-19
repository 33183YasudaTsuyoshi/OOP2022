using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReport {
		[System.ComponentModel.DisplayName("日付")]
        public DateTime Date { get; set; }  //日付
		[System.ComponentModel.DisplayName("記録者")]
        public string Auther { get; set; }  //記録者
        [System.ComponentModel.DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }   //メーカー
        [System.ComponentModel.DisplayName("車名")]
        public string CarName { get; set; } //車名
        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; } //レポート
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; } //画像
        public string Group {
            get {
                string groups = "";
                foreach (MakerGroup group in listGroup) {
                    groups += "[" + group + "]";
                }
                return groups;
            }
        }




        public List<MakerGroup> listGroup { get; set; }

        //メーカー
        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他,
        }
    }
}
