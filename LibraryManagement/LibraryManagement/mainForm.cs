using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainFrom_Load(object sender, EventArgs e)
        {
            tsmBookManage.Enabled = false;
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name=="LoginForm")
                {
                    f.Activate();
                    return;
                }
            }
            LoginForm lf = new LoginForm();
            lf.MdiParent = this;
            lf.StartPosition = FormStartPosition.CenterParent;
            lf.Show();
        }

        private void mainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要离开本程序吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void mainFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("欢迎下次使用");
        }

        private void 录入图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name=="AddForm")
                {
                    f.Activate();
                    return;
                }
            }
            AddForm af = new AddForm();
            af.MdiParent = this;
            af.StartPosition = FormStartPosition.CenterParent;
            af.Show();
        }

        private void 书籍一览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.Name == "BooksForm")
                {
                    f.Activate();
                    return;
                }
            }
            BooksForm bf = new BooksForm();
            bf.StartPosition = FormStartPosition.CenterScreen;
            bf.Show();



        }
    }
}
