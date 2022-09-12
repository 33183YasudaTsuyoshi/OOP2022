
namespace DataBaseSample {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infosys202218DataSet = new DataBaseSample.infosys202218DataSet();
            this.社員BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.社員TableAdapter = new DataBaseSample.infosys202218DataSetTableAdapters.社員TableAdapter();
            this.tableAdapterManager = new DataBaseSample.infosys202218DataSetTableAdapters.TableAdapterManager();
            this.社員BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.社員BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.社員DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConnect = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExecute = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202218DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingNavigator)).BeginInit();
            this.社員BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.社員DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infosys202218DataSet
            // 
            this.infosys202218DataSet.DataSetName = "infosys202218DataSet";
            this.infosys202218DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 社員BindingSource
            // 
            this.社員BindingSource.DataMember = "社員";
            this.社員BindingSource.DataSource = this.infosys202218DataSet;
            // 
            // 社員TableAdapter
            // 
            this.社員TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DataBaseSample.infosys202218DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.社員TableAdapter = this.社員TableAdapter;
            // 
            // 社員BindingNavigator
            // 
            this.社員BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.社員BindingNavigator.BindingSource = this.社員BindingSource;
            this.社員BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.社員BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.社員BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.社員BindingNavigatorSaveItem});
            this.社員BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.社員BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.社員BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.社員BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.社員BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.社員BindingNavigator.Name = "社員BindingNavigator";
            this.社員BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.社員BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.社員BindingNavigator.TabIndex = 0;
            this.社員BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 社員BindingNavigatorSaveItem
            // 
            this.社員BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.社員BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("社員BindingNavigatorSaveItem.Image")));
            this.社員BindingNavigatorSaveItem.Name = "社員BindingNavigatorSaveItem";
            this.社員BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.社員BindingNavigatorSaveItem.Text = "データの保存";
            this.社員BindingNavigatorSaveItem.Click += new System.EventHandler(this.社員BindingNavigatorSaveItem_Click);
            // 
            // 社員DataGridView
            // 
            this.社員DataGridView.AutoGenerateColumns = false;
            this.社員DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.社員DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.社員DataGridView.DataSource = this.社員BindingSource;
            this.社員DataGridView.Location = new System.Drawing.Point(0, 28);
            this.社員DataGridView.Name = "社員DataGridView";
            this.社員DataGridView.RowTemplate.Height = 21;
            this.社員DataGridView.Size = new System.Drawing.Size(788, 319);
            this.社員DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "社員番号";
            this.dataGridViewTextBoxColumn1.HeaderText = "社員番号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "名前";
            this.dataGridViewTextBoxColumn2.HeaderText = "名前";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "入社年月日";
            this.dataGridViewTextBoxColumn3.HeaderText = "入社年月日";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "給与";
            this.dataGridViewTextBoxColumn4.HeaderText = "給与";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(12, 380);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(107, 48);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(134, 380);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(107, 48);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(278, 400);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(118, 23);
            this.btExecute.TabIndex = 4;
            this.btExecute.Text = "実行";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(420, 400);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(121, 19);
            this.tbValue.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.社員DataGridView);
            this.Controls.Add(this.社員BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202218DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員BindingNavigator)).EndInit();
            this.社員BindingNavigator.ResumeLayout(false);
            this.社員BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.社員DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202218DataSet infosys202218DataSet;
        private System.Windows.Forms.BindingSource 社員BindingSource;
        private infosys202218DataSetTableAdapters.社員TableAdapter 社員TableAdapter;
        private infosys202218DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 社員BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 社員BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView 社員DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.TextBox tbValue;
    }
}

