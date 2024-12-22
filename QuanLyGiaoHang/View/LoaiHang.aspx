<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoaiHang.aspx.cs" Inherits="QuanLyGiaoHang.View.LoaiHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Quan Ly Loai Hang<br />
            <asp:Label ID="Label1" runat="server" Text="Ma loai hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaLoaiHang" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ten loai hang"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbTenLoaiHang" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Them" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Cap nhat" />
            <br />
            <br />
            <asp:GridView ID="dgvLoaiHang" runat="server" AutoGenerateColumns="False" OnRowCommand="dgvLoaiHang_RowCommand" OnRowDeleting="dgvLoaiHang_RowDeleting" OnRowEditing="dgvLoaiHang_RowEditing">
                <Columns>
                    <asp:BoundField DataField="MALOAIHANG" HeaderText="Ma loai hang" />
                    <asp:BoundField DataField="TENLOAIHANG" HeaderText="Ten loai hang" />
                    <asp:CommandField ButtonType="Button" HeaderText="Edit" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
                    <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
