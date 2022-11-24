
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbWeatherlnfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRegionCode = new System.Windows.Forms.ComboBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.tbDelete = new System.Windows.Forms.Button();
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.pbWeather1 = new System.Windows.Forms.PictureBox();
            this.pbWeather2 = new System.Windows.Forms.PictureBox();
            this.tbTemperatureMax = new System.Windows.Forms.TextBox();
            this.tbTemperatureMin = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherlnfo
            // 
            this.tbWeatherlnfo.Location = new System.Drawing.Point(175, 173);
            this.tbWeatherlnfo.Multiline = true;
            this.tbWeatherlnfo.Name = "tbWeatherlnfo";
            this.tbWeatherlnfo.Size = new System.Drawing.Size(557, 130);
            this.tbWeatherlnfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(386, 124);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(66, 24);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "報告日時";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(31, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "天気概況";
            // 
            // cbRegionCode
            // 
            this.cbRegionCode.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegionCode.FormattingEnabled = true;
            this.cbRegionCode.Location = new System.Drawing.Point(175, 123);
            this.cbRegionCode.Name = "cbRegionCode";
            this.cbRegionCode.Size = new System.Drawing.Size(187, 24);
            this.cbRegionCode.TabIndex = 3;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTime.Location = new System.Drawing.Point(175, 29);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(193, 34);
            this.tbTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(31, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "地方";
            // 
            // cbRegion
            // 
            this.cbRegion.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(475, 126);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(163, 24);
            this.cbRegion.TabIndex = 3;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(654, 126);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(72, 24);
            this.btSelect.TabIndex = 1;
            this.btSelect.Text = "選択";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(71, 280);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(75, 23);
            this.tbDelete.TabIndex = 7;
            this.tbDelete.Text = "削除";
            this.tbDelete.UseVisualStyleBackColor = true;
            this.tbDelete.Click += new System.EventHandler(this.tbDelete_Click);
            // 
            // pbWeather
            // 
            this.pbWeather.BackColor = System.Drawing.Color.White;
            this.pbWeather.Location = new System.Drawing.Point(27, 397);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(208, 130);
            this.pbWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeather.TabIndex = 8;
            this.pbWeather.TabStop = false;
            // 
            // pbWeather1
            // 
            this.pbWeather1.BackColor = System.Drawing.Color.White;
            this.pbWeather1.Location = new System.Drawing.Point(272, 397);
            this.pbWeather1.Name = "pbWeather1";
            this.pbWeather1.Size = new System.Drawing.Size(208, 130);
            this.pbWeather1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeather1.TabIndex = 8;
            this.pbWeather1.TabStop = false;
            // 
            // pbWeather2
            // 
            this.pbWeather2.BackColor = System.Drawing.Color.White;
            this.pbWeather2.Location = new System.Drawing.Point(518, 397);
            this.pbWeather2.Name = "pbWeather2";
            this.pbWeather2.Size = new System.Drawing.Size(208, 130);
            this.pbWeather2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeather2.TabIndex = 8;
            this.pbWeather2.TabStop = false;
            // 
            // tbTemperatureMax
            // 
            this.tbTemperatureMax.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.tbTemperatureMax.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTemperatureMax.Location = new System.Drawing.Point(475, 29);
            this.tbTemperatureMax.Multiline = true;
            this.tbTemperatureMax.Name = "tbTemperatureMax";
            this.tbTemperatureMax.Size = new System.Drawing.Size(96, 50);
            this.tbTemperatureMax.TabIndex = 10;
            // 
            // tbTemperatureMin
            // 
            this.tbTemperatureMin.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTemperatureMin.Location = new System.Drawing.Point(630, 29);
            this.tbTemperatureMin.Multiline = true;
            this.tbTemperatureMin.Name = "tbTemperatureMin";
            this.tbTemperatureMin.Size = new System.Drawing.Size(96, 50);
            this.tbTemperatureMin.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 533);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 19);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 533);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 19);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(518, 533);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 19);
            this.textBox3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(32, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "今日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(514, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "明後日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(277, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "明日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1659, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(639, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "最低気温";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(486, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "最高気温";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 12);
            this.label11.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 12);
            this.label12.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(753, 560);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbTemperatureMin);
            this.Controls.Add(this.tbTemperatureMax);
            this.Controls.Add(this.pbWeather2);
            this.Controls.Add(this.pbWeather1);
            this.Controls.Add(this.pbWeather);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbRegionCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherlnfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherlnfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRegionCode;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button tbDelete;
        private System.Windows.Forms.PictureBox pbWeather;
        private System.Windows.Forms.PictureBox pbWeather1;
        private System.Windows.Forms.PictureBox pbWeather2;
        private System.Windows.Forms.TextBox tbTemperatureMax;
        private System.Windows.Forms.TextBox tbTemperatureMin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

