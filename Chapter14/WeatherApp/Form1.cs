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

        string Code;

        public Form1() {
            InitializeComponent();
            RegionCode();
        }

        public void Acquisition(string str) {
           
            try {

                //天気情報取得
                var wc = new WebClient() {
                    Encoding = Encoding.UTF8
                };
                var areaCode = str;
                var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{areaCode}.json");
                var dString1 = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/forecast/{areaCode}.json");
                var json = JsonConvert.DeserializeObject<Rootobject>(dString);
                var json1 = JsonConvert.DeserializeObject<Class1[]>(dString1);

                //報告日時
                tbTime.Text = json1[0].reportDatetime.ToString();
                tbWeatherlnfo.Text = json.text;

                //天気画像
                string weather = json1[0].timeSeries[0].areas[0].weatherCodes[0];
                pbWeather.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{weather}.png";
                string weather1 = json1[0].timeSeries[0].areas[0].weatherCodes[1];
                pbWeather1.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{weather1}.png";
                string weather2 = json1[0].timeSeries[0].areas[0].weatherCodes[2];
                pbWeather2.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{weather2}.png";

                //天気状況
                textBox1.Text = json1[0].timeSeries[0].areas[0].weathers[0];
                textBox2.Text = json1[0].timeSeries[0].areas[0].weathers[1];
                textBox3.Text = json1[0].timeSeries[0].areas[0].weathers[2];

                // 最高気温　最低気温
                tbTemperatureMin.Text = json1[1].tempAverage.areas[0].min;
                tbTemperatureMax.Text = json1[1].tempAverage.areas[0].max;

                //天気画像　時刻
                label10.Text = json1[0].timeSeries[0].timeDefines[0].ToString();
                label11.Text = json1[0].timeSeries[0].timeDefines[1].ToString();
                label12.Text = json1[0].timeSeries[0].timeDefines[2].ToString();

                btWeatherGet.Enabled = false;
                btSelect.Enabled = false;

                this.tbTemperatureMax.ForeColor = Color.Red;
                this.tbTemperatureMin.ForeColor = Color.Blue;

            }
            catch (Exception) {
                MessageBox.Show("ネットワークに接続されていません");
            }            
        }

        public void RegionCode() {

            List<string> codes = new List<string> { "北海道地方" ,"東北地方","関東甲信地方","東海地方","北陸地方",
                                                    "近畿地方", "中国地方","四国地方","九州北部地方","九州南部・奄美地方", "沖縄地方" };
            cbRegionCode.Items.AddRange(codes.ToArray());

            btSelect.Enabled = false;
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
            btWeatherGet.Enabled = false;
        }

        private void btSelect_Click(object sender, EventArgs e) {
           
            switch (cbRegion.Text) {

                case "宗谷地方":
                    Code = "011000";
                    break;

                case "上川・留萌地方":
                    Code = "012000";
                    break;

                case "網走・北見・紋別地方":
                    Code = "013000";
                    break;

                case "十勝地方":
                    Code = "014030";
                    break;

                case "釧路・根室地方":
                    Code = "014100";
                    break;

                case "胆振・日高地方":
                    Code = "015000";
                    break;

                case "石狩・空知・後志地方":
                    Code = "016000";
                    break;

                case "渡島・檜山地方":
                    Code = "016000";
                    break;

                case "青森県":
                    Code = "020000";
                    break;

                case "岩手県":
                    Code = "030000";
                    break;

                case "宮城県":
                    Code = "040000";
                    break;

                case "秋田県":
                    Code = "050000";
                    break;

                case "山形県":
                    Code = "060000";
                    break;

                case "福島県":
                    Code = "070000";
                    break;

                case "茨城県":
                    Code = "080000";
                    break;

                case "栃木県":
                    Code = "090000";
                    break;

                case "群馬県":
                    Code = "100000";
                    break;

                case "埼玉県":
                    Code = "110000";
                    break;

                case "千葉県":
                    Code = "120000";
                    break;

                case "東京都":
                    Code = "130000";
                    break;

                case "神奈川県":
                    Code = "140000";
                    break;

                case "山梨県":
                    Code = "190000";
                    break;

                case "長野県":
                    Code = "200000";
                    break;

                case "岐阜県":
                    Code = "210000";
                    break;

                case "静岡県":
                    Code = "220000";
                    break;

                case "愛知県":
                    Code = "230000";
                    break;

                case "三重県":
                    Code = "240000";
                    break;

                case "新潟県":
                    Code = "150000";
                    break;

                case "富山県":
                    Code = "160000";
                    break;

                case "石川県":
                    Code = "170000";
                    break;

                case "福井県":
                    Code = "180000";
                    break;

                case "滋賀県":
                    Code = "250000";
                    break;

                case "京都府":
                    Code = "260000";
                    break;

                case "大阪府":
                    Code = "270000";
                    break;

                case "兵庫県":
                    Code = "280000";
                    break;

                case "奈良県":
                    Code = "290000";
                    break;

                case "和歌山県":
                    Code = "300000";
                    break;

                case "鳥取県":
                    Code = "310000";
                    break;

                case "島根県":
                    Code = "320000";
                    break;

                case "岡山県":
                    Code = "330000";
                    break;

                case "広島県":
                    Code = "340000";
                    break;

                case "徳島県":
                    Code = "360000";
                    break;

                case "香川県":
                    Code = "370000";
                    break;

                case "愛媛県":
                    Code = "380000";
                    break;

                case "高知県":
                    Code = "390000";
                    break;

                case "山口県":
                    Code = "350000";
                    break;

                case "福岡県":
                    Code = "400000";
                    break;

                case "佐賀県":
                    Code = "410000";
                    break;

                case "長崎県":
                    Code = "420000";
                    break;

                case "熊本県":
                    Code = "430000";
                    break;

                case "大分県":
                    Code = "440000";
                    break;

                case "宮崎県":
                    Code = "450000";
                    break;

                case "奄美地方":
                    Code = "460040";
                    break;

                case "鹿児島県":
                    Code = "460100";
                    break;

                case "沖縄本島地方":
                    Code = "471000";
                    break;

                case "大東島地方":
                    Code = "472000";
                    break;

                case "宮古島地方":
                    Code = "473000";
                    break;

                case "八重山地方":
                    Code = "474000";
                    break;

            }
                        
            Acquisition(Code);
           
        }

        private void tbDelete_Click(object sender, EventArgs e) {
            
            tbTime.Text = null;            
            tbWeatherlnfo.Text = null;
            cbRegion.Text = null;
            cbRegionCode.Text = null;
            btSelect.Enabled = false;
            pbWeather.Image = null;
            btWeatherGet.Enabled = true;
            tbTemperatureMax.Text = null;
            tbTemperatureMin.Text = null;
            pbWeather1.Image = null;
            pbWeather2.Image = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;


        }       
    }
}
