using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {


        IEnumerable<string> xTitle;


        public Form1() {
            InitializeComponent();
        }




        private void btRssGet_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(stream);
                var xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));

                foreach (var data in xTitle) {

                    lbRssTitle.Items.Add(data);

                }
            }
        }

        private void lbRssTitle_MouseClick(object sender, MouseEventArgs e) {

            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(stream);
                var xNews = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));

                foreach (var data in xNews) {

                    lbRssTitle.Items.Add(data);

                }
                List<string> titlelist = new List<string>();

                int index = lbRssTitle.SelectedIndex;  //選択した行のインデックスを取得（０～）
                //titlelist.Add(index);
            }
        }
    }
}
