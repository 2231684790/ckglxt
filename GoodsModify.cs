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
    public partial class GoodsModify : Form
    {
        public GoodsModify()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            String str = ConfigurationSettings.AppSettings["coon"].ToString();
            SqlConnection conn = new SqlConnection(str);
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            String myselect = "select * from Record";
            SqlDataAdapter adap = new SqlDataAdapter(myselect, conn);
            DataSet dts = new DataSet();
            adap.Fill(dts);
            dataGridView1.DataSource = dts.Tables[0];

            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql=null,sql1=null;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("请输入数据，进行添加");
            else
            {
                String str = ConfigurationSettings.AppSettings["coon"].ToString();
                SqlConnection conn = new SqlConnection(str);
                SqlConnection con = new SqlConnection(str);
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlDataAdapter d = new SqlDataAdapter();
                if (radioButton1.Checked == true)
                {
                    sql = "INSERT INTO Record(RecordID,RecordGoodID,RecordQuantity,RecordManager,RecordTime,RecordType)Values('" + textBox1.Text + "',+'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value + "','" + radioButton1.Text + "')";
                   sql1 = "update Goods set GoodQuantity=GoodQuantity+'" + textBox3.Text + "'where GoodID='"+textBox2.Text+"'";
                }
                else if (radioButton2.Checked == true)
                {
                    sql1 = "update Goods set GoodQuantity=GoodQuantity-'" + textBox3.Text + "'where GoodID='"+textBox2.Text+"'";
                    sql = "INSERT INTO Record(RecordID,RecordGoodID,RecordQuantity,RecordManager,RecordTime,RecordType)Values('" + textBox1.Text + "',+'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value + "','" + radioButton2.Text + "')";
                }
                    d.InsertCommand = new SqlCommand(sql, conn);
                d.InsertCommand.ExecuteNonQuery();
                SqlCommand com = new SqlCommand(sql1,con);
                com.ExecuteNonQuery();
                conn.Close();             
                MessageBox.Show("已提交完毕");
            }
            RefreshList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

         
        

        private void GoodsModify_Load(object sender, EventArgs e)
        {
            CenterToParent();
            RefreshList();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString() == "入库")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
            }
            catch (Exception es)
            {
                Console.Write(es.ToString());
            }
        }
        }
    }

