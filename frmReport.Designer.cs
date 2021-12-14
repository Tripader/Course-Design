namespace student
{
    partial class frmReport
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lCreit = new System.Windows.Forms.Label();
            this.成绩 = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.lCname = new System.Windows.Forms.Label();
            this.学期 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.学号 = new System.Windows.Forms.TextBox();
            this.课程编号 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gold;
            this.btnCancel.Location = new System.Drawing.Point(425, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 26);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Gold;
            this.btnChange.Location = new System.Drawing.Point(317, 251);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(87, 26);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "保  存";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Location = new System.Drawing.Point(223, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 26);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gold;
            this.btnInsert.Location = new System.Drawing.Point(127, 251);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(68, 26);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "插  入";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lCreit
            // 
            this.lCreit.AutoSize = true;
            this.lCreit.Location = new System.Drawing.Point(10, 53);
            this.lCreit.Name = "lCreit";
            this.lCreit.Size = new System.Drawing.Size(65, 12);
            this.lCreit.TabIndex = 17;
            this.lCreit.Text = "课程编号：";
            // 
            // 成绩
            // 
            this.成绩.Location = new System.Drawing.Point(361, 4);
            this.成绩.Name = "成绩";
            this.成绩.Size = new System.Drawing.Size(102, 21);
            this.成绩.TabIndex = 16;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(10, 13);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(53, 12);
            this.lname.TabIndex = 14;
            this.lname.Text = "学  号：";
            this.lname.Click += new System.EventHandler(this.lname_Click);
            // 
            // dataGView
            // 
            this.dataGView.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(31, 101);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(487, 135);
            this.dataGView.TabIndex = 12;
            // 
            // lCname
            // 
            this.lCname.AutoSize = true;
            this.lCname.Location = new System.Drawing.Point(268, 13);
            this.lCname.Name = "lCname";
            this.lCname.Size = new System.Drawing.Size(53, 12);
            this.lCname.TabIndex = 11;
            this.lCname.Text = "成  绩：";
            // 
            // 学期
            // 
            this.学期.FormattingEnabled = true;
            this.学期.Items.AddRange(new object[] {
            "2013 第一学期",
            "2013 第二学期",
            "2014 第一学期",
            "2014 第二学期",
            "2015 第一学期",
            "2015 第二学期",
            "2016 第一学期",
            "2016 第二学期"});
            this.学期.Location = new System.Drawing.Point(361, 44);
            this.学期.Name = "学期";
            this.学期.Size = new System.Drawing.Size(102, 20);
            this.学期.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.学号);
            this.panel1.Controls.Add(this.课程编号);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.学期);
            this.panel1.Controls.Add(this.lCname);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.成绩);
            this.panel1.Controls.Add(this.lCreit);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 76);
            this.panel1.TabIndex = 24;
            // 
            // 学号
            // 
            this.学号.Location = new System.Drawing.Point(82, 4);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(90, 21);
            this.学号.TabIndex = 26;
            // 
            // 课程编号
            // 
            this.课程编号.FormattingEnabled = true;
            this.课程编号.Location = new System.Drawing.Point(82, 44);
            this.课程编号.Name = "课程编号";
            this.课程编号.Size = new System.Drawing.Size(90, 20);
            this.课程编号.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "学  期：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(31, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "查询所有";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(551, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩信息录入窗体";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lCreit;
        private System.Windows.Forms.TextBox 成绩;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label lCname;
        private System.Windows.Forms.ComboBox 学期;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox 学号;
        private System.Windows.Forms.ComboBox 课程编号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}