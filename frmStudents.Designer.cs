namespace student
{
    partial class frmStudents
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
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lSno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lCredit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.班级 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.生源地 = new System.Windows.Forms.TextBox();
            this.年龄 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGView
            // 
            this.dataGView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGView.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(17, 97);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(639, 171);
            this.dataGView.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Chartreuse;
            this.btnInsert.Location = new System.Drawing.Point(17, 281);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(155, 26);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "插  入";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Chartreuse;
            this.btnDelete.Location = new System.Drawing.Point(187, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Chartreuse;
            this.btnChange.Location = new System.Drawing.Point(343, 281);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(130, 26);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "保  存";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCancel.Location = new System.Drawing.Point(492, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lSno
            // 
            this.lSno.AutoSize = true;
            this.lSno.Location = new System.Drawing.Point(31, 12);
            this.lSno.Name = "lSno";
            this.lSno.Size = new System.Drawing.Size(53, 12);
            this.lSno.TabIndex = 5;
            this.lSno.Text = "学  号：";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(89, 9);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(103, 21);
            this.txtSno.TabIndex = 6;
            this.txtSno.TextChanged += new System.EventHandler(this.txtSno_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(325, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 21);
            this.txtName.TabIndex = 8;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(246, 12);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(53, 12);
            this.lName.TabIndex = 7;
            this.lName.Text = "姓  名：";
            // 
            // lCredit
            // 
            this.lCredit.AutoSize = true;
            this.lCredit.Location = new System.Drawing.Point(31, 48);
            this.lCredit.Name = "lCredit";
            this.lCredit.Size = new System.Drawing.Size(53, 12);
            this.lCredit.TabIndex = 9;
            this.lCredit.Text = "生源地：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.班级);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.生源地);
            this.panel1.Controls.Add(this.年龄);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sex);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lSno);
            this.panel1.Controls.Add(this.txtSno);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.lCredit);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 75);
            this.panel1.TabIndex = 13;
            // 
            // 班级
            // 
            this.班级.Location = new System.Drawing.Point(527, 44);
            this.班级.Name = "班级";
            this.班级.Size = new System.Drawing.Size(85, 21);
            this.班级.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "班级编号：";
            // 
            // 生源地
            // 
            this.生源地.Location = new System.Drawing.Point(89, 44);
            this.生源地.Name = "生源地";
            this.生源地.Size = new System.Drawing.Size(103, 21);
            this.生源地.TabIndex = 17;
            // 
            // 年龄
            // 
            this.年龄.Location = new System.Drawing.Point(325, 44);
            this.年龄.Name = "年龄";
            this.年龄.Size = new System.Drawing.Size(95, 21);
            this.年龄.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "年  龄：";
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(527, 9);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(85, 20);
            this.sex.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "性  别：";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(672, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Name = "frmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息输入窗体";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lSno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lCredit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox 年龄;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 生源地;
        private System.Windows.Forms.TextBox 班级;
        private System.Windows.Forms.Label label3;
    }
}