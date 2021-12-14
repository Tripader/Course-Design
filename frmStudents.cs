using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.SqlClient;


namespace student
{
    public partial class frmStudents : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;


        public frmStudents()
        {
            InitializeComponent();
            //ComBoxBind();
            SetBind();
        }



        //----绑定DataGivdView数据
        protected void SetBind()
        {
            sql = "select qyg_学号 as 学号,qyg_姓名 as 姓名,qyg_性别 as 性别,qyg_年龄 as 年龄,qyg_生源所在地 as 生源所在地,qyg_班级编号 as 班级编号  from qianyg_学生";
            try
            {
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.Columns[4].ReadOnly = true;
                dataGView.Columns[5].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        //----绑定下拉框数据
        /* protected void ComBoxBind()
         {
             try
             {   //----对下拉框绑定学院信息           
                 cmbDept.DropDownStyle = ComboBoxStyle.DropDownList;
                 cmbDept.Items.Clear();
                 ds = con.Getds("select  DeptNo ,deptName from Depts");
                 cmbDept.DisplayMember = "deptName";
                 cmbDept.ValueMember = "DeptNo";
                 cmbDept.DataSource = ds.Tables[0];
                 cmbDept.SelectedIndex = 0;                
             }
             catch (Exception)
             {
                 MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }       
         }*/




        //----插入数据项
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSno.Text == "" || txtName.Text == "" || sex.Text == "" || 生源地.Text == "" || 年龄.Text == "" || 班级.Text == "")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                int i = int.Parse(年龄.Text); MessageBox.Show(年龄.Text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql = "insert into qianyg_学生(qyg_学号,qyg_姓名,qyg_性别,qyg_生源所在地,qyg_年龄,qyg_班级编号) values( '" + txtSno.Text + "','" + txtName.Text + "','" + sex.Text + "','" + 生源地.Text + "'," + i + 班级.Text + ")";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        //----关闭窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        //----删除当前行
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from qianyg_学生 where qyg_学号= '" + Sno + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else return;

        }



        //----修改当前行
        private void btnChange_Click(object sender, EventArgs e)
        {
            string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Time = dataGView.CurrentRow.Cells[3].Value.ToString();
            try
            {
                //sql = "select DeptNo from Depts where deptName='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "'";
                //ds = con.Getds(sql);
                //string DeptNo = ds.Tables[0].Rows[0][0].ToString();
                sql = "update qianyg_学生 set qyg_年龄='" + Time +
                     "' where qyg_学号='" + Sno + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSno_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
