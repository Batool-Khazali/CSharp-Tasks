<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page 2.aspx.cs" Inherits="test.page_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Why did you click?????????"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>You told me to</asp:ListItem>
                <asp:ListItem>I do what I want</asp:ListItem>
                <asp:ListItem>...</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="Button1" runat="server" Text=";)" OnClick="Button1_Click"  PostBackUrl="~/page 1.aspx" />
        </div>
    </form>
</body>
</html>
