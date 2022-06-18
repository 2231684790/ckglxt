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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(this.textBox2.Text == this.textBox3.Text) || (this.textBox2.Text.Length == 0))
            {
                MessageBox.Show("两次密码输入不一致！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String MySQLConnectionString = ConfigurationSettings.AppSettings["coon"].ToString();
      
            String MySQL = "Update [User] Set Password='" + this.textBox2.Text + "'Where UserName='" + this.textBox4.Text + "'AND Password='" + this.textBox1.Text + "'";
            
            SqlConnection Myconnection = new SqlConnection(MySQLConnectionString);
           
            SqlCommand MyCommand = new SqlCommand(MySQL, Myconnection);
            
            MyCommand.Connection.Open();
            
            int MyCount = MyCommand.ExecuteNonQuery();
            
            if (MyCount == 1)
            {
                MessageBox.Show("修改密码成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改密码失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (Myconnection.State == ConnectionState.Open)
            {
                Myconnection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
