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
    public partial class UserModify : Form
    {
        public UserModify()
        {
            InitializeComponent();
        }

        private void UserModify_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            SqlDataAdapter d = new SqlDataAdapter();
            String s = "UPDATE Users SET UID='" + textBox1.Text + "',Upassword='" + textBox2.Text + "',USex='" + textBox3.Text + "',UName='" + textBox4.Text + "',UAddress='" + textBox5.Text + "',UTel='" + textBox6.Text + "'where UID='" + textBox1.Text + "'";
            d.UpdateCommand = new SqlCommand(s, conn);
            d.UpdateCommand.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            //RefreshList();
        }
    }
}
