using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //ボタンクリックイベントハンドラ
        private void button1_Click(object sender, EventArgs e) {

            //tbAns.Text = (int.Parse(tbSuu1.Text) + int.Parse(tbSuu2.Text)).ToString();
            numericUpDown4.Value = numericUpDown2.Value + numericUpDown3.Value;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e) {

        }
    }
}
