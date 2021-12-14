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
    public partial class frmCourse_Reports : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        private string tno;

        public frmCourse_Reports()
        {
            InitializeComponent();
        }
        public void setTno(string str)
        {
            this.tno = str;
            CmbCBind();
        }

        protected void CmbCBind()
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void lDname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCourse_Reports_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "";
                if (学年.Text == "" && txtCno.Text == "")
                {
                    sql = "select qyg_学号,qyg_教师编号,qyg_成绩 from qianyg_学生成绩 ";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.Columns[2].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else if (学年.Text != "" && txtCno.Text != "")
                {
                    sql = "select qyg_学号,qyg_教师编号,qyg_成绩 from qianyg_学生成绩 where qyg_课程编号='" + txtCno.Text + "' and qyg_学期 like '" + 学年.Text + "%'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.Columns[2].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                    //sql = "select sum(成绩) from qianyg_学生成绩视图 where 学号='" + sno + "' and 学期 like '" + 学年.Text + "%'";
                    //总成绩.Text = con.getMessageOfDouble(sql).ToString();
                    sql = "select * from qianyg_学生成绩 where qyg_课程编号='" + txtCno.Text + "' and qyg_学期 like '" + 学年.Text + "%'";
                    if (con.OK(sql))
                    {
                        sql = "select sum(qyg_成绩) from qianyg_学生成绩 where qyg_课程编号='" + txtCno.Text + "' and qyg_学期 like '" + 学年.Text + "%'";
                        double d = con.getMessageOfDouble(sql);
                        sql = "select count(*) from qianyg_学生成绩 where qyg_课程编号='" + txtCno.Text + "' and qyg_学期 like '" + 学年.Text + "%'";
                        int d1 = con.getMessageOfInt(sql);
                        d = (d / d1);
                        label3.Text = d.ToString();
                    }
                    else
                        label3.Text = "";
                }
                else if (学年.Text == "" && txtCno.Text != "")
                {
                    sql = "select qyg_学号,qyg_教师编号,qyg_成绩 from qianyg_学生成绩 where qyg_课程编号='" + txtCno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.Columns[2].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                else
                {
                    sql = "select qyg_学号,qyg_教师编号,qyg_成绩 from qianyg_学生成绩 where  qyg_学期 like '" + 学年.Text + "%'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.Columns[2].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }


            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
