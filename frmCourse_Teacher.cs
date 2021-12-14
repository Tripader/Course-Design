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
    public partial class frmCourse_Teacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmCourse_Teacher()
        {
            InitializeComponent();
        }

        private void frmCourse_Teacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCno.Text == "" && txtTno.Text == "")
            {
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_教师编号 as 教师编号 from qianyg_教授课程 ";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text != "" && txtTno.Text == "")
            {
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_教师编号 as 教师编号 from qianyg_教授课程 where qyg_课程编号='" + txtCno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text == "" && txtTno.Text != "")
            {
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_教师编号 as 教师编号 from qianyg_教授课程 where qyg_教师编号='" + txtCno.Text + "'";
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
                    sql = "select qyg_课程编号 as 课程编号,qyg_教师编号 as 教师编号 from qianyg_教授课程 where qyg_课程编号='" + txtCno.Text + "' and qyg_教师编号='" + txtTno.Text + "'";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from qianyg_教授课程 where qyg_课程编号='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'and qyg_教师编号='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'";
                    //sql = "delete from Depts where Deptno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    //SetBind();
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update qianyg_教授课程 set qyg_教师编号='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                    "' where qyg_课程编号='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                /*sql = "update Depts set DeptName='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                    "' where DeptNo='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";*/
                con.OperateData(sql);
                //SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCno.Text == "" || txtTno.Text == "")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                sql = "insert into qianyg_教授课程 values( '" + txtCno.Text + "','" + txtTno.Text + "')";
                con.OperateData(sql);
                try
                {
                    sql = "select qyg_课程编号 as 课程编号,qyg_教师编号 as 教师编号 from qianyg_教授课程 where qyg_课程编号='" + txtCno.Text + "' and qyg_教师编号='" + txtTno.Text + "'";
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
}
