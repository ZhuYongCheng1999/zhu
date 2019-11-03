namespace LibraryManagement
{
    partial class BooksForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.cbSel = new System.Windows.Forms.CheckBox();
            this.llSel = new System.Windows.Forms.LinkLabel();
            this.btReturn = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bauthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPubCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPubDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.cbSel);
            this.panel1.Controls.Add(this.llSel);
            this.panel1.Controls.Add(this.btReturn);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.dgvBooks);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 445);
            this.panel1.TabIndex = 0;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(600, 319);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.Text = "更新选中";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cbSel
            // 
            this.cbSel.AutoSize = true;
            this.cbSel.Location = new System.Drawing.Point(61, 324);
            this.cbSel.Name = "cbSel";
            this.cbSel.Size = new System.Drawing.Size(48, 16);
            this.cbSel.TabIndex = 6;
            this.cbSel.Text = "全选";
            this.cbSel.UseVisualStyleBackColor = true;
            this.cbSel.CheckedChanged += new System.EventHandler(this.cbSel_CheckedChanged);
            // 
            // llSel
            // 
            this.llSel.AutoSize = true;
            this.llSel.Location = new System.Drawing.Point(115, 325);
            this.llSel.Name = "llSel";
            this.llSel.Size = new System.Drawing.Size(29, 12);
            this.llSel.TabIndex = 5;
            this.llSel.TabStop = true;
            this.llSel.Text = "反选";
            this.llSel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSel_LinkClicked);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(444, 320);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(75, 23);
            this.btReturn.TabIndex = 3;
            this.btReturn.Text = "返回";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(338, 320);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 21);
            this.tbSearch.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(257, 320);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "模糊查找";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel,
            this.bname,
            this.bauthor,
            this.bPubCom,
            this.bPubDat,
            this.bPrice,
            this.bNum,
            this.borrow});
            this.dgvBooks.Location = new System.Drawing.Point(12, 3);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 23;
            this.dgvBooks.Size = new System.Drawing.Size(782, 313);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // sel
            // 
            this.sel.FalseValue = "0";
            this.sel.HeaderText = "选择";
            this.sel.Name = "sel";
            this.sel.TrueValue = "1";
            this.sel.Width = 30;
            // 
            // bname
            // 
            this.bname.DataPropertyName = "bName";
            this.bname.HeaderText = "书名";
            this.bname.Name = "bname";
            this.bname.ReadOnly = true;
            // 
            // bauthor
            // 
            this.bauthor.DataPropertyName = "bAuthor";
            this.bauthor.HeaderText = "作者";
            this.bauthor.Name = "bauthor";
            this.bauthor.ReadOnly = true;
            // 
            // bPubCom
            // 
            this.bPubCom.DataPropertyName = "bPubCom";
            this.bPubCom.HeaderText = "出版社";
            this.bPubCom.Name = "bPubCom";
            this.bPubCom.ReadOnly = true;
            // 
            // bPubDat
            // 
            this.bPubDat.DataPropertyName = "bPubDat";
            this.bPubDat.HeaderText = "出版日期";
            this.bPubDat.Name = "bPubDat";
            this.bPubDat.ReadOnly = true;
            // 
            // bPrice
            // 
            this.bPrice.DataPropertyName = "bPrice";
            this.bPrice.HeaderText = "价格";
            this.bPrice.Name = "bPrice";
            this.bPrice.ReadOnly = true;
            // 
            // bNum
            // 
            this.bNum.DataPropertyName = "bAmount";
            this.bNum.HeaderText = "余量";
            this.bNum.Name = "bNum";
            this.bNum.ReadOnly = true;
            // 
            // borrow
            // 
            this.borrow.HeaderText = "";
            this.borrow.Name = "borrow";
            this.borrow.Text = "借阅";
            this.borrow.UseColumnTextForLinkValue = true;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.LinkLabel llSel;
        private System.Windows.Forms.CheckBox cbSel;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPubCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPubDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNum;
        private System.Windows.Forms.DataGridViewLinkColumn borrow;
    }
}