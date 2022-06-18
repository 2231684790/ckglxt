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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = dts.Tables[0];

            conn.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            UserAdd uadd = new UserAdd();
            uadd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserModify umodify = new UserModify();
            umodify.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserDel udel = new UserDel();
            udel.Show();
        }

        private void button1_Click(object sender, EventArgs e)//查询
        {
            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            String myselect = "select * from Users where UID='" + comboBox1.Text + "'";
            SqlCommand comm = new SqlCommand(myselect, conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                textBox4.Text = reader[3].ToString();
                textBox5.Text = reader[4].ToString();
                textBox6.Text = reader[5].ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            }
            catch (Exception es)
            {
                Console.Write(es.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
