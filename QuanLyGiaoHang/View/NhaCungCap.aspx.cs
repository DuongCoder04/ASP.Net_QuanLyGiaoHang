using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyGiaoHang.View
{
    public partial class NhaCungCap : System.Web.UI.Page
    {
        string strCon = "server = ACERNITRO5\\VANDUONG; database=QuanLyGiaoHang; Trusted_Connection= true";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from NHACUNGCAP";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dgvNhaCungCap.DataSource = sqlDataReader;
                dgvNhaCungCap.DataBind();
            }
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO NHACUNGCAP(MACONGTY,TENCONGTY,TENGIAODICH,DIACHI,EMAIL,DIENTHOAI,FAX) VALUES(@MACONGTY,@TENCONGTY,@TENGIAODICH,@DIACHI,@EMAIL,@DIENTHOAI,@FAX)";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MACONGTY", txbMaCT.Text);
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
            string cmd = "UPDATE NHACUNGCAP SET TENCONGTY=@TENCONGTY,TENGIAODICH=@TENGIAODICH,DIACHI=@DIACHI,EMAIL=@EMAIL,DIENTHOAI=@DIENTHOAI,FAX=@FAX WHERE MACONGTY=@MACONGTY";
            using (SqlConnection sqlConnection = new SqlConnection(strCon))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MACONGTY", txbMaCT.Text);
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

        protected void dgvNhaCungCap_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "Edit")
            {
                txbMaCT.Text = dgvNhaCungCap.Rows[row].Cells[0].Text;
                txbTenCT.Text = dgvNhaCungCap.Rows[row].Cells[1].Text;
                txbTenGiaoDich.Text = dgvNhaCungCap.Rows[row].Cells[2].Text;
                txbDiaChi.Text = dgvNhaCungCap.Rows[row].Cells[3].Text;
                txbEmail.Text = dgvNhaCungCap.Rows[row].Cells[4].Text;
                txbDienThoai.Text = dgvNhaCungCap.Rows[row].Cells[5].Text;
                txbFax.Text = dgvNhaCungCap.Rows[row].Cells[6].Text;
            }
            else if (e.CommandName == "Delete")
            {
                string cmd = "DELETE FROM NHACUNGCAP WHERE MACONGTY=@MACONGTY";
                using (SqlConnection sqlConnection = new SqlConnection(strCon))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MACONGTY", dgvNhaCungCap.Rows[row].Cells[0].Text);
                    sqlCommand.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        protected void dgvNhaCungCap_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvNhaCungCap_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}