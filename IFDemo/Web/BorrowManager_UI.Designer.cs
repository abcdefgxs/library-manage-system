﻿namespace Web
{
    partial class BorrowManager_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowManager_UI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelctReader = new System.Windows.Forms.Button();
            this.dgvBorrowed = new System.Windows.Forms.DataGridView();
            this.dgvReaderInfo = new System.Windows.Forms.DataGridView();
            this.labBorrowBook = new System.Windows.Forms.Label();
            this.txtReaderId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToAddRows = false;
            this.dgvBookInfo.AllowUserToDeleteRows = false;
            this.dgvBookInfo.AllowUserToResizeColumns = false;
            this.dgvBookInfo.AllowUserToResizeRows = false;
            this.dgvBookInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Location = new System.Drawing.Point(17, 59);
            this.dgvBookInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.ReadOnly = true;
            this.dgvBookInfo.RowHeadersWidth = 51;
            this.dgvBookInfo.RowTemplate.Height = 23;
            this.dgvBookInfo.Size = new System.Drawing.Size(1069, 210);
            this.dgvBookInfo.TabIndex = 8;
            this.dgvBookInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookInfo_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelctReader);
            this.groupBox2.Controls.Add(this.dgvBorrowed);
            this.groupBox2.Controls.Add(this.dgvReaderInfo);
            this.groupBox2.Controls.Add(this.labBorrowBook);
            this.groupBox2.Controls.Add(this.txtReaderId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1103, 394);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "还书，续借";
            // 
            // btnSelctReader
            // 
            this.btnSelctReader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelctReader.BackgroundImage")));
            this.btnSelctReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelctReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelctReader.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelctReader.Location = new System.Drawing.Point(273, 20);
            this.btnSelctReader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelctReader.Name = "btnSelctReader";
            this.btnSelctReader.Size = new System.Drawing.Size(56, 29);
            this.btnSelctReader.TabIndex = 16;
            this.btnSelctReader.UseVisualStyleBackColor = true;
            this.btnSelctReader.Click += new System.EventHandler(this.btnSelctReader_Click);
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.AllowUserToAddRows = false;
            this.dgvBorrowed.AllowUserToDeleteRows = false;
            this.dgvBorrowed.AllowUserToResizeColumns = false;
            this.dgvBorrowed.AllowUserToResizeRows = false;
            this.dgvBorrowed.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowed.Location = new System.Drawing.Point(19, 125);
            this.dgvBorrowed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBorrowed.RowHeadersWidth = 51;
            this.dgvBorrowed.RowTemplate.Height = 23;
            this.dgvBorrowed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBorrowed.Size = new System.Drawing.Size(1069, 210);
            this.dgvBorrowed.TabIndex = 13;
            this.dgvBorrowed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowed_CellContentClick);
            this.dgvBorrowed.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBorrowed_RowPostPaint);
            // 
            // dgvReaderInfo
            // 
            this.dgvReaderInfo.AllowUserToAddRows = false;
            this.dgvReaderInfo.AllowUserToDeleteRows = false;
            this.dgvReaderInfo.AllowUserToResizeColumns = false;
            this.dgvReaderInfo.AllowUserToResizeRows = false;
            this.dgvReaderInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReaderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderInfo.Location = new System.Drawing.Point(17, 56);
            this.dgvReaderInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReaderInfo.Name = "dgvReaderInfo";
            this.dgvReaderInfo.ReadOnly = true;
            this.dgvReaderInfo.RowHeadersVisible = false;
            this.dgvReaderInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReaderInfo.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReaderInfo.RowTemplate.Height = 23;
            this.dgvReaderInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvReaderInfo.Size = new System.Drawing.Size(1069, 50);
            this.dgvReaderInfo.TabIndex = 14;
            this.dgvReaderInfo.DataSourceChanged += new System.EventHandler(this.dgvReaderInfo_DataSourceChanged);
            // 
            // labBorrowBook
            // 
            this.labBorrowBook.AutoSize = true;
            this.labBorrowBook.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBorrowBook.ForeColor = System.Drawing.Color.OrangeRed;
            this.labBorrowBook.Location = new System.Drawing.Point(16, 106);
            this.labBorrowBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBorrowBook.Name = "labBorrowBook";
            this.labBorrowBook.Size = new System.Drawing.Size(134, 18);
            this.labBorrowBook.TabIndex = 10;
            this.labBorrowBook.Text = ".....已借图书";
            // 
            // txtReaderId
            // 
            this.txtReaderId.Location = new System.Drawing.Point(95, 22);
            this.txtReaderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReaderId.Name = "txtReaderId";
            this.txtReaderId.Size = new System.Drawing.Size(169, 25);
            this.txtReaderId.TabIndex = 12;
            this.txtReaderId.TextChanged += new System.EventHandler(this.txtReaderId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "读者编号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSelectBook);
            this.groupBox1.Controls.Add(this.txtBookId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvBookInfo);
            this.groupBox1.Location = new System.Drawing.Point(16, 416);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1105, 331);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借书";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(987, 282);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectBook.BackgroundImage")));
            this.btnSelectBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelectBook.Location = new System.Drawing.Point(273, 22);
            this.btnSelectBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(56, 29);
            this.btnSelectBook.TabIndex = 11;
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(93, 25);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(169, 25);
            this.txtBookId.TabIndex = 10;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtBookId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "图书编号";
            // 
            // BorrowManager_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BorrowManager_UI";
            this.Text = "图书借阅";
            this.Load += new System.EventHandler(this.BorrowManager_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelctReader;
        private System.Windows.Forms.DataGridView dgvBorrowed;
        private System.Windows.Forms.DataGridView dgvReaderInfo;
        private System.Windows.Forms.Label labBorrowBook;
        public System.Windows.Forms.TextBox txtReaderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectBook;
        public System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label7;
    }
}