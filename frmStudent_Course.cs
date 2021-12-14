using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student
{
    public partial class frmStudent_Course : Form
    {
        private string sno;
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmStudent_Course()
        {
            InitializeComponent();
        }

        public void setSno(string str)
        {
            this.sno = str;
            label2.Text = sno;
        }

        private void frmStudent_Course_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //没有记录时的修改
                if (comboBox1.Text == "")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                sql = "select 课程名称,教师名字,学期,课程类型 from qianyg_学生所学课程 where 学号='" + sno + "'and 学期 like'" + comboBox1.Text + "%'";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
                sql = "select * from qianyg_课程 where qyg_课程编号 in(select 课程编号 from qianyg_学生所学课程 where 学号='" + sno + "'and 学期 like'" + comboBox1.Text + "%')";
                if (con.OK(sql))
                {
                    sql = "select SUM(qyg_学分)from qianyg_课程 where qyg_课程编号 in(select 课程编号 from qianyg_学生所学课程 where 学号='" + sno + "'and 学期 like'" + comboBox1.Text + "%')";
                    label5.Text = con.getMessageOfDouble(sql).ToString();
                }
                else
                    label5.Text = "";

            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
