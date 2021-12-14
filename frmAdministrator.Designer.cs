namespace student
{
    partial class frmAdministrator
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
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生源信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级变更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.返回登入界面 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.教师管理ToolStripMenuItem,
            this.班级管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生成绩ToolStripMenuItem,
            this.生源信息ToolStripMenuItem,
            this.学生信息ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            this.学生管理ToolStripMenuItem.Click += new System.EventHandler(this.学生管理ToolStripMenuItem_Click);
            // 
            // 学生成绩ToolStripMenuItem
            // 
            this.学生成绩ToolStripMenuItem.Name = "学生成绩ToolStripMenuItem";
            this.学生成绩ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生成绩ToolStripMenuItem.Text = "学生成绩";
            this.学生成绩ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩ToolStripMenuItem_Click);
            // 
            // 生源信息ToolStripMenuItem
            // 
            this.生源信息ToolStripMenuItem.Name = "生源信息ToolStripMenuItem";
            this.生源信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.生源信息ToolStripMenuItem.Text = "生源信息";
            this.生源信息ToolStripMenuItem.Click += new System.EventHandler(this.生源信息ToolStripMenuItem_Click);
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生信息ToolStripMenuItem.Text = "学生信息";
            this.学生信息ToolStripMenuItem.Click += new System.EventHandler(this.学生信息ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级课程管理ToolStripMenuItem,
            this.课程成绩查询ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            this.课程管理ToolStripMenuItem.Click += new System.EventHandler(this.课程管理ToolStripMenuItem_Click);
            // 
            // 班级课程管理ToolStripMenuItem
            // 
            this.班级课程管理ToolStripMenuItem.Name = "班级课程管理ToolStripMenuItem";
            this.班级课程管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班级课程管理ToolStripMenuItem.Text = "班级课程管理";
            this.班级课程管理ToolStripMenuItem.Click += new System.EventHandler(this.班级课程管理ToolStripMenuItem_Click);
            // 
            // 课程成绩查询ToolStripMenuItem
            // 
            this.课程成绩查询ToolStripMenuItem.Name = "课程成绩查询ToolStripMenuItem";
            this.课程成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.课程成绩查询ToolStripMenuItem.Text = "课程成绩查询";
            this.课程成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.课程成绩查询ToolStripMenuItem_Click);
            // 
            // 教师管理ToolStripMenuItem
            // 
            this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
            this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.教师管理ToolStripMenuItem.Text = "教师管理";
            this.教师管理ToolStripMenuItem.Click += new System.EventHandler(this.教师管理ToolStripMenuItem_Click);
            // 
            // 班级管理ToolStripMenuItem
            // 
            this.班级管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级变更ToolStripMenuItem,
            this.班级学生管理ToolStripMenuItem});
            this.班级管理ToolStripMenuItem.Name = "班级管理ToolStripMenuItem";
            this.班级管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.班级管理ToolStripMenuItem.Text = "班级管理";
            this.班级管理ToolStripMenuItem.Click += new System.EventHandler(this.班级管理ToolStripMenuItem_Click);
            // 
            // 班级变更ToolStripMenuItem
            // 
            this.班级变更ToolStripMenuItem.Name = "班级变更ToolStripMenuItem";
            this.班级变更ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班级变更ToolStripMenuItem.Text = "班级变更";
            this.班级变更ToolStripMenuItem.Click += new System.EventHandler(this.班级变更ToolStripMenuItem_Click);
            // 
            // 班级学生管理ToolStripMenuItem
            // 
            this.班级学生管理ToolStripMenuItem.Name = "班级学生管理ToolStripMenuItem";
            this.班级学生管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班级学生管理ToolStripMenuItem.Text = "班级学生管理";
            this.班级学生管理ToolStripMenuItem.Click += new System.EventHandler(this.班级学生管理ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Location = new System.Drawing.Point(24, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 144);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome.Location = new System.Drawing.Point(17, 12);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(251, 124);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "你好！";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // 返回登入界面
            // 
            this.返回登入界面.BackColor = System.Drawing.Color.Gold;
            this.返回登入界面.Location = new System.Drawing.Point(47, 213);
            this.返回登入界面.Name = "返回登入界面";
            this.返回登入界面.Size = new System.Drawing.Size(235, 23);
            this.返回登入界面.TabIndex = 2;
            this.返回登入界面.Text = "返回登入界面";
            this.返回登入界面.UseVisualStyleBackColor = false;
            this.返回登入界面.Click += new System.EventHandler(this.返回登入界面_Click);
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.返回登入界面);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.Load += new System.EventHandler(this.frmAdministrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级变更ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button 返回登入界面;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生源信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
    }
}