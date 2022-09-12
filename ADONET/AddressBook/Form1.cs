using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
           
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューへ設定
            addressTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202218DataSet);
        }

        
        private void addressTableDataGridView_Click(object sender, EventArgs e) {

            if (addressTableDataGridView.CurrentRow == null) {
                return;
            } else {
                //データグリッドビューの選択レコードを各テキストボックスへ設定
                tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
                tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
                tbTel.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
                tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();

                //画像表示処理  DBNullじゃなかったら真
                if (!(addressTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                    pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
                } else {
                    pbImage.Image = null;
                }
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp) | *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageClear_Click(object sender, EventArgs e) {
            pbImage.Image = null;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202218DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;

            //データセットへ新しいレコードを追加
            infosys202218DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202218DataSet.AddressTable);
        }

        //エラー回避
        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
        }

        //名前検索
        private void btNameSearch_Click(object sender, EventArgs e) {
            addressTableTableAdapter.FillByName(infosys202218DataSet.AddressTable, tbSesrchName.Text);
        }

        private void tbExtinguish_Click(object sender, EventArgs e) {
            tbName.Text = null;
            tbAddress.Text = null;
            tbTel.Text = null;
            tbMail.Text = null;
            tbMemo.Text = null;
            pbImage.Image = null;
        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202218DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.addressTableTableAdapter.Fill(this.infosys202218DataSet.AddressTable);
        }

        private void tbNameDelete_Click(object sender, EventArgs e) {
            tbSesrchName.Text = null;
            this.addressTableTableAdapter.Fill(this.infosys202218DataSet.AddressTable);
        }
    }
}
