
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
            this.tbWeatherlnfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRegionCode = new System.Windows.Forms.ComboBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbPresenter = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbSelect = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbWeatherlnfo
            // 
            this.tbWeatherlnfo.Location = new System.Drawing.Point(169, 313);
            this.tbWeatherlnfo.Multiline = true;
            this.tbWeatherlnfo.Name = "tbWeatherlnfo";
            this.tbWeatherlnfo.Size = new System.Drawing.Size(502, 257);
            this.tbWeatherlnfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(296, 272);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(66, 24);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "発表者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "報告日時";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(22, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "対象地域";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(22, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "天気概況";
            // 
            // cbRegionCode
            // 
            this.cbRegionCode.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegionCode.FormattingEnabled = true;
            this.cbRegionCode.Location = new System.Drawing.Point(169, 272);
            this.cbRegionCode.Name = "cbRegionCode";
            this.cbRegionCode.Size = new System.Drawing.Size(121, 24);
            this.cbRegionCode.TabIndex = 3;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(169, 128);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(502, 39);
            this.tbTime.TabIndex = 4;
            // 
            // tbPresenter
            // 
            this.tbPresenter.Location = new System.Drawing.Point(169, 48);
            this.tbPresenter.Multiline = true;
            this.tbPresenter.Name = "tbPresenter";
            this.tbPresenter.Size = new System.Drawing.Size(502, 38);
            this.tbPresenter.TabIndex = 4;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(169, 214);
            this.tbArea.Multiline = true;
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(502, 39);
            this.tbArea.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(22, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "地方";
            // 
            // cbRegion
            // 
            this.cbRegion.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(368, 272);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(121, 24);
            this.cbRegion.TabIndex = 3;
            // 
            // cbSelect
            // 
            this.cbSelect.Location = new System.Drawing.Point(495, 274);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(72, 24);
            this.cbSelect.TabIndex = 1;
            this.cbSelect.Text = "選択";
            this.cbSelect.UseVisualStyleBackColor = true;
            this.cbSelect.Click += new System.EventHandler(this.cbSelect_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(585, 276);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(86, 19);
            this.tbCode.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 586);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbPresenter);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbRegionCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherlnfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherlnfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRegionCode;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbPresenter;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Button cbSelect;
        private System.Windows.Forms.TextBox tbCode;
    }
}

