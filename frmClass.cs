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
    public partial class frmClass : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmClass()
        {
            InitializeComponent();
            //SetBind();
        }
        //----绑定DataGivdView数据
        protected void SetBind()
        {
            try
            {
                sql = "select qyg_班级编号 as 班级编号,qyg_专业 as 专业 from qianyg_班级 where qyg_班级编号='" + txtCno.Text + "' and qyg_专业='" + txtDept.Text + "'";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //----插入数据
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCno.Text == "" || txtDept.Text == "")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                sql = "insert into qianyg_班级 values( '" + txtCno.Text + "','" + txtDept.Text + "')";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        //----修改数据
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update qianyg_班级 set qyg_专业='" + dataGView.CurrentRow.Cells[1].Value.ToString() +
                    "' where qyg_班级编号='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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
        //---------删除数据
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from qianyg_班级 where qyg_班级编号='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    //sql = "delete from Depts where Deptno='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    try
                    {
                        sql = "select qyg_班级编号 as 班级编号,qyg_专业 as 专业 from qianyg_班级";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDept_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDno_TextChanged(object sender, EventArgs e)
        {

        }
        //查询操作
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCno.Text == "" && txtDept.Text == "")
            {
                try
                {
                    sql = "select qyg_班级编号 as 班级编号,qyg_专业 as 专业 from qianyg_班级 ";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text != "" && txtDept.Text == "")
            {
                try
                {
                    sql = "select qyg_班级编号 as 班级编号,qyg_专业 as 专业 from qianyg_班级 where qyg_班级编号='" + txtCno.Text + "'";
                    ds = con.BindDataGridView(dataGView, sql);
                    dataGView.Columns[0].ReadOnly = true;
                    dataGView.AllowUserToAddRows = false;
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtCno.Text == "" && txtDept.Text != "")
            {
                try
                {
                    sql = "select qyg_班级编号 as 班级编号,qyg_专业 as 专业 from qianyg_班级 where qyg_专业='" + txtDept.Text + "'";
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
                    sql = "select qyg_班级编号 as 班级编号,qyg_专业 as 专业 from qianyg_班级 where qyg_班级编号='" + txtCno.Text + "' and qyg_专业='" + txtDept.Text + "'";
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
    }
}
