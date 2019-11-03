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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string pwd = tbPwd.Text.Trim();
            if (name == "" || pwd == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                string cmdStr = "select count(*) from admin where aname='" + name + "' and aPwd='" + pwd + "'";
                if (db.checkCount(cmdStr) == 0)
                {
                    MessageBox.Show("用户名或密码不正确！");
                    tbPwd.Clear();
                }
                else
                {
                    MessageBox.Show("登录成功！");
                    mainForm mf = new mainForm();
                    mf = (mainForm)this.MdiParent;
                    mf.Text += "-----当前用户：" + name;
                    mf.tsmLogin.Enabled = false;
                    mf.tsmBookManage.Enabled = true;
                    this.Close();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
