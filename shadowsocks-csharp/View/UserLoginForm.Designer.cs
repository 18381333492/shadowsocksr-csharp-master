using System.Windows.Forms;

namespace Shadowsocks.View
{
    partial class UserLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPwd = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserPwdLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.PictureCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCode)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(205, 87);
            this.UserName.MaxLength = 20;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(192, 21);
            this.UserName.TabIndex = 0;
            // 
            // UserPwd
            // 
            this.UserPwd.HideSelection = false;
            this.UserPwd.Location = new System.Drawing.Point(205, 130);
            this.UserPwd.Name = "UserPwd";
            this.UserPwd.PasswordChar = '*';
            this.UserPwd.Size = new System.Drawing.Size(192, 21);
            this.UserPwd.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(205, 212);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "登  录";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.Login);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(309, 212);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "重  置";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.Reset);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(157, 90);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(41, 12);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "用户名";
            // 
            // UserPwdLabel
            // 
            this.UserPwdLabel.AutoSize = true;
            this.UserPwdLabel.Location = new System.Drawing.Point(157, 133);
            this.UserPwdLabel.Name = "UserPwdLabel";
            this.UserPwdLabel.Size = new System.Drawing.Size(41, 12);
            this.UserPwdLabel.TabIndex = 6;
            this.UserPwdLabel.Text = "密  码";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(157, 176);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(41, 12);
            this.CodeLabel.TabIndex = 7;
            this.CodeLabel.Text = "验证码";
            // 
            // Code
            // 
            this.Code.HideSelection = false;
            this.Code.Location = new System.Drawing.Point(206, 173);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(85, 21);
            this.Code.TabIndex = 2;
            // 
            // PictureCode
            // 
            this.PictureCode.Location = new System.Drawing.Point(308, 168);
            this.PictureCode.Name = "PictureCode";
            this.PictureCode.Size = new System.Drawing.Size(60, 30);
            this.PictureCode.TabIndex = 9;
            this.PictureCode.TabStop = false;
            this.PictureCode.Click += new System.EventHandler(this.PictureCode_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 346);
            this.Controls.Add(this.PictureCode);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.UserPwdLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.UserPwd);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.PictureCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPwd;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserPwdLabel;
        private System.Windows.Forms.Label CodeLabel;
        private TextBox Code;
        private PictureBox PictureCode;
    }
}