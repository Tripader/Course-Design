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
    public partial class frmStudent : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string sno;
        private string sname;
        public frmStudent()
        {
            InitializeComponent();
        }

        public void setSno(string str)
        {
            this.sno = str;
            string sql = "select qyg_姓名 from qianyg_学生 where qyg_学号 = '" + sno + "'";
            setSname(sql);
        }

        public void setSname(string sql)
        {
            sqlConnect con = new sqlConnect();
            string str = con.getMessage(sql);
            this.sname = str;
            welcome.Text = " 你好！" + sname + "\n同学";
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent_Report frmstudent_report = new frmStudent_Report();
            frmstudent_report.setSno(sno);
            frmstudent_report.Show();
        }

        private void 选课情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent_Course frmstudent_course = new frmStudent_Course();
            frmstudent_course.setSno(sno);
            frmstudent_course.Show();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void 返回登入界面_Click(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            flogin.Show();
            this.Hide();
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
                    sql = "update qianyg_学生登入 set qyg_密码='" + 密码.Text
                    + "' where qyg_学号='" + sno + "'";
                    con.OperateData(sql);
                    MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
