using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace QuanLyGiaoHang.View
{
    public partial class ChiTietDatHang : System.Web.UI.Page
    {
        string strCon = "server = ACERNITRO5\\VANDUONG; database=QuanLyGiaoHang; Trusted_Connection= true";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from CHITIETDATHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dgvChiTietDatHang.DataSource = sqlDataReader;
                dgvChiTietDatHang.DataBind();
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO CHITIETDATHANG VALUES(@SOHOADON, @MAMATHANG, @GIABAN, @SOLUONG, @MUCGIAMGIA)";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SOHOADON", txbSoHD.Text);
                sqlCommand.Parameters.AddWithValue("@MAMATHANG", txbMaMH.Text);
                sqlCommand.Parameters.Add("@GIABAN", System.Data.SqlDbType.Decimal).Value = txbGiaBan.Text;
                sqlCommand.Parameters.AddWithValue("@SOLUONG", txbSoLuong.Text);
                sqlCommand.Parameters.Add("@MUCGIAMGIA", System.Data.SqlDbType.Decimal).Value = txbMucGiamGia.Text;
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE CHITIETDATHANG SET GIABAN=@GIABAN, SOLUONG=@SOLUONG, MUCGIAMGIA=@MUCGIAMGIA WHERE SOHOADON=@SOHOADON and MAMATHANG=@MAMATHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SOHOADON", txbSoHD.Text);
                sqlCommand.Parameters.AddWithValue("@MAMATHANG", txbMaMH.Text);
                sqlCommand.Parameters.Add("@GIABAN", System.Data.SqlDbType.Decimal).Value = txbGiaBan.Text;
                sqlCommand.Parameters.AddWithValue("@SOLUONG", txbSoLuong.Text);
                sqlCommand.Parameters.Add("@MUCGIAMGIA", System.Data.SqlDbType.Decimal).Value = txbMucGiamGia.Text;
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void dgvChiTietDatHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "Delete")
            {
                string cmd = "DELETE FROM CHITIETDATHANG WHERE SOHOADON=@SOHOADON and MAMATHANG=@MAMATHANG";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@SOHOADON", dgvChiTietDatHang.Rows[row].Cells[0].Text);
                    sqlCommand.Parameters.AddWithValue("@MAMATHANG", dgvChiTietDatHang.Rows[row].Cells[1].Text);
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
            else if (e.CommandName == "Edit")
            {
                txbSoHD.Text = dgvChiTietDatHang.Rows[row].Cells[0].Text;
                txbMaMH.Text = dgvChiTietDatHang.Rows[row].Cells[1].Text;
                txbGiaBan.Text = dgvChiTietDatHang.Rows[row].Cells[2].Text;
                txbSoLuong.Text = dgvChiTietDatHang.Rows[row].Cells[3].Text;
                txbMucGiamGia.Text = dgvChiTietDatHang.Rows[row].Cells[4].Text;
            }
        }

        protected void dgvChiTietDatHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvChiTietDatHang_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}