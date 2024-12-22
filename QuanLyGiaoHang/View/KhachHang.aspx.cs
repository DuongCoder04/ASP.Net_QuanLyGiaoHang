using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyGiaoHang.View
{
    public partial class KhachHang : System.Web.UI.Page
    {
        string strCon = "server = ACERNITRO5\\VANDUONG; database=QuanLyGiaoHang; Trusted_Connection= true";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from KHACHHANG";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dgvKhachHang.DataSource = sqlDataReader;
                dgvKhachHang.DataBind();
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO KHACHHANG(MAKHACHHANG,TENCONGTY,TENGIAODICH,DIACHI,EMAIL,DIENTHOAI,FAX) VALUES(@MAKHACHHANG,@TENCONGTY,@TENGIAODICH,@DIACHI,@EMAIL,@DIENTHOAI,@FAX)";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MAKHACHHANG", txbMaKH.Text);
                sqlCommand.Parameters.AddWithValue("@TENCONGTY", txbTenCT.Text);
                sqlCommand.Parameters.AddWithValue("@TENGIAODICH", txbTenGiaoDich.Text);
                sqlCommand.Parameters.AddWithValue("@DIACHI", txbDiaChi.Text);
                sqlCommand.Parameters.AddWithValue("@EMAIL", txbEmail.Text);
                sqlCommand.Parameters.AddWithValue("@DIENTHOAI", txbDienThoai.Text);
                sqlCommand.Parameters.AddWithValue("@FAX", txbFax.Text);
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE KHACHHANG SET TENCONGTY=@TENCONGTY,TENGIAODICH=@TENGIAODICH,DIACHI=@DIACHI,EMAIL=@EMAIL,DIENTHOAI=@DIENTHOAI,FAX=@FAX WHERE MAKHACHHANG=@MAKHACHHANG";
            using(SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MAKHACHHANG", txbMaKH.Text);
                sqlCommand.Parameters.AddWithValue("@TENCONGTY", txbTenCT.Text);
                sqlCommand.Parameters.AddWithValue("@TENGIAODICH", txbTenGiaoDich.Text);
                sqlCommand.Parameters.AddWithValue("@DIACHI", txbDiaChi.Text);
                sqlCommand.Parameters.AddWithValue("@EMAIL", txbEmail.Text);
                sqlCommand.Parameters.AddWithValue("@DIENTHOAI", txbDienThoai.Text);
                sqlCommand.Parameters.AddWithValue("@FAX", txbFax.Text);
                sqlCommand.ExecuteNonQuery();
                LoadData();
            }
        }

        protected void dgvKhachHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "Edit")
            {
                txbMaKH.Text = dgvKhachHang.Rows[row].Cells[0].Text;
                txbTenCT.Text = dgvKhachHang.Rows[row].Cells[1].Text;
                txbTenGiaoDich.Text = dgvKhachHang.Rows[row].Cells[2].Text;
                txbDiaChi.Text = dgvKhachHang.Rows[row].Cells[3].Text;
                txbEmail.Text = dgvKhachHang.Rows[row].Cells[4].Text;
                txbDienThoai.Text = dgvKhachHang.Rows[row].Cells[5].Text;
                txbFax.Text = dgvKhachHang.Rows[row].Cells[6].Text;
            }
            else if (e.CommandName =="Delete")
            {
                string cmd = "DELETE FROM KHACHHANG WHERE MAKHACHHANG=@MAKHACHHANG";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MAKHACHHANG", dgvKhachHang.Rows[row].Cells[0].Text);
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        protected void dgvKhachHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvKhachHang_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}