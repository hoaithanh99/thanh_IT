<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="cau4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
            width: 661px;
        }
        .auto-style2 {
            height: 33px;
            width: 661px;
        }
        .auto-style3 {
            height: 31px;
            width: 257px;
        }
        .auto-style4 {
            height: 33px;
            width: 257px;
        }
        .auto-style5 {
            width: 257px;
        }
        .auto-style6 {
            width: 75%;
        }
        .auto-style7 {
            width: 661px;
        }
        .auto-style8 {
            margin-left: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="color: #000000; font-weight: bold">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ĐĂNG KÝ THÀNH VIÊN</div>
        <table class="auto-style6">
            <tr>
                <td class="auto-style3">Tên đăng nhập:</td>
                <td class="auto-style1" style="color: #000000">
                    <asp:TextBox ID="txtdn" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Mật khẩu:</td>
                <td class="auto-style2" style="color: #000000">
                    <asp:TextBox ID="txtmk" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Nhập lại mật khẩu:</td>
                <td class="auto-style7" style="color: #000000">
                    <asp:TextBox ID="txtnhaplaimk" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Email:</td>
                <td class="auto-style7" style="color: #000000">
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Giới tính:</td>
                <td class="auto-style7" style="color: #000000">
                    <asp:RadioButton ID="rdbNam" runat="server" Text="Nam" />
                    <asp:RadioButton ID="rdbNu" runat="server" Text="Nữ" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Ngày sinh:</td>
                <td class="auto-style7" style="color: #000000">
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Sở thích:</td>
                <td class="auto-style7" style="color: #000000">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Thể thao" />
                    <br />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Mua sắm" />
                    <br />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Âm nhạc" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="btndangky" runat="server" OnClick="btndangky_Click" Text="Đăng ký" Width="80px" />
                    <asp:Button ID="btnnhaplai" runat="server" Text="Nhập lại" OnClick="btnnhaplai_Click" CssClass="auto-style8" Width="94px" />
                </td>
            </tr>
        </table>
        
    </form>
    
</body>
</html>
