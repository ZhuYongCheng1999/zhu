using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibraryManagement
{
    class db
    {
        public static SqlConnection createCon()
        {
            
            return new SqlConnection("server=106.54.134.13;database=Library;uid=sa;pwd=ZHUyongcheng123;");
        }

        static SqlConnection conn = createCon();
        static SqlCommand cmd;
        static SqlDataAdapter sda;
        static DataSet ds;

        public static int checkCount(string cmdText)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Connection = conn;
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }
        public static DataSet getData(string cmdText)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Connection = conn;
                sda = new SqlDataAdapter(cmd);//将命令得到的数据加载到桥梁sda中
                ds = new DataSet();//初始化本地数据集ds
                sda.Fill(ds);//桥梁上的数据填充到本地数据集（仓库）中
                conn.Close();
                return ds;
            }
        }
        public static int updateData(string cmdText)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = cmdText;//命令的内容
                cmd.Connection = conn;//命令所在的连接
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();//打开连接
                }
                int count = Convert.ToInt32(cmd.ExecuteNonQuery());//执行更新，影响的行数赋值给变量count
                conn.Close();//关闭连接
                return count;
            }
        }



    }
}
