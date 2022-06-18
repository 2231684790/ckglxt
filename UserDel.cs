using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace 仓库信息管理系统
{
    public partial class UserDel : Form
    {
        public UserDel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要删除这条数据！", "删除信息", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String str = ConfigurationSettings.AppSettings["coon"].ToString();
                SqlConnection conn = new SqlConnection(str);
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }

                SqlDataAdapter d = new SqlDataAdapter();
                d.DeleteCommand = new SqlCommand("DELETE from Users where UID='" + textBox1.Text + "'", conn);
                d.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                //RefreshList();
            }
        }

        private void UserDel_Load(object sender, EventArgs e)
        {
          //  RefreshList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}
