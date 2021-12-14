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
    public partial class frmAdministrator : Form
    {
        private string ano;
        public frmAdministrator()
        {
            InitializeComponent();
        }

        public void setAno(string str)
        {
            this.ano = str;
            welcome.Text = "你好！" + ano;
        }

        private void 班级管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 班级变更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass fClass = new frmClass();
            fClass.Show();
        }

        private void 返回登入界面_Click(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            flogin.Show();
            this.Hide();
        }

        private void 学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReports frmreports = new frmReports();
            frmreports.Show();
        }

        private void 班级学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass_Stu frmclass_stu = new frmClass_Stu();
            frmclass_stu.Show();
        }

        private void 生源信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistrict frmDistrict = new frmDistrict();
            frmDistrict.Show();
        }


        private void 班级课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass_Course frmclass_course = new frmClass_Course();
            frmclass_course.Show();
        }

        private void 课程成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse_Reports frmcourse_reports = new frmCourse_Reports();
            frmcourse_reports.Show();
        }

        private void frmAdministrator_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudents frmstudent = new frmStudents();
            frmstudent.Show();
        }

        private void 教师管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCourse_Teacher frmcourse_teacher = new frmCourse_Teacher();
            //frmcourse_teacher.Show();
            frmClass_Course frmclass_course = new frmClass_Course();
            frmclass_course.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
