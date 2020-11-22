<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chuyendoi.aspx.cs" Inherits="ConvertWS.Chuyendoi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        <div>
            Tiền quy đổi:&nbsp;
            <asp:TextBox ID="txtTien" runat="server" Width="118px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnVND2USD" runat="server" OnClick="btnVND2USD_Click" Text="VND2USD" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnVND2EUR" runat="server" OnClick="btnVND2EUR_Click" Text="VND2EUR" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUSD2VND" runat="server" OnClick="btnUSD2VND_Click" Text="USD2VND" />
&nbsp;&nbsp;
            <asp:Button ID="btnEUR2VND" runat="server" OnClick="btnEUR2VND_Click" Text="EUR2VND" />
        </p>
        <p>
            Kết quả:&nbsp;
            <asp:Label ID="lblKetQua" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
