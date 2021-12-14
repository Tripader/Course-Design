namespace student
{
    partial class frmStudent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回登入界面 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.密码 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩查询ToolStripMenuItem,
            this.选课情况ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // 选课情况ToolStripMenuItem
            // 
            this.选课情况ToolStripMenuItem.Name = "选课情况ToolStripMenuItem";
            this.选课情况ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.选课情况ToolStripMenuItem.Text = "选课情况";
            this.选课情况ToolStripMenuItem.Click += new System.EventHandler(this.选课情况ToolStripMenuItem_Click);
            // 
            // 返回登入界面
            // 
            this.返回登入界面.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.返回登入界面.ForeColor = System.Drawing.Color.Magenta;
            this.返回登入界面.Location = new System.Drawing.Point(27, 242);
            this.返回登入界面.Name = "返回登入界面";
            this.返回登入界面.Size = new System.Drawing.Size(317, 25);
            this.返回登入界面.TabIndex = 8;
            this.返回登入界面.Text = "返回登入界面";
            this.返回登入界面.UseVisualStyleBackColor = false;
            this.返回登入界面.Click += new System.EventHandler(this.返回登入界面_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Controls.Add(this.密码);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Location = new System.Drawing.Point(27, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 186);
            this.panel1.TabIndex = 7;
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome.Location = new System.Drawing.Point(17, 12);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(281, 137);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "你好！";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 密码
            // 
            this.密码.BackColor = System.Drawing.Color.Violet;
            this.密码.Location = new System.Drawing.Point(95, 152);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(137, 21);
            this.密码.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "密码修改：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(243, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(374, 279);
            this.Controls.Add(this.返回登入界面);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生界面 ";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课情况ToolStripMenuItem;
        private System.Windows.Forms.Button 返回登入界面;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.TextBox 密码;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}