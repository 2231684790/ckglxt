using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string loginID = this.textusername.Text;
            string loginPwd = this.textpassword.Text;
            string logintype = this.cbtype.Text;
            //非空验证
            if (loginID == "" || loginPwd == "" || logintype=="登陆类型")
            {
                MessageBox.Show("用户名或类型选择不能为空!", "验证错误:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //根据类型查询用户信息
            string sqlStr = string.Format("select  *from StaffList where StaffLi='{0}' and StaffName='{1}'", logintype, loginID);
            DataTable dt_userInfo = DBHelper.GetDataTable(sqlStr);
            if (dt_userInfo.Rows.Count == 0)
            {
                MessageBox.Show("用户不存在!", "登录失败:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt_userInfo.Rows[0]["StaffPwd"].ToString() != loginPwd)
            {
                MessageBox.Show("密码错误!", "登录失败:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //登录成功保存登录信息
                LoginInfo.StaffID = dt_userInfo.Rows[0]["StaffID"].ToString();
                LoginInfo.StaffName = dt_userInfo.Rows[0]["StaffName"].ToString();
                LoginInfo.StaffPwd = dt_userInfo.Rows[0]["StaffPwd"].ToString();
                LoginInfo.StaffLi = dt_userInfo.Rows[0]["StaffLi"].ToString();


                if (LoginInfo.StaffLi == "管理员")
                {
                    new Mainform().Show();
                }
                if (LoginInfo.StaffLi == "普通用户")
                {
                    new Mainformuser().Show();
                }
                this.Hide();
            }

          
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.cbtype.Items.Add("登陆类型");
            string sqlstr = "select StaffLi from StaffList  group by StaffLi";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            foreach (DataRow row in dt.Rows)
            {
                this.cbtype.Items.Add(row["StaffLi"]);
            }
        }
    }
}
