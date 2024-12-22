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
    public partial class DonDatHang : System.Web.UI.Page
    {
        string strCon = "server = ACERNITRO5\\VANDUONG; database=QuanLyGiaoHang; Trusted_Connection= true";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from DONDATHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dgvDonDatHang.DataSource = sqlDataReader;
                dgvDonDatHang.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO DONDATHANG VALUES(@SOHOADON, @MAKHACHHANG, @MANHANVIEN, @NGAYDATHANG, @NGAYGIAOHANG, @NGAYCHUYENHANG, @NGUOIGIAOHANG)";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SOHOADON", txbSoHD.Text);
                sqlCommand.Parameters.AddWithValue("@MAKHACHHANG", txbMaKH.Text);
                sqlCommand.Parameters.AddWithValue("@MANHANVIEN", txbMaNV.Text);
                sqlCommand.Parameters.Add("@NGAYDATHANG", SqlDbType.Date).Value = txbNgayDatHang.Text;
                sqlCommand.Parameters.Add("@NGAYGIAOHANG", SqlDbType.Date).Value = txbNgayDatHang.Text;
                sqlCommand.Parameters.Add("@NGAYCHUYENHANG", SqlDbType.Date).Value = txbNgayDatHang.Text;
                sqlCommand.Parameters.AddWithValue("@NGUOIGIAOHANG", txbNguoiGiaoHang.Text);
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE DONDATHANG SET MAKHACHHANG = @MAKHACHHANG, MANHANVIEN = @MANHANVIEN, NGAYDATHANG = @NGAYDATHANG, NGAYGIAOHANG = @NGAYGIAOHANG, NGAYCHUYENHANG = @NGAYCHUYENHANG, NGUOIGIAOHANG = @NGUOIGIAOHANG Where SOHOADON=@SOHOADON";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SOHOADON", txbSoHD.Text);
                sqlCommand.Parameters.AddWithValue("@MAKHACHHANG", txbMaKH.Text);
                sqlCommand.Parameters.AddWithValue("@MANHANVIEN", txbMaNV.Text);
                sqlCommand.Parameters.Add("@NGAYDATHANG", SqlDbType.Date).Value = txbNgayDatHang.Text;
                sqlCommand.Parameters.Add("@NGAYGIAOHANG", SqlDbType.Date).Value = txbNgayDatHang.Text;
                sqlCommand.Parameters.Add("@NGAYCHUYENHANG", SqlDbType.Date).Value = txbNgayDatHang.Text;
                sqlCommand.Parameters.AddWithValue("@NGUOIGIAOHANG", txbNguoiGiaoHang.Text);
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void dgvDonDatHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "Edit")
            {
                txbSoHD.Text = dgvDonDatHang.Rows[row].Cells[0].Text;
                txbMaKH.Text = dgvDonDatHang.Rows[row].Cells[1].Text;
                txbMaNV.Text = dgvDonDatHang.Rows[row].Cells[2].Text;
                txbNgayDatHang.Text = dgvDonDatHang.Rows[row].Cells[3].Text;
                txbNgayGiaoHang.Text = dgvDonDatHang.Rows[row].Cells[4].Text;
                txbNgayChuyenHang.Text = dgvDonDatHang.Rows[row].Cells[5].Text;
                txbNguoiGiaoHang.Text = dgvDonDatHang.Rows[row].Cells[6].Text;
            }
            else if (e.CommandName == "Delete")
            {
                string cmd = "DELETE FROM DONDATHANG WHERE SOHOADON=@SOHOADON";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@SOHOADON", dgvDonDatHang.Rows[row].Cells[0].Text);
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        protected void dgvDonDatHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvDonDatHang_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}