namespace Shadowsocks.View
{
    partial class NewConfigForm
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
            this.ServerlistBox = new System.Windows.Forms.ListBox();
            this.ServerGroupBox = new System.Windows.Forms.GroupBox();
            this.LinkGroupBox = new System.Windows.Forms.GroupBox();
            this.TipValue = new System.Windows.Forms.TextBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.ServerBtn = new System.Windows.Forms.Button();
            this.InternetValue = new System.Windows.Forms.Label();
            this.MaxValue = new System.Windows.Forms.Label();
            this.PeopleValue = new System.Windows.Forms.Label();
            this.ServerValue = new System.Windows.Forms.Label();
            this.InternetLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ServerGroupBox.SuspendLayout();
            this.LinkGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerlistBox
            // 
            this.ServerlistBox.DisplayMember = "text";
            this.ServerlistBox.FormattingEnabled = true;
            this.ServerlistBox.ItemHeight = 12;
            this.ServerlistBox.Location = new System.Drawing.Point(6, 27);
            this.ServerlistBox.Name = "ServerlistBox";
            this.ServerlistBox.Size = new System.Drawing.Size(238, 400);
            this.ServerlistBox.TabIndex = 0;
            this.ServerlistBox.ValueMember = "value";
            this.ServerlistBox.Click += new System.EventHandler(this.ServerlistBox_Click);
            this.ServerlistBox.SelectedIndexChanged += new System.EventHandler(this.ServerlistBox_SelectedIndexChanged);
            // 
            // ServerGroupBox
            // 
            this.ServerGroupBox.Controls.Add(this.ServerlistBox);
            this.ServerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ServerGroupBox.Name = "ServerGroupBox";
            this.ServerGroupBox.Size = new System.Drawing.Size(250, 433);
            this.ServerGroupBox.TabIndex = 1;
            this.ServerGroupBox.TabStop = false;
            this.ServerGroupBox.Text = "服务器列表";
            // 
            // LinkGroupBox
            // 
            this.LinkGroupBox.Controls.Add(this.TipValue);
            this.LinkGroupBox.Controls.Add(this.TipLabel);
            this.LinkGroupBox.Controls.Add(this.ServerBtn);
            this.LinkGroupBox.Controls.Add(this.InternetValue);
            this.LinkGroupBox.Controls.Add(this.MaxValue);
            this.LinkGroupBox.Controls.Add(this.PeopleValue);
            this.LinkGroupBox.Controls.Add(this.ServerValue);
            this.LinkGroupBox.Controls.Add(this.InternetLabel);
            this.LinkGroupBox.Controls.Add(this.MaxLabel);
            this.LinkGroupBox.Controls.Add(this.PeopleLabel);
            this.LinkGroupBox.Controls.Add(this.ServerLabel);
            this.LinkGroupBox.Location = new System.Drawing.Point(268, 12);
            this.LinkGroupBox.Name = "LinkGroupBox";
            this.LinkGroupBox.Size = new System.Drawing.Size(339, 433);
            this.LinkGroupBox.TabIndex = 2;
            this.LinkGroupBox.TabStop = false;
            this.LinkGroupBox.Text = "连接信息：";
            // 
            // TipValue
            // 
            this.TipValue.Location = new System.Drawing.Point(69, 271);
            this.TipValue.Multiline = true;
            this.TipValue.Name = "TipValue";
            this.TipValue.Size = new System.Drawing.Size(248, 131);
            this.TipValue.TabIndex = 10;
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(22, 271);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(41, 12);
            this.TipLabel.TabIndex = 9;
            this.TipLabel.Text = "注意：";
            // 
            // ServerBtn
            // 
            this.ServerBtn.Location = new System.Drawing.Point(119, 189);
            this.ServerBtn.Name = "ServerBtn";
            this.ServerBtn.Size = new System.Drawing.Size(99, 23);
            this.ServerBtn.TabIndex = 8;
            this.ServerBtn.Text = "接入服务";
            this.ServerBtn.UseVisualStyleBackColor = true;
            // 
            // InternetValue
            // 
            this.InternetValue.AutoSize = true;
            this.InternetValue.Location = new System.Drawing.Point(167, 131);
            this.InternetValue.Name = "InternetValue";
            this.InternetValue.Size = new System.Drawing.Size(0, 12);
            this.InternetValue.TabIndex = 7;
            // 
            // MaxValue
            // 
            this.MaxValue.AutoSize = true;
            this.MaxValue.Location = new System.Drawing.Point(167, 93);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(0, 12);
            this.MaxValue.TabIndex = 6;
            // 
            // PeopleValue
            // 
            this.PeopleValue.AutoSize = true;
            this.PeopleValue.Location = new System.Drawing.Point(167, 58);
            this.PeopleValue.Name = "PeopleValue";
            this.PeopleValue.Size = new System.Drawing.Size(0, 12);
            this.PeopleValue.TabIndex = 5;
            // 
            // ServerValue
            // 
            this.ServerValue.AutoSize = true;
            this.ServerValue.Location = new System.Drawing.Point(167, 27);
            this.ServerValue.Name = "ServerValue";
            this.ServerValue.Size = new System.Drawing.Size(0, 12);
            this.ServerValue.TabIndex = 4;
            // 
            // InternetLabel
            // 
            this.InternetLabel.AutoSize = true;
            this.InternetLabel.Location = new System.Drawing.Point(22, 131);
            this.InternetLabel.Name = "InternetLabel";
            this.InternetLabel.Size = new System.Drawing.Size(65, 12);
            this.InternetLabel.TabIndex = 3;
            this.InternetLabel.Text = "平均网速：";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(22, 93);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(77, 12);
            this.MaxLabel.TabIndex = 2;
            this.MaxLabel.Text = "最多可接入：";
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(22, 58);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(89, 12);
            this.PeopleLabel.TabIndex = 1;
            this.PeopleLabel.Text = "当前接入用户：";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(22, 27);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(53, 12);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "服务器：";
            // 
            // NewConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 457);
            this.Controls.Add(this.ServerGroupBox);
            this.Controls.Add(this.LinkGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewConfigForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewConfigForm_FormClosed);
            this.ServerGroupBox.ResumeLayout(false);
            this.LinkGroupBox.ResumeLayout(false);
            this.LinkGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ServerlistBox;
        private System.Windows.Forms.GroupBox ServerGroupBox;
        private System.Windows.Forms.GroupBox LinkGroupBox;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label PeopleValue;
        private System.Windows.Forms.Label ServerValue;
        private System.Windows.Forms.Label InternetLabel;
        private System.Windows.Forms.Label InternetValue;
        private System.Windows.Forms.Label MaxValue;
        private System.Windows.Forms.TextBox TipValue;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Button ServerBtn;
    }
}