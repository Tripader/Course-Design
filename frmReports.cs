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
    public partial class frmReports : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lDno_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (学年.Text == "" || 年段.Text == "" || comboBox1.Text == "")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                else
                {
                    //sql = "select qyg_学号,qyg_教师编号,qyg_成绩 from qianyg_学生成绩 where qyg_课程编号='" + txtCno.Text + "' and qyg_学期 like '" + 学年.Text + "%'";
                    if (年段.Text == "大二")
                    {
                        sql = "select 学号,sum(总成绩) as 总成绩 from qianyg_学生总成绩视图 where 学期 like '" + 学年.Text + "%' and 学号 like '2015%' and 专业='" + comboBox1.Text
                        + "' Group by 学号 order by sum(总成绩) DESC";
                    }
                    else if (年段.Text == "大一")
                    {
                        sql = "select 学号,sum(总成绩) as 总成绩  from qianyg_学生总成绩视图 where 学期 like '" + 学年.Text + "%' and 学号 like '2016%' and 专业='" + comboBox1.Text
                        + "' Group by 学号 order by sum(总成绩) DESC";
                    }
                    else if (年段.Text == "大三")
                    {
                        sql = "select 学号,sum(总成绩) as 总成绩 from qianyg_学生总成绩视图 where 学期 like '" + 学年.Text + "%' and 学号 like '2014%' and 专业='" + comboBox1.Text
                        + "' Group by 学号 order by sum(总成绩) DESC";
                    }
                    else
                    {
                        sql = "select 学号,sum(总成绩) as 总成绩 from qianyg_学生总成绩视图 where 学期 like '" + 学年.Text + "%' and 学号 like '2013%' and 专业='" + comboBox1.Text
                        + "' Group by 学号 order by sum(总成绩) DESC";
                    }

                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                    //sql = "select sum(成绩) from qianyg_学生成绩视图 where 学号='" + sno + "' and 学期 like '" + 学年.Text + "%'";
                    //总成绩.Text = con.getMessageOfDouble(sql).ToString();
                    //sql = "select * from qianyg_学生成绩 where qyg_课程编号='" + txtCno.Text + "' and qyg_学期 like '" + 学年.Text + "%'";


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
