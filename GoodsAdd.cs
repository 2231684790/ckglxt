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
    public partial class GoodsAdd : Form
    {
        public GoodsAdd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//添加
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
                    d.InsertCommand = new SqlCommand("INSERT INTO Goods(GoodID,GoodName,GoodPrice,GoodProvider,GoodQuantity)Values('" + textBox1.Text + "',+'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", conn);
                    d.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    textBox1.Clear(); ;
                    textBox2.Clear(); ;
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    MessageBox.Show("添加成功");
                }
                RefreshList();
        }
           
        

        private void Good_Load(object sender, EventArgs e)
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
            String myselect = "select * from Goods";
            SqlDataAdapter adap = new SqlDataAdapter(myselect, conn);
            DataSet dts = new DataSet();
            adap.Fill(dts);
            dataGridView1.DataSource = dts.Tables[0];

            conn.Close();
        }

        //退出
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //修改
        private void button3_Click(object sender, EventArgs e)
        {
        

            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            SqlDataAdapter d = new SqlDataAdapter();
            String s = "UPDATE Goods SET GoodID='"+ textBox1.Text + "',GoodName='" + textBox2.Text + "',GoodPrice='" + textBox3.Text + "',GoodProvider='" + textBox4.Text + "',GoodQuantity='"+textBox5+"'where GoodID='"+textBox1.Text+"'";
            d.UpdateCommand = new SqlCommand(s, conn);
            d.UpdateCommand.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            RefreshList();
    }


       //删除
        private void button4_Click(object sender, EventArgs e)
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
                d.DeleteCommand = new SqlCommand("DELETE from Goods where GoodID='" + textBox1.Text + "'", conn);
                d.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                RefreshList();
            }
        }
        
        
        //查询
        private void button5_Click(object sender, EventArgs e)
        {
            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            String myselect = "select * from Goods where GoodID='" + textBox6.Text + "'";
            SqlCommand comm=new SqlCommand (myselect,conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                textBox4.Text = reader[3].ToString();
                textBox5.Text = reader[4].ToString();


            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        //显示
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            }
            catch (Exception es)
            {
                Console.Write(es.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)//清除
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}