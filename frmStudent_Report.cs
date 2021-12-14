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
    public partial class frmStudent_Report : Form
    {
        private string sno;
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public frmStudent_Report()
        {
            InitializeComponent();
        }

        public void setSno(string str)
        {
            this.sno = str;
            学号.Text = sno;
        }

        private void frmStudent_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                总成绩.Text = "";
                if (学年.Text == "")
                {
                    sql = "select 课程名称,教师姓名,学期,成绩 from qianyg_学生成绩视图 where 学号='" + sno + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.Columns[2].ReadOnly = true;
                    dataGView.Columns[3].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select 课程名称,教师姓名,学期,成绩 from qianyg_学生成绩视图 where 学号='" + sno + "' and 学期 like '" + 学年.Text + "%'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.Columns[2].ReadOnly = true;
                    dataGView.Columns[3].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                    //sql = "select sum(成绩) from qianyg_学生成绩视图 where 学号='" + sno + "' and 学期 like '" + 学年.Text + "%'";
                    //总成绩.Text = con.getMessageOfDouble(sql).ToString();
                    sql = "select * from qianyg_学生成绩视图 where 学号='" + sno + "' and 学期 like '" + 学年.Text + "%'";

                    if (con.OK(sql))
                    {
                        sql = "select sum(成绩) from qianyg_学生成绩视图 where 学号='" + sno + "' and 学期 like '" + 学年.Text + "%'";
                        总成绩.Text = con.getMessageOfDouble(sql).ToString();
                    }
                    else
                        总成绩.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
