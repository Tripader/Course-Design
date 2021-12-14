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

    public partial class frmClass_Course : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmClass_Course()
        {
            InitializeComponent();
        }

        private void frmClass_Course_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCno.Text == "" && txtClno.Text == "")
            {
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_班级编号 as 班级编号,qyg_教师编号 as 教师编号,qyg_学期 as 学期 from qianyg_选课情况 ";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text != "" && txtClno.Text == "")
            {
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_班级编号 as 班级编号,qyg_教师编号 as 教师编号,qyg_学期 as 学期 from qianyg_选课情况 where qyg_课程编号='" + txtCno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text == "" && txtClno.Text != "")
            {
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_班级编号 as 班级编号,qyg_教师编号 as 教师编号,qyg_学期 as 学期  from qianyg_选课情况 where qyg_班级编号='" + txtClno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_班级编号 as 班级编号,qyg_教师编号 as 教师编号,qyg_学期 as 学期  from qianyg_选课情况 where qyg_班级编号='" + txtClno.Text + "' and qyg_课程编号='" + txtCno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from qianyg_选课情况 where qyg_班级编号='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "' and qyg_课程编号='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'"
                        + " and qyg_教师编号='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "'";
                    //sql = "delete from Depts where Deptno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    try
                    {
                        sql = "select qyg_课程编号 as 课程编号,qyg_班级编号 as 班级编号,qyg_教师编号 as 教师编号,qyg_学期 as 学期 from qianyg_选课情况 ";
                        ds = con.BindDataGridView(dataGView, sql);
                        dataGView.Columns[0].ReadOnly = true;
                        dataGView.AllowUserToAddRows = false;
                    }
                    catch
                    {
                        MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCno.Text == "" || txtClno.Text == "")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                sql = "insert into qianyg_选课情况 values( '" + txtCno.Text + "','" + txtClno.Text + "','" + 教师编号.Text + "','" + comboBox1.Text + "')";
                con.OperateData(sql);
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_班级编号 as 班级编号,qyg_教师编号 as 教师编号,qyg_学期 as 学期 from qianyg_选课情况  where qyg_班级编号='" + txtClno.Text + "' and qyg_课程编号='" + txtCno.Text + "'"
                        + " and qyg_教师编号='" + 教师编号.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtClno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
