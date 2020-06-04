namespace Web
{
    partial class BorrowHostory_UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowHostory_UI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboBorrowTimeType = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtReaderId = new System.Windows.Forms.TextBox();
            this.btnBookId = new System.Windows.Forms.Button();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.btnReaderId = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.dgvHostory = new System.Windows.Forms.DataGridView();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoBorrow = new System.Windows.Forms.RadioButton();
            this.rdoReturn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostory)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBorrowTimeType
            // 
            this.cboBorrowTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBorrowTimeType.FormattingEnabled = true;
            this.cboBorrowTimeType.Items.AddRange(new object[] {
            "日期",
            "借书日期",
            "应还书日期",
            "实际还书日期"});
            this.cboBorrowTimeType.Location = new System.Drawing.Point(651, 14);
            this.cboBorrowTimeType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBorrowTimeType.Name = "cboBorrowTimeType";
            this.cboBorrowTimeType.Size = new System.Drawing.Size(145, 23);
            this.cboBorrowTimeType.TabIndex = 45;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(1341, 14);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 29);
            this.btnSelect.TabIndex = 44;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "图书编号";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboBorrowTimeType);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelect);
            this.splitContainer1.Panel1.Controls.Add(this.txtReaderId);
            this.splitContainer1.Panel1.Controls.Add(this.btnBookId);
            this.splitContainer1.Panel1.Controls.Add(this.checkTime);
            this.splitContainer1.Panel1.Controls.Add(this.txtBookId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtOut);
            this.splitContainer1.Panel1.Controls.Add(this.btnReaderId);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.dtIn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHostory);
            this.splitContainer1.Panel2.Controls.Add(this.rdoAll);
            this.splitContainer1.Panel2.Controls.Add(this.rdoBorrow);
            this.splitContainer1.Panel2.Controls.Add(this.rdoReturn);
            this.splitContainer1.Size = new System.Drawing.Size(1643, 801);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // txtReaderId
            // 
            this.txtReaderId.Location = new System.Drawing.Point(91, 15);
            this.txtReaderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReaderId.Name = "txtReaderId";
            this.txtReaderId.Size = new System.Drawing.Size(187, 25);
            this.txtReaderId.TabIndex = 32;
            // 
            // btnBookId
            // 
            this.btnBookId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookId.BackgroundImage")));
            this.btnBookId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBookId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookId.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookId.Location = new System.Drawing.Point(587, 12);
            this.btnBookId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookId.Name = "btnBookId";
            this.btnBookId.Size = new System.Drawing.Size(56, 29);
            this.btnBookId.TabIndex = 34;
            this.btnBookId.UseVisualStyleBackColor = true;
            this.btnBookId.Click += new System.EventHandler(this.btnBookId_Click);
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Checked = true;
            this.checkTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTime.Location = new System.Drawing.Point(1236, 20);
            this.checkTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(18, 17);
            this.checkTime.TabIndex = 42;
            this.checkTime.UseVisualStyleBackColor = true;
            this.checkTime.CheckedChanged += new System.EventHandler(this.checkTime_CheckedChanged);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(406, 15);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(187, 25);
            this.txtBookId.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "读者编号";
            // 
            // dtOut
            // 
            this.dtOut.Location = new System.Drawing.Point(1041, 15);
            this.dtOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(187, 25);
            this.dtOut.TabIndex = 40;
            // 
            // btnReaderId
            // 
            this.btnReaderId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReaderId.BackgroundImage")));
            this.btnReaderId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReaderId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReaderId.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReaderId.Location = new System.Drawing.Point(280, 12);
            this.btnReaderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReaderId.Name = "btnReaderId";
            this.btnReaderId.Size = new System.Drawing.Size(56, 29);
            this.btnReaderId.TabIndex = 35;
            this.btnReaderId.UseVisualStyleBackColor = true;
            this.btnReaderId.Click += new System.EventHandler(this.btnReaderId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1011, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "至";
            // 
            // dtIn
            // 
            this.dtIn.Location = new System.Drawing.Point(804, 15);
            this.dtIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(187, 25);
            this.dtIn.TabIndex = 41;
            // 
            // dgvHostory
            // 
            this.dgvHostory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHostory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHostory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHostory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHostory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHostory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHostory.Location = new System.Drawing.Point(4, 20);
            this.dgvHostory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHostory.Name = "dgvHostory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHostory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHostory.RowHeadersWidth = 51;
            this.dgvHostory.RowTemplate.Height = 23;
            this.dgvHostory.Size = new System.Drawing.Size(1635, 720);
            this.dgvHostory.TabIndex = 3;
            this.dgvHostory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvHostory_RowPostPaint);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(20, 1);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(58, 19);
            this.rdoAll.TabIndex = 43;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "全部";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoBorrow
            // 
            this.rdoBorrow.AutoSize = true;
            this.rdoBorrow.Location = new System.Drawing.Point(91, 1);
            this.rdoBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBorrow.Name = "rdoBorrow";
            this.rdoBorrow.Size = new System.Drawing.Size(58, 19);
            this.rdoBorrow.TabIndex = 43;
            this.rdoBorrow.Text = "已借";
            this.rdoBorrow.UseVisualStyleBackColor = true;
            // 
            // rdoReturn
            // 
            this.rdoReturn.AutoSize = true;
            this.rdoReturn.Location = new System.Drawing.Point(163, 1);
            this.rdoReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoReturn.Name = "rdoReturn";
            this.rdoReturn.Size = new System.Drawing.Size(58, 19);
            this.rdoReturn.TabIndex = 43;
            this.rdoReturn.Text = "已还";
            this.rdoReturn.UseVisualStyleBackColor = true;
            // 
            // BorrowHostory_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 801);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BorrowHostory_UI";
            this.Text = "BorrowHostory_UI";
            this.Load += new System.EventHandler(this.BorrowHostory_UI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBorrowTimeType;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TextBox txtReaderId;
        private System.Windows.Forms.CheckBox checkTime;
        public System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.Button btnReaderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.DataGridView dgvHostory;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoBorrow;
        private System.Windows.Forms.RadioButton rdoReturn;
    }
}