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

namespace _2001207356_NguyenMinhLuan_Buoi10
{
    public partial class frmBai2 : Form
    {
        string s = @"Data Source=DESKTOP-J787359;Initial Catalog=QLSinhVien;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection connection = null;
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            Display();
        }
        void Display()
        {
            trv_DS.Nodes.Clear();

            connection = new SqlConnection(s);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sql;
            sql = "Select * from Khoa";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                trv_DS.Nodes.Add(dr.GetString(0), dr.GetString(1));
            }
            dr.Close();
            foreach (TreeNode item in trv_DS.Nodes)
            {
                nodeLop_Load(item);
            }
        }

        private void nodeLop_Load(TreeNode nodeKhoa)
        {
            nodeKhoa.Nodes.Clear();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            String query = "Select * from Lop where MaKhoa='" + nodeKhoa.Name + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nodeKhoa.Nodes.Add(dr.GetString(0), dr.GetString(1));
            }
            dr.Close();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            foreach (TreeNode nodeLop in nodeKhoa.Nodes)
            {
                nodeSV_Load(nodeLop);
            }
            nodeKhoa.ExpandAll();
        }

        private void nodeSV_Load(TreeNode nodeLop)
        {
            nodeLop.Nodes.Clear();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            String query = "Select * from SinhVien where MaLop='" + nodeLop.Name + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                string infoSV = dr.GetString(0) + "," + dr.GetString(1) + "," + dr.GetDateTime(2).ToString("dd/MM/yyyy");
                nodeLop.Nodes.Add(dr.GetString(0), infoSV);
            }
            dr.Close();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
           
            nodeLop.ExpandAll();
        }

        private void trv_DS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //TreeViewHitTestInfo info = trv_DS.HitTest(trv_DS.PointToClient(Cursor.Position));
            //if (info != null)
            //MessageBox.Show(info.Node.Text);
                
            try
            {
                if (trv_DS.SelectedNode != null)
                {
                    cboLop.DataSource = null;
                    cboLop.ValueMember = "Name";
                    cboLop.DisplayMember = "Text";
                    if (trv_DS.SelectedNode.Parent == null)
                    {
                        cboLop.DataSource = trv_DS.SelectedNode.Nodes;
                        return;
                    }
                    if (trv_DS.SelectedNode.Parent.Parent == null)
                    {
                        cboLop.DataSource = trv_DS.SelectedNode.Parent.Nodes;
                        return;
                    }
                    if (trv_DS.SelectedNode.Nodes.Count == 0)
                    {
                        cboLop.DataSource = trv_DS.SelectedNode.Parent.Parent.Nodes;
                        string[] infoSV=trv_DS.SelectedNode.Text.Split(',');
                        txtMSSV.Text = infoSV[0];
                        txtHoTen.Text = infoSV[1];
                        txtNgaySinh.Text = infoSV[2];

                        return;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sql;
                sql="insert into SinhVien (masinhvien, hoten,ngaysinh,malop) values ('" + txtMSSV.Text + "',N'" + txtHoTen.Text + "','" + txtNgaySinh.Text + "','" + cboLop.SelectedValue + "')";
                Functions.RunSQL(sql);
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
                string sql;
                sql="DELETE from SinhVien WHERE MaSinhVien = N'" + txtMSSV.Text + "'";
                Functions.RunSqlDel(sql);
                connection.Close();
                Display();
                MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string sql;
                sql="update SinhVien set masinhvien ='" + txtMSSV.Text + "',hoten = N'" + txtHoTen.Text + "',ngaysinh = '" + txtNgaySinh.Text + "' where masinhvien='"+txtMSSV.Text+"'";
                Functions.RunSQL(sql);
                connection.Close();
                Display();
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
