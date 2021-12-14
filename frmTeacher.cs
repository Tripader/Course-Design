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
    public partial class frmTeacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string tno;
        private string tname;
        public frmTeacher()
        {
            InitializeComponent();
        }


        public void setTno(string str)
        {
            this.tno = str;
            string sql = "select qyg_姓名 from qianyg_教师 where qyg_教师编号 = '" + tno + "'";
            setSname(sql);
        }

        public void setSname(string sql)
        {
            sqlConnect con = new sqlConnect();
            string str = con.getMessage(sql);
            this.tname = str;
            welcome.Text = "你好！" + tname + "\n" + "老师";
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {

        }

        private void 返回登入界面_Click(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            flogin.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 课程成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse_Reports frmcourse_reports = new frmCourse_Reports();
            frmcourse_reports.setTno(tno);
            frmcourse_reports.Show();
        }

        private void 学生成绩输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.setTno(tno);
            frmReport.Show();
        }

        private void 教师任课查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacher_Course frmteacher_course = new frmTeacher_Course();
            frmteacher_course.setTno(tno);
            frmteacher_course.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (密码.Text.Length < 6 || 密码.Text.Length > 20)
                {
                    MessageBox.Show("密码需要6-20位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sql = "update qianyg_教师登入 set qyg_密码='" + 密码.Text
                    + "' where qyg_教师编号='" + tno + "'";
                    con.OperateData(sql);
                    MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 密码_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
