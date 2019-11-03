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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }
        private void bdBooks() 
        {
            string cmdStr = "select * from books";
            DataSet ds = new DataSet();
            ds=db.getData(cmdStr);
            dgvBooks.DataSource = ds.Tables[0];
            foreach (DataGridViewRow dgvr in dgvBooks.Rows)
            {
                dgvr.Cells["sel"].Value = 0;
            }

        }
        private void borrowBook()
        {

        }
        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==7)
            {
                if (MessageBox.Show("确定要借阅吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string name = dgvBooks.Rows[e.RowIndex].Cells["bname"].Value.ToString();
                    int amount = int.Parse(dgvBooks.Rows[e.RowIndex].Cells["bNum"].Value.ToString());
                    amount--;
                    if(db.updateData("update books set bAmount='" + amount + "' where bname='" + name + "'") > 0)
                    {
                        bdBooks();
                        MessageBox.Show("书本已经借出");
                    }
                      
                }
                    
            }
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            dgvBooks.AutoGenerateColumns = false;
            bdBooks();
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string sear = tbSearch.Text.Trim();
            string csStr = "select * from books where bName like'%" + sear + "%'";
            DataSet ds = new DataSet();
            ds = db.getData(csStr);
            dgvBooks.DataSource = ds.Tables[0];

        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            bdBooks();
        }

        

        private void cbSel_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSel.Checked)
            {
                foreach(DataGridViewRow dgvr in dgvBooks.Rows)
                {
                    dgvr.Cells["sel"].Value = 1;
                }
                
            }
            else
            {
                foreach (DataGridViewRow dgvr in dgvBooks.Rows)
                {
                    dgvr.Cells["sel"].Value = 0;
                }
            }

        }

        private void llSel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach(DataGridViewRow dgvr in dgvBooks.Rows)
            {
                if(dgvr.Cells["sel"].Value.ToString() == "0")
                {
                    dgvr.Cells["sel"].Value = 1;
                }
                else
                {
                    dgvr.Cells["sel"].Value = 0;
                }

            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow dgvr in dgvBooks.Rows)
            {
                
                if (dgvr.Cells["sel"].Value.ToString() == "1")
                {
                    string name = dgvr.Cells["bname"].Value.ToString();
                    int amount = int.Parse(dgvr.Cells["bNum"].Value.ToString());
                    if (db.updateData("update books set bAmount='" + amount + "' where bname='" + name + "'")>0)
                    {
                        
                        //MessageBox.Show("更新成功");
                        count++;
                    }
                }
                //else
                //{
                //    MessageBox.Show("您没有选中");
                //    return;
                //}
                
            }
            if (count > 0)
            {
                MessageBox.Show("成功更新了" + count + "条数据");

            }
            else
            {
                MessageBox.Show("您没有选中数据哦！");
                return;
            }
        }
    }
}
