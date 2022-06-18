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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("请输入数据，进行添加");
            else
            {
                String str = ConfigurationSettings.AppSettings["coon"].ToString();
                SqlConnection conn = new SqlConnection(str);
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }
                SqlDataAdapter d = new SqlDataAdapter();
                d.InsertCommand = new SqlCommand("INSERT INTO Users(UID,Upassword,Usex,UName,UAddress,UTel)Values('" + textBox1.Text + "',+'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "',+'" + textBox5.Text + "',+'" + textBox6.Text + "')", conn);
                d.InsertCommand.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                MessageBox.Show("添加成功");
            }
           RefreshList();
        }
         private void UserAdd_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            String myselect = "select * from Users";
            SqlDataAdapter adap = new SqlDataAdapter(myselect, conn);
            DataSet dts = new DataSet();
            adap.Fill(dts);
            //dataGridView1.DataSource = dts.Tables[0];

            conn.Close();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
          Close();
        }
    }
}
