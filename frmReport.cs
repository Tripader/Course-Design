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
    public partial class frmReport : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();     
        private string sql;
        private string tno;
       
        public frmReport()
        {
            InitializeComponent();
            //SetBind();           
            //CmbSBind();
            //CmbCBind();
        }
        public void setTno(string str)
        {
            this.tno = str;
            CmbCBind();
        }
        //----绑定DataGivdView数据
        protected void SetBind()
        {
           
            try{
                sql = "select qyg_学号 as 学号,qyg_课程编号 as 课程编号, qyg_学期 as 学期,qyg_成绩 as 成绩 from qianyg_学生成绩 where qyg_教师编号='" + tno + "'";
                ds = con.BindDataGridView(dataGView, sql);          
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }  catch  {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        //-----绑定下拉框数据
        /*protected void CmbSBind()
        {
            try {
                cmbS.DropDownStyle = ComboBoxStyle.DropDownList;                
                ds = con.Getds("select Sno, Sname from Students");
                cmbS.ValueMember = "Sno";
                cmbS.DisplayMember = "Sname";
                cmbS.DataSource = ds.Tables[0];             
            }catch (Exception)  {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }*/
        protected void CmbCBind()
        {
            try{
                课程编号.DropDownStyle = ComboBoxStyle.DropDownList;
                ds = con.Getds("select  distinct qyg_课程编号 from qianyg_选课情况 where qyg_教师编号='"+tno+"'");
                课程编号.DisplayMember = "qyg_课程编号";
                //课程编号.ValueMember = "Cno";
                课程编号.DataSource = ds.Tables[0];
               // cmbC.SelectedIndex = 0;
            }  catch (Exception)  {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //--------插入数据
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try{
                if (学号.Text == "" || 课程编号.Text == "" || 学期.Text == "" || 成绩.Text=="")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                float f = float.Parse(成绩.Text);
                sql = "insert into qianyg_学生成绩 values( '" + 学号.Text + "','" + 课程编号.Text + "','" + tno + "','" + 学期.Text + "'," + f + ")";
                con.OperateData(sql); 
                SetBind();
            }catch{
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        //--------删除数据
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try {                   
                    sql = "delete from qianyg_学生成绩 where qyg_学号='" + dataGView.CurrentRow.Cells[0].Value.ToString()
                            + "' and qyg_学期='" + dataGView.CurrentRow.Cells[2].Value.ToString() + "' and qyg_课程编号='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                } catch{
                    MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }

            }
               
        }

        private void btnChange_Click(object sender, EventArgs e)
        { 
            try {
                sql = "update qianyg_学生成绩 set qyg_成绩='"+ dataGView.CurrentRow.Cells[3].Value.ToString()
                    +"' where qyg_学号='"+ dataGView.CurrentRow.Cells[0].Value.ToString()
                    +"' and qyg_学期='"+ dataGView.CurrentRow.Cells[2].Value.ToString()
                    + "' and qyg_课程编号='" + dataGView.CurrentRow.Cells[1].Value.ToString() + "'";
                con.OperateData(sql);
                SetBind();
            }catch {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void lname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select qyg_学号 as 学号,qyg_课程编号 as 课程编号, qyg_学期 as 学期,qyg_成绩 as 成绩 from qianyg_学生成绩 where qyg_教师编号='"+tno+"'";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能做该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

   
    }
}
