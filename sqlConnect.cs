using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;//消息框命名空间

namespace student
{
    
    class sqlConnect
    {
       public SqlConnection conn=null;

        public sqlConnect()//构造函数，连接数据库
        {
            if(conn==null){
                conn = new SqlConnection("Data Source=(local);database=qianyungang02MIS;uid=sa;password=123456;");
               if(conn.State==ConnectionState.Closed)conn.Open();
            }
        }
      
       public void closeConnect()//关闭连接
       {
           if (conn.State == ConnectionState.Open) conn.Close();
          
       }
       //下面这个方法是从数据库中查找数据的方法

       public DataSet Getds(string sql)
       {
           if (conn.State == ConnectionState.Closed)  conn.Open();        
           DataSet ds = new DataSet();//DataSet是表的集合
           SqlDataAdapter da = new SqlDataAdapter(sql, conn);//从数据库中查询
           da.Fill(ds);//将数据填充到DataSet
           conn.Close();//关闭连接
           return ds;//返回结果
       }
 
       //下面的方法是对数据库进行更新

       public int OperateData(string sql)
       {
          if (conn.State == ConnectionState.Closed) conn.Open();
          SqlCommand sqlcom = new SqlCommand();//表示要对数据源执行的SQL语句或存储过程
          sqlcom.CommandText = sql;//设置命令的文本
          sqlcom.CommandType = CommandType.Text;//设置命令的类型
          sqlcom.Connection = conn;//设置命令的连接
          int x = sqlcom.ExecuteNonQuery();//执行SQL语句
          conn.Close();//关闭连接
          return x;   //返回一个影响行数

       }
   
        //----绑定DataGridView
       public DataSet BindDataGridView(DataGridView dgv, string sql)
       {  
           if (conn.State == ConnectionState.Closed)  conn.Open();
           SqlDataAdapter da = new SqlDataAdapter(sql, conn);
           DataSet ds = new DataSet();
           da.Fill(ds);
           dgv.DataSource = ds.Tables[0];
           return ds;         
       }
       //判断有没有返回结果
       public bool OK(string sql)
       {
           if (conn.State == ConnectionState.Closed) conn.Open();
           
               SqlCommand sqlcom = new SqlCommand(sql, conn);
               SqlDataReader rd = sqlcom.ExecuteReader();
               if (rd.HasRows)
               {
                   rd.Close();
                   conn.Close();
                   return true;
               }
               else
               {
                   rd.Close();
                   conn.Close();
                   return false;
               }
               
       }
        //获取信息
       public string getMessage(string sql)
       {
           if (conn.State == ConnectionState.Closed) conn.Open();
           string str = "";
           SqlCommand sqlcom = new SqlCommand(sql, conn);
           SqlDataReader rd = sqlcom.ExecuteReader();
           while (rd.Read())
           {
               str += rd.GetString(0); 
           }
           rd.Close();
           conn.Close();
           return str;
       }
       public double getMessageOfDouble(string sql)
       {
           if (conn.State == ConnectionState.Closed) conn.Open();
           double f=0;
           SqlCommand sqlcom = new SqlCommand(sql, conn);
           SqlDataReader rd = sqlcom.ExecuteReader();
           if (rd.Read())
           {
               f = rd.GetDouble(0);
           }
           rd.Close();
           conn.Close();
           return f;
       }
       public int getMessageOfInt(string sql)
       {
           if (conn.State == ConnectionState.Closed) conn.Open();
           int f = 0;
           SqlCommand sqlcom = new SqlCommand(sql, conn);
           SqlDataReader rd = sqlcom.ExecuteReader();
           if (rd.Read())
           {
               f = rd.GetInt32(0);
           }
           rd.Close();
           conn.Close();
           return f;
       }

    }
}
