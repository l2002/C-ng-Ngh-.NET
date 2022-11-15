using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001207356_NguyenMinhLuan_Buoi10
{
    class Functions
    {
        public static SqlConnection Con;         


        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	
                Con.Dispose(); 
                Con = null;
            }
        }       

        public static void RunSQL(string sql)
        {
            SqlCommand cmd; 
            cmd = new SqlCommand();
            cmd.Connection = Con; 
            cmd.CommandText = sql; 
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
