<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contacts.aspx.cs" Inherits="test.contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <title></title>
</head>
<body>

    <%--the form is a template--%>

    <form id="form1" runat="server">
        <div>

            <div class="jumbotron text-center">
              <h1 class="display-3">Thank You!</h1>
              <p class="lead"><strong>Please check your email</strong> for our response.</p>
              <hr>
              <p>
                Having trouble? <a href="https://bootstrapcreative.com/">Contact us</a>
              </p>
              <p class="lead">
                  <asp:Button ID="Button2" runat="server" Text="Go back to homepage" CssClass="btn btn-primary btn-sm" OnClick="Button2_Click1" />
              </p>
            </div>

        </div>
    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" integrity="sha384-BBtl+eGJRgqQAUMxJ7pMwbEyER4l1g+O15P+16Ep7Q9Q+zqX6gSbd85u4mG4QzX+" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
