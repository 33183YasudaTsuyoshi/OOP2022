using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //設定情報保存用オブジェクト 
        Settings settings = Settings.getInstance(); //シングルトン

        //カーレポート管理用リスト
        //BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        int mode = 0;
        public Form1() {
            InitializeComponent();
        }

        

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //色設定ダイアログの表示
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();   //設定オブジェクトへセット
            }
        }

        private void pbModeSelect_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルをシリアル化（P305）
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

            

            try {
                //設定ファイルを逆シリアル化（P307）して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {

            }

            EnabledCheck(); //マスク処理呼び出し
        }

        
        //設定されているメーカーを返す
        private string GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return "トヨタ";
            }
            if (rbNissan.Checked) {
                return "日産";
            }
            if (rbHonda.Checked) {
                return "ホンダ";
            }
            if (rbSubaru.Checked) {
                return "スバル";
            }
            if (rbImport.Checked) {
                return "外国車";
            }

            return "その他";
        }

        //コンボボックスに記録者を登録する（重複なし）
        private void setCbAuther(string company) {
            if (!cbAuther.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(company);
            }
        }
        //コンボボックスに車名を登録する（重複なし）
        private void setCbCarName(string company) {
            if (!cbCarName.Items.Contains(company)) {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(company);
            }
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            //pbPicture.Filter = "画像ファイル(*.jpg; *.png; *.bmp) | *.jpg; *.png; *.bmp";
            if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdCarReportOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btOpenReport_Click(object sender, EventArgs e) {
            /*if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarReportOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReports;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbAuther.Items.Clear();    //コンボボックスのアイテム消去
                cbCarName.Items.Clear();    //コンボボックスのアイテム消去
                //コンボボックスへ新規登録
                foreach (var item in listCarReports.Select(p => p.Auther)) {
                    setCbAuther(item);
                }
                foreach (var item in listCarReports.Select(p => p.CarName)) {
                    setCbCarName(item);
                }
            }
            EnabledCheck(); //マスク処理呼び出し*/
        }
        /*private void btSaveReport_Click(object sender, EventArgs e) {
            if (sfdCarReportSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarReportSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }*/

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202218DataSet);

        }

        private void btAddReport_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202218DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDate.Text;
            newRow[2] = cbAuther.Text;
            newRow[3] = GetRadioButtonMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;

            
            newRow[6] = ImageToByteArray(pbPicture.Image);

            //データセットへ新しいレコードを追加
            infosys202218DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202218DataSet.CarReportDB);
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

        private void btModifyReport_Click(object sender, EventArgs e) {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pbPicture.Image;

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202218DataSet);
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            carReportDBBindingSource.RemoveAt(carReportDBDataGridView.CurrentRow.Index);
        
        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202218DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202218DataSet.CarReportDB);

            EnabledCheck(); 
        }

        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null) {
                return;
            } else {
                //データグリッドビューの選択レコードを各テキストボックスへ設定
                dtpDate.Value = (DateTime)carReportDBDataGridView.CurrentRow.Cells[1].Value;
                cbAuther.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
                setMakerRadioSet(carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();

                //画像表示処理  DBNullじゃなかったら真
                if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                    pbPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
                } else {
                    pbPicture.Image = null;
                }
            }
        }

        private void setMakerRadioSet(string maker) {
            switch (maker) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbImport.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btNameSearch_Click(object sender, EventArgs e) {
          //  carReportDBTableAdapter.FillByName(infosys202218DataSet.CarReportDB, tbSesrchName.Text);
        }

        private void tbNameDelete_Click(object sender, EventArgs e) {
            tbSesrchName.Text = null;
            this.carReportDBTableAdapter.Fill(this.infosys202218DataSet.CarReportDB);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tbSave_Click(object sender, EventArgs e) {
            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202218DataSet);
        }

        private void EnabledCheck() {

            if (carReportDBDataGridView.CurrentRow == null) {
                btModifyReport.Enabled = false;
                btDeleteReport.Enabled = false;
          //      btSave.Enabled = false;
            } else {
                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
            //    btSave.Enabled = true;
            }
        }

        private void データベース接続ToolStripMenuItem_Click_1(object sender, EventArgs e) {
            this.carReportDBTableAdapter.Fill(this.infosys202218DataSet.CarReportDB);
        }

        private void btAdd_Click(object sender, EventArgs e) {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pbPicture.Image;

            //データセットの中をデータベースへ反映（保存）
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202218DataSet);
        }
    }
}
