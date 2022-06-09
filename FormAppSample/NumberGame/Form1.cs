using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        private Random rand = new Random();

        private int randomNumber;

        public Form1() {
            InitializeComponent();
        }

        //起動時に一回行われる実行
        private void Form1_Load(object sender, EventArgs e) {

            randomNumber = rand.Next(minValue: 1, maxValue: (int)Num2.Value);

        }

        private void Num2_ValueChanged(object sender, EventArgs e) {

            randomNumber = rand.Next(minValue: 1, maxValue: (int)Num2.Value);

        }

        //ボタンクリックするたびに実行
        private void button1_Click(object sender, EventArgs e) {
            if (Num1.Value == randomNumber) {
                textBox1.Text = ("当たり");
            } else if(Num1.Value < randomNumber) {
                textBox1.Text = (Num1.Value + "より大きい"  );
            } else if (Num1.Value > randomNumber) {
                textBox1.Text = (Num1.Value + "より小さい");
            }
        }

        
        
    }
}
