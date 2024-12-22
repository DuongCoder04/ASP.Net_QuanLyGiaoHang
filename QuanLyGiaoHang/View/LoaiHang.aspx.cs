using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyGiaoHang.View
{
    public partial class LoaiHang : System.Web.UI.Page
    {
        string strCon = "server = ACERNITRO5\\VANDUONG; database=QuanLyGiaoHang; Trusted_Connection= true";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from LOAIHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dgvLoaiHang.DataSource = sqlDataReader;
                dgvLoaiHang.DataBind();
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO LOAIHANG VALUES(@MALOAIHANG, @TENLOAIHANG)";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MALOAIHANG", txbMaLoaiHang.Text);
                sqlCommand.Parameters.AddWithValue("@TENLOAIHANG", txbTenLoaiHang.Text);
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE LOAIHANG SET TENLOAIHANG=@TENLOAIHANG WHERE MALOAIHANG=@MALOAIHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MALOAIHANG", txbMaLoaiHang.Text);
                sqlCommand.Parameters.AddWithValue("@TENLOAIHANG", txbTenLoaiHang.Text);
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void dgvLoaiHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "Edit")
            {
                txbMaLoaiHang.Text = dgvLoaiHang.Rows[row].Cells[0].Text;
                txbTenLoaiHang.Text = dgvLoaiHang.Rows[row].Cells[1].Text;
            }
            else if (e.CommandName == "Delete")
            {
                string cmd = "DELETE FROM LOAIHANG WHERE MALOAIHANG=@MALOAIHANG";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MALOAIHANG", dgvLoaiHang.Rows[row].Cells[0].Text);
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        protected void dgvLoaiHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvLoaiHang_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}