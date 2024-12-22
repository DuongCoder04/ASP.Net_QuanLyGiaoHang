<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietDatHang.aspx.cs" Inherits="QuanLyGiaoHang.View.ChiTietDatHang" %>

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
            <asp:Label ID="Label2" runat="server" Text="Ma mat hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaMH" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Gia ban"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbGiaBan" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="So luong"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbSoLuong" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Muc giam gia"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMucGiamGia" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Them" OnClick="btnInsert_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Cap nhat" OnClick="btnUpdate_Click" />
            <br />
            <asp:GridView ID="dgvChiTietDatHang" runat="server" AutoGenerateColumns="False" OnRowCommand="dgvChiTietDatHang_RowCommand" OnRowDeleting="dgvChiTietDatHang_RowDeleting" OnRowEditing="dgvChiTietDatHang_RowEditing">
                <Columns>
                    <asp:BoundField DataField="SOHOADON" HeaderText="So HD" />
                    <asp:BoundField DataField="MAMATHANG" HeaderText="Ma MH" />
                    <asp:BoundField DataField="GIABAN" HeaderText="Gia ban" />
                    <asp:BoundField DataField="SOLUONG" HeaderText="So luong" />
                    <asp:BoundField DataField="MUCGIAMGIA" HeaderText="Muc giam gia" />
                    <asp:CommandField ButtonType="Button" HeaderText="Edit" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
                    <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
