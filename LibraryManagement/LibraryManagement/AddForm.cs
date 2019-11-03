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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btAdd_Click(object sender, EventArgs e)
        {
            string bName = tbName.Text.Trim();
            string bAuthor = tbAuthor.Text.Trim();
            string bPubCom = tbPubCom.Text.Trim();
            string bPubDate = tbPubDate.Text.Trim();
            string bISBN = tbISBN.Text.Trim();
            string bPrice = tbPrice.Text.Trim();
            string bAmount = tbAmount.Text.Trim();
            
            string cmdAdd = "insert into books (bName,bAuthor,bPubCom,bPubDat,ISBN,bPrice,bAmount) values('" + bName + "','" + bAuthor + "','" + bPubCom + "','" + bPubDate + "','" + bISBN + "','" + bPrice + "','" + bAmount + "')";
            if (bName == "" || bAuthor == "" || bPubCom=="" || bPubDate == "" || bISBN == "" || bPrice == "" || bAmount == "")
            {
                MessageBox.Show("信息不能为空，请补全信息");

            }
            else
            {
                if (db.updateData(cmdAdd) > 0)
                {
                    tbName.Clear();
                    tbAuthor.Clear();
                    tbPubCom.Clear();
                    tbPubDate.Clear();
                    tbISBN.Clear();
                    tbPrice.Clear();
                    tbAmount.Clear();
                    MessageBox.Show("添加成功");
                    count++;
                }
            }
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("本次共录入图书" +count+ "本！");
        }
    }
}
