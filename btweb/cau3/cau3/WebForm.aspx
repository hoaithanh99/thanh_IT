<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="cau3.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtA" runat="server" Width="205px"></asp:TextBox>
        <asp:DropDownList ID="ddlNut" runat="server" AutoPostBack="True">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
            <asp:ListItem>%</asp:ListItem>
            <asp:ListItem>^</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtB" runat="server" Width="176px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCal" runat="server" OnClick="btnCal_Click" Text="Calculate" CssClass="auto-style1" />
        <br />
        Result: <asp:Label ID="lblKQ" runat="server"></asp:Label>
    </form>
</body>
</html>
