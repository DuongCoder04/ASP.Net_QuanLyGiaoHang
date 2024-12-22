using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyGiaoHang.View
{
    public partial class NhanVien : System.Web.UI.Page
    {
        string strCon = "server = ACERNITRO5\\VANDUONG; database=QuanLyGiaoHang; Trusted_Connection= true";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from NHANVIEN";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dgvNhanVien.DataSource = sqlDataReader;
                dgvNhanVien.DataBind();
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO NHANVIEN VALUES(@MANHANVIEN, @HO, @TEN, @NGAYSINH, @NGAYLAMVIEC, @DIACHI, @LUONGCOBAN, @PHUCAP)";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MANHANVIEN", txbMaNhanVien.Text);
                sqlCommand.Parameters.AddWithValue("@HO", txbHo.Text);
                sqlCommand.Parameters.AddWithValue("@TEN", txbTen.Text);
                sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = txbNgaySinh.Text;
                sqlCommand.Parameters.Add("@NGAYLAMVIEC", SqlDbType.Date).Value = txbNgayLamViec.Text;
                sqlCommand.Parameters.AddWithValue("@DIACHI", txbDiaChi.Text);
                sqlCommand.Parameters.Add("@LUONGCOBAN", SqlDbType.Decimal).Value = txbLuongCB.Text;
                sqlCommand.Parameters.AddWithValue("@PHUCAP", SqlDbType.Decimal).Value = txbPhuCap.Text;
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = "UPDATE NHANVIEN SET HO=@HO,TEN=@TEN,NGAYSINH=@NGAYSINH,NGAYLAMVIEC=@NGAYLAMVIEC,DIACHI=@DIACHI,LUONGCOBAN=@LUONGCOBAN,PHUCAP=@PHUCAP WHERE MANHANVIEN=@MANHANVIEN";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MANHANVIEN", txbMaNhanVien.Text);
                    sqlCommand.Parameters.AddWithValue("@HO", txbHo.Text);
                    sqlCommand.Parameters.AddWithValue("@TEN", txbTen.Text);
                    sqlCommand.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = txbNgaySinh.Text;
                    sqlCommand.Parameters.Add("@NGAYLAMVIEC", SqlDbType.Date).Value = txbNgayLamViec.Text;
                    sqlCommand.Parameters.AddWithValue("@DIACHI", txbDiaChi.Text);
                    sqlCommand.Parameters.Add("@LUONGCOBAN", SqlDbType.Decimal).Value = txbLuongCB.Text;
                    sqlCommand.Parameters.AddWithValue("@PHUCAP", SqlDbType.Decimal).Value = txbPhuCap.Text;
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void dgvNhanVien_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            if(e.CommandName == "Edit")
            {
                txbMaNhanVien.Text = dgvNhanVien.Rows[row].Cells[0].Text;
                txbHo.Text = dgvNhanVien.Rows[row].Cells[1].Text;
                txbTen.Text = dgvNhanVien.Rows[row].Cells[2].Text;
                txbNgaySinh.Text = dgvNhanVien.Rows[row].Cells[3].Text;
                txbNgayLamViec.Text = dgvNhanVien.Rows[row].Cells[4].Text;
                txbDiaChi.Text = dgvNhanVien.Rows[row].Cells[5].Text;
                txbLuongCB.Text = dgvNhanVien.Rows[row].Cells[6].Text;
                txbPhuCap.Text = dgvNhanVien.Rows[row].Cells[7].Text;
            }
            else if (e.CommandName == "Delete")
            {
                string cmd = "DELETE FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MANHANVIEN", dgvNhanVien.Rows[row].Cells[0].Text);
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        protected void dgvNhanVien_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvNhanVien_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}