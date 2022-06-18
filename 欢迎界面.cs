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
    public partial class 欢迎界面 : Form
    {
        public 欢迎界面()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["coon"].ToString());
            String sql = "select * from [User]";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "UserName";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            String str1 = comboBox1.SelectedValue.ToString().Trim();
            String str2 = textBox2.Text.ToString().Trim();
            SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["coon"].ToString());
            String sql = "select * from [User]";
            if (ConnectionState.Closed == conn.State)
            {
                conn .Open();
            }
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                if ((read[0].ToString().Trim() == str1) && (read[1].ToString().Trim() == str2))//Trim()函数是将字符串开头和结尾的空格去除
                {
                    //DialogResult = DialogResult.OK;
                    //this.Close();
                    主界面 frm2 = new 主界面();
                    frm2.ShowDialog();
                    n = 1;
                    break;
                }
         
                             
            }

            if (n==0)
            {
                 MessageBox.Show("对不起，您的用户名/密码不正确，请重新输入");  
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();//退出系统
        }
    }
}
