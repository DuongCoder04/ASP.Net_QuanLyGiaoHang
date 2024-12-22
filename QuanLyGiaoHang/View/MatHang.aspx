<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatHang.aspx.cs" Inherits="QuanLyGiaoHang.View.MatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            Quan Ly Mat Hang<br />
            <asp:Label ID="Label1" runat="server" Text="Ma mat hang"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaMatHang" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ten hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbTenHang" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ma cong ty"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaCongTy" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Ma loai hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaLoaiHang" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Don vi tinh"></asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbDonViTinh" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Gia hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbGiaHang" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Them" OnClick="btnInsert_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Cap nhat" OnClick="btnUpdate_Click" />
            <br />
            <asp:GridView ID="dgvMatHang" runat="server" AutoGenerateColumns="False" OnRowCommand="dgvMatHang_RowCommand" OnRowDeleting="dgvMatHang_RowDeleting" OnRowEditing="dgvMatHang_RowEditing" >
            <Columns>
                <asp:BoundField DataField="MAMATHANG" HeaderText="Ma mat hang" />
                <asp:BoundField DataField="TENHANG" HeaderText="Ten hang" />
                <asp:BoundField DataField="MACONGTY" HeaderText="Ma cong ty" />
                <asp:BoundField DataField="MALOAIHANG" HeaderText="Ma loai hang" />
                <asp:BoundField DataField="DONVITINH" HeaderText="Don vi tinh" />
                <asp:BoundField DataField="GIAHANG" HeaderText="Gia hang" />
                <asp:CommandField ButtonType="Button" HeaderText="Edit" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
                <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
            </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
