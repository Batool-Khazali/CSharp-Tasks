﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page 1.aspx.cs" Inherits="test.page_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Click Me :)" OnClick="Button1_Click" PostBackUrl="page 2.aspx" />
        </div>
    </form>
</body>
</html>