<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonDatHang.aspx.cs" Inherits="QuanLyGiaoHang.View.DonDatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Quan Ly Khach Hang<br />
            <asp:Label ID="Label1" runat="server" Text="So hoa don"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbSoHD" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ma khach hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaKH" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ma nhan vien"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaNV" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Ngay dat hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbNgayDatHang" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Ngay giao hang"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbNgayGiaoHang" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Ngay chuyen hang"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txbNgayChuyenHang" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Nguoi giao hang"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbNguoiGiaoHang" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Them" OnClick="btnInsert_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Cap nhat" OnClick="btnUpdate_Click" />
            <br />
            <asp:GridView ID="dgvDonDatHang" runat="server" AutoGenerateColumns="False" OnRowCommand="dgvDonDatHang_RowCommand" OnRowDeleting="dgvDonDatHang_RowDeleting" OnRowEditing="dgvDonDatHang_RowEditing">
                <Columns>
                    <asp:BoundField DataField="SOHOADON" HeaderText="So HD" />
                    <asp:BoundField DataField="MAKHACHHANG" HeaderText="Ma KH" />
                    <asp:BoundField DataField="MANHANVIEN" HeaderText="Ma NV" />
                    <asp:BoundField DataField="NGAYDATHANG" HeaderText="Ngay dat hang" />
                    <asp:BoundField DataField="NGAYGIAOHANG" HeaderText="Ngay giao hang" />
                    <asp:BoundField DataField="NGAYCHUYENHANG" HeaderText="Ngay chuyen hang" />
                    <asp:BoundField DataField="NGUOIGIAOHANG" HeaderText="Nguoi giao hang" />
                    <asp:CommandField ButtonType="Button" HeaderText="Edit" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
                    <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
