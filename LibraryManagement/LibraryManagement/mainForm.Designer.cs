namespace LibraryManagement
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmBookManage = new System.Windows.Forms.ToolStripMenuItem();
            this.录入图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdminSignup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUserSignup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUserCanncel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.书籍一览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBookManage,
            this.系统用户管理ToolStripMenuItem,
            this.tsmLogin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmBookManage
            // 
            this.tsmBookManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.录入图书ToolStripMenuItem,
            this.书籍一览ToolStripMenuItem,
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.tsmBookManage.Name = "tsmBookManage";
            this.tsmBookManage.Size = new System.Drawing.Size(92, 21);
            this.tsmBookManage.Text = "图书信息管理";
            // 
            // 录入图书ToolStripMenuItem
            // 
            this.录入图书ToolStripMenuItem.Name = "录入图书ToolStripMenuItem";
            this.录入图书ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.录入图书ToolStripMenuItem.Text = "录入图书";
            this.录入图书ToolStripMenuItem.Click += new System.EventHandler(this.录入图书ToolStripMenuItem_Click);
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.借书ToolStripMenuItem.Text = "借书";
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还书ToolStripMenuItem.Text = "还书";
            // 
            // 系统用户管理ToolStripMenuItem
            // 
            this.系统用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdminSignup,
            this.tsmUserSignup,
            this.tsmUserCanncel});
            this.系统用户管理ToolStripMenuItem.Name = "系统用户管理ToolStripMenuItem";
            this.系统用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // tsmAdminSignup
            // 
            this.tsmAdminSignup.Name = "tsmAdminSignup";
            this.tsmAdminSignup.Size = new System.Drawing.Size(136, 22);
            this.tsmAdminSignup.Text = "管理员注册";
            // 
            // tsmUserSignup
            // 
            this.tsmUserSignup.Name = "tsmUserSignup";
            this.tsmUserSignup.Size = new System.Drawing.Size(136, 22);
            this.tsmUserSignup.Text = "用户注册";
            // 
            // tsmUserCanncel
            // 
            this.tsmUserCanncel.Name = "tsmUserCanncel";
            this.tsmUserCanncel.Size = new System.Drawing.Size(136, 22);
            this.tsmUserCanncel.Text = "用户注销";
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(44, 21);
            this.tsmLogin.Text = "登录";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // 书籍一览ToolStripMenuItem
            // 
            this.书籍一览ToolStripMenuItem.Name = "书籍一览ToolStripMenuItem";
            this.书籍一览ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.书籍一览ToolStripMenuItem.Text = "书籍一览";
            this.书籍一览ToolStripMenuItem.Click += new System.EventHandler(this.书籍一览ToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainFrom_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainFrom_FormClosed);
            this.Load += new System.EventHandler(this.mainFrom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 录入图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdminSignup;
        private System.Windows.Forms.ToolStripMenuItem tsmUserSignup;
        private System.Windows.Forms.ToolStripMenuItem tsmUserCanncel;
        public System.Windows.Forms.ToolStripMenuItem tsmLogin;
        public System.Windows.Forms.ToolStripMenuItem tsmBookManage;
        private System.Windows.Forms.ToolStripMenuItem 书籍一览ToolStripMenuItem;
    }
}

