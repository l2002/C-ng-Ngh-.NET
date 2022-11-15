using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2001207356_NguyenMinhLuan_Buoi9
{
    public partial class frmMain : Form
    {
        string s = @"Data Source=DESKTOP-J787359;Initial Catalog=QLSinhVien;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection connection = null;
        public frmMain()
        {
            InitializeComponent();
        }

        void Display()
        {
            connection = new SqlConnection(s);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            try
            {
                string str = "select * from Khoa";
                SqlCommand cmd = new SqlCommand(str, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(str, connection);

                da.Fill(ds, "Khoa");
                cboChonKhoa.DisplayMember = "TenKhoa";
                cboChonKhoa.ValueMember = "MaKhoa";
                cboChonKhoa.DataSource = ds.Tables[0];

                string str1 = "select * from Lop";
                da = new SqlDataAdapter(str1, connection);
                ds = new DataSet();
                da.Fill(ds, "Lop");
                cboChonLop.DisplayMember = "TenLop";
                cboChonLop.ValueMember = "MaLop";
                cboChonLop.DataSource = ds.Tables[0];

                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
                cboLop.DataSource = ds.Tables[0];

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDS.SelectedItems.Count > 0)
            {
                ListViewItem list = lstDS.SelectedItems[0];
                string mssv, hoten, ngaysinh;
                mssv = list.SubItems[0].Text;
                hoten = list.SubItems[1].Text;
                ngaysinh = list.SubItems[2].Text;

                txtMSSV.Text = mssv;
                txtHoTen.Text = hoten;
                txtNgaySinh.Text = ngaysinh;
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(s);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            string makhoa = cboChonKhoa.SelectedValue.ToString();

            string str = "Select Lop.MaLop,TenLop from Khoa,Lop where Khoa.MaKhoa=Lop.MaKhoa and Khoa.MaKhoa='" + makhoa + " ' ";
            SqlCommand cmd = new SqlCommand(str, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, connection);

            da.Fill(ds, "Lop");
            cboChonLop.DisplayMember = "TenLop";
            cboChonLop.ValueMember = "MaLop";
            cboChonLop.DataSource = ds.Tables[0];

        }

        private void cboChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(s);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            string makhoa = cboChonKhoa.SelectedValue.ToString();

            string str = "Select sv.MaSinhVien,HoTen,NgaySinh,Diem,d.MaMonHoc,mh.TenMonHoc from SinhVien sv ,Diem d,MonHoc mh,Khoa,Lop where sv.MaSinhVien=d.MaSinhVien and d.MaMonHoc = mh.MaMonHoc and Khoa.MaKhoa=Lop.MaKhoa and sv.MaLop=Lop.MaLop and Khoa.MaKhoa='" + makhoa + "'";
            SqlCommand cmd = new SqlCommand(str, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            lstDS.Items.Clear();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader.GetString(0));

                list.SubItems.Add(reader.GetString(1));
                list.SubItems.Add(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                list.SubItems.Add(reader.GetDouble(3).ToString());
                list.SubItems.Add(reader.GetString(4));
                list.SubItems.Add(reader.GetString(5));
                lstDS.Items.Add(list);
            }   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiem tra ket noi
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into SinhVien (masinhvien, hoten,ngaysinh,malop) values ('" + txtMSSV.Text + "',N'" + txtHoTen.Text + "','" + txtNgaySinh.Text + "',N'" + cboLop.SelectedValue + "')", connection);
                cmd.ExecuteNonQuery(); 
                connection.Close();
                Display();
                MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSinhVien = N'" + txtMSSV.Text + "'", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                Display();
                MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
