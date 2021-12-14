namespace student
{
    partial class frmStudent_Report
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
            this.总成绩 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.学号 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.学年 = new System.Windows.Forms.ComboBox();
            this.lDno = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gold;
            this.btnCancel.Location = new System.Drawing.Point(260, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(206, 26);
            this.btnCancel.TabIndex = 38;
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
            this.dataGView.Location = new System.Drawing.Point(28, 76);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(438, 135);
            this.dataGView.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.总成绩);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.学号);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.学年);
            this.panel1.Controls.Add(this.lDno);
            this.panel1.Location = new System.Drawing.Point(28, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 45);
            this.panel1.TabIndex = 36;
            // 
            // 总成绩
            // 
            this.总成绩.Location = new System.Drawing.Point(380, 16);
            this.总成绩.Name = "总成绩";
            this.总成绩.Size = new System.Drawing.Size(53, 14);
            this.总成绩.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "学年总成绩：";
            // 
            // 学号
            // 
            this.学号.Location = new System.Drawing.Point(51, 19);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(94, 13);
            this.学号.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "学  号：";
            // 
            // 学年
            // 
            this.学年.FormattingEnabled = true;
            this.学年.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016"});
            this.学年.Location = new System.Drawing.Point(199, 10);
            this.学年.Name = "学年";
            this.学年.Size = new System.Drawing.Size(81, 20);
            this.学年.TabIndex = 19;
            // 
            // lDno
            // 
            this.lDno.AutoSize = true;
            this.lDno.Location = new System.Drawing.Point(151, 18);
            this.lDno.Name = "lDno";
            this.lDno.Size = new System.Drawing.Size(53, 12);
            this.lDno.TabIndex = 14;
            this.lDno.Text = "学  年：";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Gold;
            this.btnSelect.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSelect.Location = new System.Drawing.Point(28, 224);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(189, 26);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "查  询";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmStudent_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(493, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelect);
            this.Name = "frmStudent_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩查询界面";
            this.Load += new System.EventHandler(this.frmStudent_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox 学年;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lDno;
        private System.Windows.Forms.Label 学号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 总成绩;
        private System.Windows.Forms.Label label2;

    }
}