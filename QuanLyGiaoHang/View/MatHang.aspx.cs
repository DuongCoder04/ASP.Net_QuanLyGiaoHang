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
    public partial class MatHang : System.Web.UI.Page
    {
        string strCon = "server = ACERNITRO5\\VANDUONG; database=QuanLyGiaoHang; Trusted_Connection= true";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from MATHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dgvMatHang.DataSource = sqlDataReader;
                dgvMatHang.DataBind();
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO MATHANG VALUES(@MAMATHANG, @TENHANG, @MACONGTY, @MALOAIHANG, @DONVITINH, @GIAHANG)";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MAMATHANG", txbMaMatHang.Text);
                sqlCommand.Parameters.AddWithValue("@TENHANG", txbTenHang.Text);
                sqlCommand.Parameters.AddWithValue("@MACONGTY", txbMaCongTy.Text);
                sqlCommand.Parameters.AddWithValue("@MALOAIHANG", txbMaLoaiHang.Text);
                sqlCommand.Parameters.AddWithValue("@DONVITINH", txbDonViTinh.Text);
                sqlCommand.Parameters.Add("@GIAHANG", SqlDbType.Decimal).Value = txbGiaHang.Text;
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE MATHANG SET TENHANG=@TENHANG,MACONGTY=@MACONGTY,MALOAIHANG=@MALOAIHANG,DONVITINH=@DONVITINH,GIAHANG=@GIAHANG WHERE MAMATHANG=@MAMATHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MAMATHANG", txbMaMatHang.Text);
                sqlCommand.Parameters.AddWithValue("@TENHANG", txbTenHang.Text);
                sqlCommand.Parameters.AddWithValue("@MACONGTY", txbMaCongTy.Text);
                sqlCommand.Parameters.AddWithValue("@MALOAIHANG", txbMaLoaiHang.Text);
                sqlCommand.Parameters.AddWithValue("@DONVITINH", txbDonViTinh.Text);
                sqlCommand.Parameters.Add("@GIAHANG", SqlDbType.Decimal).Value = txbGiaHang.Text;
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void dgvMatHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            if(e.CommandName == "Delete")
            {
                string cmd = "DELETE FROM MATHANG WHERE MAMATHANG=@MAMATHANG";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MAMATHANG", dgvMatHang.Rows[row].Cells[0].Text);
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
            else if (e.CommandName == "Edit")
            {
                txbMaMatHang.Text = dgvMatHang.Rows[row].Cells[0].Text;
                txbTenHang.Text = dgvMatHang.Rows[row].Cells[1].Text;
                txbMaCongTy.Text = dgvMatHang.Rows[row].Cells[2].Text;
                txbMaLoaiHang.Text = dgvMatHang.Rows[row].Cells[3].Text;
                txbDonViTinh.Text = dgvMatHang.Rows[row].Cells[4].Text;
                txbGiaHang.Text = dgvMatHang.Rows[row].Cells[5].Text;
            }
        }

        protected void dgvMatHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvMatHang_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}