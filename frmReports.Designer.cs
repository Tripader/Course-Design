namespace student
{
    partial class frmReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.年段 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.学年 = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lDno = new System.Windows.Forms.Label();
            this.Deptno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.ForeColor = System.Drawing.Color.Cyan;
            this.btnCancel.Location = new System.Drawing.Point(26, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(396, 26);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGView
            // 
            this.dataGView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(26, 75);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(396, 135);
            this.dataGView.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.年段);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.学年);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lDno);
            this.panel1.Controls.Add(this.Deptno);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 45);
            this.panel1.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "软件工程",
            "数学",
            "艺术"});
            this.comboBox1.Location = new System.Drawing.Point(38, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 20);
            this.comboBox1.TabIndex = 22;
            // 
            // 年段
            // 
            this.年段.FormattingEnabled = true;
            this.年段.Items.AddRange(new object[] {
            "大一",
            "大二",
            "大三",
            "大四"});
            this.年段.Location = new System.Drawing.Point(232, 12);
            this.年段.Name = "年段";
            this.年段.Size = new System.Drawing.Size(63, 20);
            this.年段.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "年段：";
            // 
            // 学年
            // 
            this.学年.FormattingEnabled = true;
            this.学年.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016"});
            this.学年.Location = new System.Drawing.Point(129, 12);
            this.学年.Name = "学年";
            this.学年.Size = new System.Drawing.Size(57, 20);
            this.学年.TabIndex = 19;
            this.学年.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Brown;
            this.btnInsert.ForeColor = System.Drawing.Color.Cyan;
            this.btnInsert.Location = new System.Drawing.Point(315, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(66, 26);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "查  询";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lDno
            // 
            this.lDno.AutoSize = true;
            this.lDno.Location = new System.Drawing.Point(99, 20);
            this.lDno.Name = "lDno";
            this.lDno.Size = new System.Drawing.Size(41, 12);
            this.lDno.TabIndex = 11;
            this.lDno.Text = "学年：";
            this.lDno.Click += new System.EventHandler(this.lDno_Click);
            // 
            // Deptno
            // 
            this.Deptno.AutoSize = true;
            this.Deptno.Location = new System.Drawing.Point(3, 20);
            this.Deptno.Name = "Deptno";
            this.Deptno.Size = new System.Drawing.Size(41, 12);
            this.Deptno.TabIndex = 14;
            this.Deptno.Text = "专业：";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(434, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.panel1);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩表";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lDno;
        private System.Windows.Forms.Label Deptno;
        private System.Windows.Forms.ComboBox 年段;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 学年;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}