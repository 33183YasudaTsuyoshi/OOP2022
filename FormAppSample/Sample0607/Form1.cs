using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {

            var r = new Random();


            Ans.Value = r.Next(minValue:(int)Number1.Value, maxValue: (int)Number2.Value + 1);

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Number1_ValueChanged(object sender, EventArgs e) {

        }
    }
}
