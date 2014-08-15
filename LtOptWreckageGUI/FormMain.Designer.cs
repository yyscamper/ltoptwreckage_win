namespace LtOptWreckageGUI
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgvWreckagesTable = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWreckageValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxNum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboxWreckagesList = new System.Windows.Forms.ComboBox();
            this.btnAddWreckage = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.colResultIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResultDelta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBodyPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResultValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxTargetValue = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.nudAllowedError = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readioBtnBodyPoint = new System.Windows.Forms.RadioButton();
            this.radioBtnTotalWreckages = new System.Windows.Forms.RadioButton();
            this.radioBtnOrderDelta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuSelectResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelectResult = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWreckagesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllowedError)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuSelectResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWreckagesTable
            // 
            this.dgvWreckagesTable.AllowUserToAddRows = false;
            this.dgvWreckagesTable.AllowUserToOrderColumns = true;
            this.dgvWreckagesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWreckagesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colWreckageValue,
            this.colMaxNum,
            this.colDelete});
            this.dgvWreckagesTable.Location = new System.Drawing.Point(8, 136);
            this.dgvWreckagesTable.Name = "dgvWreckagesTable";
            this.dgvWreckagesTable.RowHeadersVisible = false;
            this.dgvWreckagesTable.RowTemplate.Height = 23;
            this.dgvWreckagesTable.Size = new System.Drawing.Size(326, 378);
            this.dgvWreckagesTable.TabIndex = 0;
            this.dgvWreckagesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWreckagesTable_CellClick);
            this.dgvWreckagesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWreckagesTable_CellContentClick);
            this.dgvWreckagesTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWreckagesTable_DataError);
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "#";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.Width = 50;
            // 
            // colWreckageValue
            // 
            this.colWreckageValue.HeaderText = "经验";
            this.colWreckageValue.Name = "colWreckageValue";
            this.colWreckageValue.ReadOnly = true;
            // 
            // colMaxNum
            // 
            this.colMaxNum.HeaderText = "最大数量";
            this.colMaxNum.Name = "colMaxNum";
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "删除";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 72;
            // 
            // comboxWreckagesList
            // 
            this.comboxWreckagesList.FormattingEnabled = true;
            this.comboxWreckagesList.Location = new System.Drawing.Point(8, 100);
            this.comboxWreckagesList.Name = "comboxWreckagesList";
            this.comboxWreckagesList.Size = new System.Drawing.Size(124, 25);
            this.comboxWreckagesList.TabIndex = 1;
            this.comboxWreckagesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboxWreckagesList_KeyDown);
            this.comboxWreckagesList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboxTargetValue_KeyPress);
            // 
            // btnAddWreckage
            // 
            this.btnAddWreckage.Location = new System.Drawing.Point(138, 96);
            this.btnAddWreckage.Name = "btnAddWreckage";
            this.btnAddWreckage.Size = new System.Drawing.Size(75, 32);
            this.btnAddWreckage.TabIndex = 2;
            this.btnAddWreckage.Text = "添加残骸";
            this.btnAddWreckage.UseVisualStyleBackColor = true;
            this.btnAddWreckage.Click += new System.EventHandler(this.btnAddWreckage_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colResultIndex,
            this.colResultDelta,
            this.colTotalNum,
            this.colBodyPoint,
            this.colResultValue});
            this.listViewResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewResult.Location = new System.Drawing.Point(342, 53);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(692, 461);
            this.listViewResult.TabIndex = 3;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // colResultIndex
            // 
            this.colResultIndex.Text = "#";
            this.colResultIndex.Width = 48;
            // 
            // colResultDelta
            // 
            this.colResultDelta.Text = "多余经验";
            this.colResultDelta.Width = 82;
            // 
            // colTotalNum
            // 
            this.colTotalNum.Text = "残骸总数";
            this.colTotalNum.Width = 82;
            // 
            // colBodyPoint
            // 
            this.colBodyPoint.Text = "约消耗体力";
            this.colBodyPoint.Width = 73;
            // 
            // colResultValue
            // 
            this.colResultValue.Text = "残骸组合";
            this.colResultValue.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "允许最大多余经验：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "目标经验：";
            // 
            // comboxTargetValue
            // 
            this.comboxTargetValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxTargetValue.FormattingEnabled = true;
            this.comboxTargetValue.Location = new System.Drawing.Point(136, 51);
            this.comboxTargetValue.Name = "comboxTargetValue";
            this.comboxTargetValue.Size = new System.Drawing.Size(87, 28);
            this.comboxTargetValue.TabIndex = 6;
            this.comboxTargetValue.Text = "21360";
            this.comboxTargetValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudAllowedError_KeyDown);
            this.comboxTargetValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboxTargetValue_KeyPress);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalc.Location = new System.Drawing.Point(229, 19);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(91, 60);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // nudAllowedError
            // 
            this.nudAllowedError.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudAllowedError.Location = new System.Drawing.Point(136, 19);
            this.nudAllowedError.Name = "nudAllowedError";
            this.nudAllowedError.Size = new System.Drawing.Size(87, 26);
            this.nudAllowedError.TabIndex = 8;
            this.nudAllowedError.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudAllowedError_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboxTargetValue);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.nudAllowedError);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readioBtnBodyPoint);
            this.groupBox2.Controls.Add(this.radioBtnTotalWreckages);
            this.groupBox2.Controls.Add(this.radioBtnOrderDelta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(342, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 44);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // readioBtnBodyPoint
            // 
            this.readioBtnBodyPoint.AutoSize = true;
            this.readioBtnBodyPoint.Location = new System.Drawing.Point(232, 14);
            this.readioBtnBodyPoint.Name = "readioBtnBodyPoint";
            this.readioBtnBodyPoint.Size = new System.Drawing.Size(83, 24);
            this.readioBtnBodyPoint.TabIndex = 6;
            this.readioBtnBodyPoint.Text = "消耗体力";
            this.readioBtnBodyPoint.UseVisualStyleBackColor = true;
            this.readioBtnBodyPoint.CheckedChanged += new System.EventHandler(this.radioBtnOrderDelta_CheckedChanged);
            // 
            // radioBtnTotalWreckages
            // 
            this.radioBtnTotalWreckages.AutoSize = true;
            this.radioBtnTotalWreckages.Location = new System.Drawing.Point(144, 14);
            this.radioBtnTotalWreckages.Name = "radioBtnTotalWreckages";
            this.radioBtnTotalWreckages.Size = new System.Drawing.Size(83, 24);
            this.radioBtnTotalWreckages.TabIndex = 6;
            this.radioBtnTotalWreckages.Text = "残骸总数";
            this.radioBtnTotalWreckages.UseVisualStyleBackColor = true;
            this.radioBtnTotalWreckages.CheckedChanged += new System.EventHandler(this.radioBtnOrderDelta_CheckedChanged);
            // 
            // radioBtnOrderDelta
            // 
            this.radioBtnOrderDelta.AutoSize = true;
            this.radioBtnOrderDelta.Checked = true;
            this.radioBtnOrderDelta.Location = new System.Drawing.Point(56, 14);
            this.radioBtnOrderDelta.Name = "radioBtnOrderDelta";
            this.radioBtnOrderDelta.Size = new System.Drawing.Size(83, 24);
            this.radioBtnOrderDelta.TabIndex = 6;
            this.radioBtnOrderDelta.TabStop = true;
            this.radioBtnOrderDelta.Text = "多余经验";
            this.radioBtnOrderDelta.UseVisualStyleBackColor = true;
            this.radioBtnOrderDelta.CheckedChanged += new System.EventHandler(this.radioBtnOrderDelta_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "排序：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(669, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "注：消耗体力按平均每次闯关两个残骸计算, 不计双倍,\r\n      非闯关所得经验均计0点体力（如9600、400）";
            // 
            // contextMenuSelectResult
            // 
            this.contextMenuSelectResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectResult});
            this.contextMenuSelectResult.Name = "contextMenuSelectResult";
            this.contextMenuSelectResult.Size = new System.Drawing.Size(137, 26);
            // 
            // menuItemSelectResult
            // 
            this.menuItemSelectResult.Name = "menuItemSelectResult";
            this.menuItemSelectResult.Size = new System.Drawing.Size(136, 22);
            this.menuItemSelectResult.Text = "选择该组合";
            this.menuItemSelectResult.Click += new System.EventHandler(this.menuItemSelectResult_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddWreckage);
            this.Controls.Add(this.comboxWreckagesList);
            this.Controls.Add(this.dgvWreckagesTable);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "雷霆残骸经验最优化v1.3";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWreckagesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllowedError)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuSelectResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWreckagesTable;
        private System.Windows.Forms.ComboBox comboxWreckagesList;
        private System.Windows.Forms.Button btnAddWreckage;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader colResultIndex;
        private System.Windows.Forms.ColumnHeader colResultDelta;
        private System.Windows.Forms.ColumnHeader colResultValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxTargetValue;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.NumericUpDown nudAllowedError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader colTotalNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWreckageValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaxNum;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.ColumnHeader colBodyPoint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton readioBtnBodyPoint;
        private System.Windows.Forms.RadioButton radioBtnTotalWreckages;
        private System.Windows.Forms.RadioButton radioBtnOrderDelta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuSelectResult;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectResult;
    }
}

