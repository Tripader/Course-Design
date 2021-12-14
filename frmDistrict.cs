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
    public partial class frmDistrict : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;

        public frmDistrict()
        {
            InitializeComponent();
        }

        private void frmDistrict_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (生源地.Text == "")
                {
                    Exception e1 = new Exception();
                    throw e1;
                }
                sql = "select qyg_姓名 as 姓名,qyg_学号 as 学号,qyg_生源所在地 as 生源所在地 from qianyg_学生 where qyg_生源所在地 like '" + 生源地.Text + "%'";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
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
