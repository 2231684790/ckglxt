namespace WindowsFormsApplication1
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.type = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.ForeColor = System.Drawing.Color.OrangeRed;
            this.type.Location = new System.Drawing.Point(64, 170);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(53, 12);
            this.type.TabIndex = 0;
            this.type.Text = "类  型：";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.ForeColor = System.Drawing.Color.OrangeRed;
            this.username.Location = new System.Drawing.Point(64, 212);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 12);
            this.username.TabIndex = 1;
            this.username.Text = "用户名：";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.ForeColor = System.Drawing.Color.OrangeRed;
            this.password.Location = new System.Drawing.Point(64, 253);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 12);
            this.password.TabIndex = 2;
            this.password.Text = "密  码：";
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(123, 209);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(145, 21);
            this.textusername.TabIndex = 0;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(123, 250);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(145, 21);
            this.textpassword.TabIndex = 1;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(301, 207);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "登陆";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(301, 248);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(75, 23);
            this.btclose.TabIndex = 4;
            this.btclose.Text = "退出";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // cbtype
            // 
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(123, 167);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(145, 20);
            this.cbtype.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.名侦探柯南12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 284);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆窗体";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.ComboBox cbtype;
    }
}

