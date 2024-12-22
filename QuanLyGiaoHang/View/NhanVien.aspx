<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhanVien.aspx.cs" Inherits="QuanLyGiaoHang.View.NhanVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Quan Ly Nhan Vien<br />
            <asp:Label ID="Label1" runat="server" Text="Ma nhan vien"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbMaNhanVien" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ho"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbHo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ten"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txbTen" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Ngay sinh"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbNgaySinh" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Ngay lam viec"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbNgayLamViec" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Dia chi"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbDiaChi" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Luong co ban"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbLuongCB" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Phu cap"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txbPhuCap" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsert" runat="server" Text="Them" OnClick="btnInsert_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Cap nhat" OnClick="btnUpdate_Click" />
            <br />
            <asp:GridView ID="dgvNhanVien" runat="server" AutoGenerateColumns="False" OnRowCommand="dgvNhanVien_RowCommand" OnRowDeleting="dgvNhanVien_RowDeleting" OnRowEditing="dgvNhanVien_RowEditing" >
            <Columns>
                <asp:BoundField DataField="MANHANVIEN" HeaderText="Ma Nhan Vien" />
                <asp:BoundField DataField="HO" HeaderText="Ho" />
                <asp:BoundField DataField="TEN" HeaderText="Ten" />
                <asp:BoundField DataField="NGAYSINH" HeaderText="Ngay sinh" />
                <asp:BoundField DataField="NGAYLAMVIEC" HeaderText="Ngay lam viec" />
                <asp:BoundField DataField="DIACHI" HeaderText="Dia chi" />
                <asp:BoundField DataField="LUONGCOBAN" HeaderText="Luong co ban" />
                <asp:BoundField DataField="PHUCAP" HeaderText="Phu cap" />
                <asp:CommandField ButtonType="Button" HeaderText="Edit" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
                <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
            </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
