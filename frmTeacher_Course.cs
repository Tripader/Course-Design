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
    public partial class frmTeacher_Course : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string tno;

        public frmTeacher_Course()
        {
            InitializeComponent();
        }
        public void setTno(string str)
        {
            this.tno = str;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTeacher_Course_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select  qianyg_课程.qyg_课程编号 as 课程编号,qyg_班级编号 as 班级编号,qyg_课程类型 as 课程类型,qyg_课程名称 from qianyg_教师,qianyg_选课情况,qianyg_课程" +
                      "  where qianyg_教师.qyg_教师编号=qianyg_选课情况.qyg_教师编号" +
                      " and qianyg_选课情况.qyg_课程编号=qianyg_课程.qyg_课程编号" +
                      " and qianyg_教师.qyg_教师编号='" + tno + "'" +
                      " and qianyg_选课情况.qyg_学期='" + comboBox1.Text + "'";

                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
