<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task 2.aspx.cs" Inherits="Task_2.Task_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet1.css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

    <title></title>
</head>
<body>

    <%--the form is a template from https://codepen.io/chetanhaobijam/pen/ZEQeYNP WITHOUT the JS--%>

    <form id="form1" runat="server">
        <div>

            <main>
              <h1>Calculation of two numbers</h1>
              <form>

                <div class="form-inline">
                    <asp:TextBox ID="firstNumber" runat="server" CssClass="form-control" placeholder="Enter your 1st number"></asp:TextBox>
                    <asp:TextBox ID="secondNumber" runat="server" CssClass="form-control" placeholder="Enter your 2nd number"></asp:TextBox>
                </div>

                <div class="form-inline">
                    <asp:Button ID="add" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="add_Click" />
                    <asp:Button ID="subtract" runat="server" Text="Subtract" CssClass="btn btn-danger" OnClick="subtract_Click" />
                </div>

                <div class="form-inline">
                    <asp:Button ID="multiply" runat="server" Text="Multiply" CssClass="btn btn-info" OnClick="multiply_Click" />
                    <asp:Button ID="divide" runat="server" Text="Divide" CssClass="btn btn-warning" OnClick="divide_Click" />
                </div>

                <div class="form-group">
                  <div class="text-center mb-lg-4">The result is:</div>
                    <asp:TextBox ID="result" runat="server" CssClass="form-control" placeholder="Result" Enabled="false" ></asp:TextBox>
                </div>

              </form>
            </main>

        </div>
    </form>
</body>
</html>
