using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storemgForm storemgForm = new storemgForm();
            storemgForm.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            this.label5.Text = DateTime.Now.ToString();
            if (LoginInfo.StaffLi == "管理员")
            {

                this.label6.Text =  LoginInfo.StaffName+"[管理员]";
            }
            if (LoginInfo.StaffLi == "普通用户")
            {
                this.label6.Text = LoginInfo.StaffName + "[普通用户]";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personForm personForm = new personForm();
            personForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            goodsForm goodsForm = new goodsForm();
            goodsForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruku ruku = new ruku();
            ruku.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chuku chuku = new chuku();
            chuku.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kucun kucun = new kucun();
            kucun.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reportform reportform = new reportform();
            reportform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rukurpform rukurpform = new rukurpform();
            rukurpform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chukupform chukupform = new chukupform();
            chukupform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Excel Excel = new Excel();
            Excel.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label5.Text = DateTime.Now.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
