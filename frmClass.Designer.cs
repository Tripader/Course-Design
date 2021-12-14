namespace student
{
    partial class frmClass
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lDno = new System.Windows.Forms.Label();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.lDname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Chocolate;
            this.btnCancel.Location = new System.Drawing.Point(320, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 26);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Chocolate;
            this.btnChange.Location = new System.Drawing.Point(248, 217);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(66, 26);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "保  存";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Chocolate;
            this.btnDelete.Location = new System.Drawing.Point(176, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 26);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Chocolate;
            this.btnInsert.Location = new System.Drawing.Point(286, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(66, 26);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "插  入";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(195, 11);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(73, 21);
            this.txtDept.TabIndex = 16;
            this.txtDept.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lDno
            // 
            this.lDno.AutoSize = true;
            this.lDno.Location = new System.Drawing.Point(3, 20);
            this.lDno.Name = "lDno";
            this.lDno.Size = new System.Drawing.Size(65, 12);
            this.lDno.TabIndex = 14;
            this.lDno.Text = "班级编号：";
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(64, 11);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(55, 21);
            this.txtCno.TabIndex = 13;
            this.txtCno.TextChanged += new System.EventHandler(this.txtDno_TextChanged);
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
            this.dataGView.Location = new System.Drawing.Point(25, 76);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(361, 135);
            this.dataGView.TabIndex = 12;
            this.dataGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGView_CellContentClick);
            // 
            // lDname
            // 
            this.lDname.AutoSize = true;
            this.lDname.Location = new System.Drawing.Point(136, 20);
            this.lDname.Name = "lDname";
            this.lDname.Size = new System.Drawing.Size(53, 12);
            this.lDname.TabIndex = 11;
            this.lDname.Text = "专  业：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lDname);
            this.panel1.Controls.Add(this.txtCno);
            this.panel1.Controls.Add(this.lDno);
            this.panel1.Controls.Add(this.txtDept);
            this.panel1.Location = new System.Drawing.Point(25, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 45);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(95, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "查  询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(413, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGView);
            this.Name = "frmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级信息窗体";
            this.Load += new System.EventHandler(this.frmDept_Load);
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
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lDno;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Label lDname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}