using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            RegionCode();
        }

        public void RegionCode() {

            List<string> codes = new List<string> { "北海道地方" ,"東北地方","関東甲信地方","東海地方","北陸地方",
                                                    "近畿地方", "中国地方","四国地方","九州北部地方","九州南部・奄美地方", "沖縄地方" };
            cbRegionCode.Items.AddRange(codes.ToArray());

            btSelect.Enabled = false;
        }

        public void Acquisition(string str) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            var areaCode = tbCode.Text;
            var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{areaCode}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbPresenter.Text = json.publishingOffice;
            tbTime.Text = json.reportDatetime.ToString();
            tbArea.Text = json.targetArea;
            tbWeatherlnfo.Text = json.text;
        }




        private void btWeatherGet_Click(object sender, EventArgs e) {

            

            if (cbRegionCode.SelectedItem != null) {

                btSelect.Enabled = true;
                string code = cbRegionCode.Text;
                switch (code) {
                    case "北海道地方":
                        cbRegion.Items.Add("宗谷地方");
                        cbRegion.Items.Add("上川・留萌地方");
                        cbRegion.Items.Add("網走・北見・紋別地方");
                        cbRegion.Items.Add("十勝地方");
                        cbRegion.Items.Add("釧路・根室地方");
                        cbRegion.Items.Add("胆振・日高地方");
                        cbRegion.Items.Add("石狩・空知・後志地方");
                        cbRegion.Items.Add("渡島・檜山地方");
                        break;
                    case "東北地方":
                        cbRegion.Items.Add("青森県");
                        cbRegion.Items.Add("岩手県");
                        cbRegion.Items.Add("宮城県");
                        cbRegion.Items.Add("秋田県");
                        cbRegion.Items.Add("山形県");
                        cbRegion.Items.Add("福島県");
                        break;
                    case "関東甲信地方":
                        cbRegion.Items.Add("茨城県");
                        cbRegion.Items.Add("栃木県");
                        cbRegion.Items.Add("群馬県");
                        cbRegion.Items.Add("埼玉県");
                        cbRegion.Items.Add("千葉県");
                        cbRegion.Items.Add("東京都");
                        cbRegion.Items.Add("神奈川県");
                        cbRegion.Items.Add("山梨県");
                        cbRegion.Items.Add("長野県");
                        break;
                    case "東海地方":
                        cbRegion.Items.Add("岐阜県");
                        cbRegion.Items.Add("静岡県");
                        cbRegion.Items.Add("愛知県");
                        cbRegion.Items.Add("三重県");
                        break;
                    case "北陸地方":
                        cbRegion.Items.Add("新潟県");
                        cbRegion.Items.Add("富山県");
                        cbRegion.Items.Add("石川県");
                        cbRegion.Items.Add("福井県");
                        break;
                    case "近畿地方":
                        cbRegion.Items.Add("滋賀県");
                        cbRegion.Items.Add("京都府");
                        cbRegion.Items.Add("大阪府");
                        cbRegion.Items.Add("兵庫県");
                        cbRegion.Items.Add("奈良県");
                        cbRegion.Items.Add("和歌山県");
                        break;
                    case "中国地方":
                        cbRegion.Items.Add("鳥取県");
                        cbRegion.Items.Add("島根県");
                        cbRegion.Items.Add("岡山県");
                        cbRegion.Items.Add("広島県");
                        break;
                    case "四国地方":
                        cbRegion.Items.Add("徳島県");
                        cbRegion.Items.Add("香川県");
                        cbRegion.Items.Add("愛媛県");
                        cbRegion.Items.Add("高知県");
                        break;
                    case "九州北部地方":
                        cbRegion.Items.Add("山口県");
                        cbRegion.Items.Add("福岡県");
                        cbRegion.Items.Add("佐賀県");
                        cbRegion.Items.Add("長崎県");
                        cbRegion.Items.Add("熊本県");
                        cbRegion.Items.Add("大分県");
                        break;
                    case "九州南部・奄美地方":
                        cbRegion.Items.Add("宮崎県");
                        cbRegion.Items.Add("奄美地方");
                        cbRegion.Items.Add("鹿児島県");
                        break;
                    case "沖縄地方":
                        cbRegion.Items.Add("沖縄本島地方");
                        cbRegion.Items.Add("大東島地方");
                        cbRegion.Items.Add("宮古島地方");
                        cbRegion.Items.Add("八重山地方");
                        break;

                }
            } else {
                btSelect.Enabled = false;
            }
        }

        private void btSelect_Click(object sender, EventArgs e) {
            switch (cbRegion.Text) {

                case "宗谷地方":
                    tbCode.Text = "011000";
                    break;

                case "上川・留萌地方":
                    tbCode.Text = "012000";
                    break;

                case "網走・北見・紋別地方":
                    tbCode.Text = "013000";
                    break;

                case "十勝地方":
                    tbCode.Text = "014030";
                    break;

                case "釧路・根室地方":
                    tbCode.Text = "014100";
                    break;

                case "胆振・日高地方":
                    tbCode.Text = "015000";
                    break;

                case "石狩・空知・後志地方":
                    tbCode.Text = "016000";
                    break;

                case "渡島・檜山地方":
                    tbCode.Text = "016000";
                    break;

                case "青森県":
                    tbCode.Text = "020000";
                    break;

                case "岩手県":
                    tbCode.Text = "030000";
                    break;

                case "宮城県":
                    tbCode.Text = "040000";
                    break;

                case "秋田県":
                    tbCode.Text = "050000";
                    break;

                case "山形県":
                    tbCode.Text = "060000";
                    break;

                case "福島県":
                    tbCode.Text = "070000";
                    break;

                case "茨城県":
                    tbCode.Text = "080000";
                    break;

                case "栃木県":
                    tbCode.Text = "090000";
                    break;

                case "群馬県":
                    tbCode.Text = "100000";
                    break;

                case "埼玉県":
                    tbWeatherlnfo.Text = "110000";
                    break;

                case "千葉県":
                    tbCode.Text = "120000";
                    break;

                case "東京都":
                    tbCode.Text = "130000";
                    break;

                case "神奈川県":
                    tbCode.Text = "140000";
                    break;

                case "山梨県":
                    tbCode.Text = "190000";
                    break;

                case "長野県":
                    tbCode.Text = "200000";
                    break;

                case "岐阜県":
                    tbCode.Text = "210000";
                    break;

                case "静岡県":
                    tbCode.Text = "220000";
                    break;

                case "愛知県":
                    tbCode.Text = "230000";
                    break;

                case "三重県":
                    tbCode.Text = "240000";
                    break;

                case "新潟県":
                    tbCode.Text = "150000";
                    break;

                case "富山県":
                    tbCode.Text = "160000";
                    break;

                case "石川県":
                    tbCode.Text = "170000";
                    break;

                case "福井県":
                    tbCode.Text = "180000";
                    break;

                case "滋賀県":
                    tbCode.Text = "250000";
                    break;

                case "京都府":
                    tbCode.Text = "260000";
                    break;

                case "大阪府":
                    tbCode.Text = "270000";
                    break;

                case "兵庫県":
                    tbCode.Text = "280000";
                    break;

                case "奈良県":
                    tbCode.Text = "290000";
                    break;

                case "和歌山県":
                    tbCode.Text = "300000";
                    break;

                case "鳥取県":
                    tbCode.Text = "310000";
                    break;

                case "島根県":
                    tbCode.Text = "320000";
                    break;

                case "岡山県":
                    tbCode.Text = "330000";
                    break;

                case "広島県":
                    tbCode.Text = "340000";
                    break;

                case "徳島県":
                    tbCode.Text = "360000";
                    break;

                case "香川県":
                    tbCode.Text = "370000";
                    break;

                case "愛媛県":
                    tbCode.Text = "380000";
                    break;

                case "高知県":
                    tbCode.Text = "390000";
                    break;

                case "山口県":
                    tbCode.Text = "350000";
                    break;

                case "福岡県":
                    tbCode.Text = "400000";
                    break;

                case "佐賀県":
                    tbCode.Text = "410000";
                    break;

                case "長崎県":
                    tbCode.Text = "420000";
                    break;

                case "熊本県":
                    tbCode.Text = "430000";
                    break;

                case "大分県":
                    tbCode.Text = "440000";
                    break;

                case "宮崎県":
                    tbCode.Text = "450000";
                    break;

                case "奄美地方":
                    tbCode.Text = "460040";
                    break;

                case "鹿児島県":
                    tbCode.Text = "460100";
                    break;

                case "沖縄本島地方":
                    tbCode.Text = "471000";
                    break;

                case "大東島地方":
                    tbCode.Text = "472000";
                    break;

                case "宮古島地方":
                    tbCode.Text = "473000";
                    break;

                case "八重山地方":
                    tbCode.Text = "474000";
                    break;
            }
            string str = tbCode.Text;
            Acquisition(str);
        }

        private void tbDelete_Click(object sender, EventArgs e) {
            tbPresenter.Text = null;
            tbTime.Text = null;
            tbArea.Text = null;
            tbWeatherlnfo.Text = null;
            cbRegion.Text = null;
            tbCode.Text = null;
            cbRegionCode.Text = null;
            cbRegion.Items.Clear();
            btSelect.Enabled = false;
        }
    }
}
