﻿namespace SYStem
{
    partial class LoginForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.passwordTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.pwdlabel = new CCWin.SkinControl.SkinLabel();
            this.loginBtn = new CCWin.SkinControl.SkinButton();
            this.cancleBtn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // usernameTBox
            // 
            this.usernameTBox.BackColor = System.Drawing.Color.AliceBlue;
            this.usernameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameTBox.Location = new System.Drawing.Point(507, 199);
            this.usernameTBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(145, 23);
            this.usernameTBox.TabIndex = 0;
            this.usernameTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.usernameTBox.WaterText = "";
            // 
            // passwordTBox
            // 
            this.passwordTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTBox.Location = new System.Drawing.Point(507, 269);
            this.passwordTBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(145, 23);
            this.passwordTBox.TabIndex = 1;
            this.passwordTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTBox.WaterText = "";
            this.passwordTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTBox_KeyDown);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold);
            this.skinLabel1.Location = new System.Drawing.Point(382, 199);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(128, 27);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "用户名：";
            // 
            // pwdlabel
            // 
            this.pwdlabel.AutoSize = true;
            this.pwdlabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdlabel.BorderColor = System.Drawing.Color.White;
            this.pwdlabel.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Bold);
            this.pwdlabel.Location = new System.Drawing.Point(381, 269);
            this.pwdlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwdlabel.Name = "pwdlabel";
            this.pwdlabel.Size = new System.Drawing.Size(129, 27);
            this.pwdlabel.TabIndex = 3;
            this.pwdlabel.Text = "密  码：";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.loginBtn.DownBack = null;
            this.loginBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.loginBtn.Location = new System.Drawing.Point(427, 329);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.MouseBack = null;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NormlBack = null;
            this.loginBtn.Size = new System.Drawing.Size(100, 40);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancleBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cancleBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancleBtn.DownBack = null;
            this.cancleBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.cancleBtn.Location = new System.Drawing.Point(567, 329);
            this.cancleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancleBtn.MouseBack = null;
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.NormlBack = null;
            this.cancleBtn.Size = new System.Drawing.Size(100, 40);
            this.cancleBtn.TabIndex = 5;
            this.cancleBtn.Text = "退出";
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.cancleBtn;
            this.ClientSize = new System.Drawing.Size(1135, 525);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwdlabel);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.usernameTBox);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Radius = 12;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动化阅卷系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox usernameTBox;
        private CCWin.SkinControl.SkinWaterTextBox passwordTBox;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel pwdlabel;
        private CCWin.SkinControl.SkinButton loginBtn;
        private CCWin.SkinControl.SkinButton cancleBtn;
    }
}

