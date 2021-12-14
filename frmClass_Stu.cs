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
    public partial class frmClass_Stu : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmClass_Stu()
        {
            InitializeComponent();
        }

        //----绑定DataGivdView数据
        protected void SetBind()
        {
            try
            {
                sql = "select qyg_学号 as 学号,qyg_姓名 as 姓名,qyg_班级编号 as 班级编号 from qianyg_学生 where qyg_班级编号='" + txtCno.Text + "' and qyg_学号='" + txtSno.Text + "'";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmClass_Stu_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
        //数据查询
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCno.Text == "" && txtSno.Text == "")
            {
                try
                {
                    sql = "select qyg_学号 as 学号,qyg_姓名 as 姓名,qyg_班级编号 as 班级编号 from qianyg_学生 ";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text != "" && txtSno.Text == "")
            {
                try
                {
                    sql = "select qyg_学号 as 学号,qyg_姓名 as 姓名,qyg_班级编号 as 班级编号 from qianyg_学生 where qyg_班级编号='" + txtCno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text == "" && txtSno.Text != "")
            {
                try
                {
                    sql = "select qyg_学号 as 学号,qyg_姓名 as 姓名,qyg_班级编号 as 班级编号 from qianyg_学生 where qyg_学号='" + txtSno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
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
                    sql = "select qyg_学号 as 学号,qyg_姓名 as 姓名,qyg_班级编号 as 班级编号 from qianyg_学生 where qyg_班级编号='" + txtCno.Text + "' and qyg_学号='" + txtSno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.Columns[1].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
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
                sql = "update qianyg_学生 set qyg_班级编号='" + dataGView.CurrentRow.Cells[2].Value.ToString() +
                    "' where qyg_学号='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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
    }
}
