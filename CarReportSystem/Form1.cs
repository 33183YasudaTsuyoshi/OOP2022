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

namespace CarReportSystem
{
    public partial class Form1 : Form {

        Settings settings = new Settings();

        //試乗レポート管理用リスト
        BindingList<CarReport> listCar = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCars.DataSource = listCar;
        }



        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();

        }


        //btPictureOpen 開く　キャンセル
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);

            }
        }


        private void btAddPerson_Click(object sender, EventArgs e) {
            // 氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("記録者が入力されていません");
                return;
            }

            CarReport newCarReport = new CarReport {

                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,

            };
            listCar.Add(newCarReport);
            dgvCars.Rows[dgvCars.RowCount - 1].Selected = true;

            if (listCar.Count() == 0) {
                btDelete.Enabled = false;
                btCorrect.Enabled = false;
            } else {
                btDelete.Enabled = true;
                btCorrect.Enabled = true;
            }
        }



        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvCars.CurrentRow == null) return;
            int index = dgvCars.CurrentRow.Index;

            dtpDate.Text = listCar[index].Date.ToString();
            cbAuther.Text = listCar[index].Auther;
            cbCarName.Text = listCar[index].CarName;
            tbReport.Text = listCar[index].Report;
            pbPicture.Image = listCar[index].Picture;


            setGroupType(index); //グループを設定


        }
        private void setGroupType(int index) {

            //groupCheckBoxAllClear(); //グループチェックボックスを一旦初期化

            foreach (var grop in listCar[index].listGroup) {

                switch (grop) {
                    case CarReport.MakerGroup.トヨタ:
                        rbToyota.Checked = true;
                        break;
                    case CarReport.MakerGroup.日産:
                        rbNissan.Checked = true;
                        break;
                    case CarReport.MakerGroup.ホンダ:
                        rbHonda.Checked = true;
                        break;
                    case CarReport.MakerGroup.スバル:
                        rbSubaru.Checked = true;
                        break;
                    case CarReport.MakerGroup.外国車:
                        rbImport.Checked = true;
                        break;
                    case CarReport.MakerGroup.その他:
                        rbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private List<CarReport.MakerGroup> GetCheckBoxGroup() {

            groupCheckBoxAllClear(); //グループチェックボックスを一旦初期化

            var listGroup = new List<CarReport.MakerGroup>();
            if (rbToyota.Checked) {
                listGroup.Add(CarReport.MakerGroup.トヨタ);
            }
            if (rbNissan.Checked) {
                listGroup.Add(CarReport.MakerGroup.日産);
            }
            if (rbHonda.Checked) {
                listGroup.Add(CarReport.MakerGroup.ホンダ);
            }
            if (rbSubaru.Checked) {
                listGroup.Add(CarReport.MakerGroup.スバル);
            }
            if (rbImport.Checked) {
                listGroup.Add(CarReport.MakerGroup.外国車);
            }
            if (rbOther.Checked) {
                listGroup.Add(CarReport.MakerGroup.その他);
            }
            return listGroup;

        }

        private void groupCheckBoxAllClear() {

            rbToyota.Checked = rbNissan.Checked = rbHonda.Checked = rbSubaru.Checked = rbImport.Checked = rbOther.Checked = false;

        }


        private void btSave_Click(object sender, EventArgs e) {

            listCar[dgvCars.CurrentRow.Index].Date = dtpDate.Value;
            listCar[dgvCars.CurrentRow.Index].Auther = cbAuther.Text;
            listCar[dgvCars.CurrentRow.Index].CarName = cbCarName.Text;
            listCar[dgvCars.CurrentRow.Index].Report = tbReport.Text;
            listCar[dgvCars.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listCar[dgvCars.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCars.Refresh();
        }

        private void btDelete_Click(object sender, EventArgs e) {

            listCar.RemoveAt(dgvCars.CurrentRow.Index);
            if (listCar.Count() == 0) {
                btDelete.Enabled = false;
                btCorrect.Enabled = false;
            } else {
                btDelete.Enabled = true;
                btCorrect.Enabled = true;
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listCar = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCars.DataSource = null;
                        dgvCars.DataSource = listCar;
                    }

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void btSave_Click_1(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCar);
                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {

            if (cdColorSelect.ShowDialog() == DialogResult.OK) {

                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color;
            }
        }
    }
}
