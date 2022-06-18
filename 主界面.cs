using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 仓库信息管理系统
{
    public partial class 主界面 : Form
    {
        public 主界面()
        {
            InitializeComponent();
        }

        private void 主界面_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoodsAdd ga= new GoodsAdd();
            ga.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoodsModify gm = new GoodsModify();
            gm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users Users = new Users();
            Users.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePassword cpd = new ChangePassword();
            cpd.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
