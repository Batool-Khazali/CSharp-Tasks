<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="informatiom form.aspx.cs" Inherits="in_class_task.informatiom_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet1.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <div class="formbold-main-wrapper">
              <div class="formbold-form-wrapper">
                <img src="Images/360_F_274471125_mRSXEz1XhtmZtmjS8H3gTNFH2aYtLWcy.jpg">
                <form action="https://formbold.com/s/FORM_ID" method="POST">

                  <div class="formbold-input-group">
                      <asp:Label ID="NameLabel" runat="server" Text="Name" CssClass="formbold-form-label">Name</asp:Label>
                      <asp:TextBox ID="NameBox" runat="server" CssClass="formbold-form-input" placeholder="Enter your name"></asp:TextBox>
                  </div>

                  <div class="formbold-input-group">
                    <asp:Label ID="EmailLabel" runat="server" Text="Name" CssClass="formbold-form-label">E-mail</asp:Label>
                    <asp:TextBox ID="EmailBox" runat="server" CssClass="formbold-form-input" placeholder="Enter your E-mail"></asp:TextBox>
                </div>

                  <div class="formbold-input-group">
                    <asp:Label ID="IdLabel" runat="server" Text="Name" CssClass="formbold-form-label">ID</asp:Label>
                    <asp:TextBox ID="IdBox" runat="server" CssClass="formbold-form-input" placeholder="Enter your ID"></asp:TextBox>
                </div>

                  <div class="formbold-input-radio-wrapper">
                    <asp:Label ID="GenderLabel" runat="server" Text="Name" CssClass="formbold-form-label">Gender</asp:Label>

                      <asp:RadioButtonList ID="GenderRadioBox" runat="server" OnSelectedIndexChanged="GenderRadio_SelectedIndexChanged">
                          <asp:ListItem CssClass="formbold-input-radio">Male</asp:ListItem>
                          <asp:ListItem  CssClass="formbold-input-radio">Female</asp:ListItem>
                      </asp:RadioButtonList>
                  </div>

                  <div class="formbold-input-radio-wrapper">
                        <asp:Label ID="CoursesLabel" runat="server" Text="Courses" CssClass="formbold-form-label">Courses</asp:Label>

                      <asp:CheckBoxList ID="CoursesCheckBox" runat="server">
                          <asp:ListItem>C</asp:ListItem>
                          <asp:ListItem>C#</asp:ListItem>
                          <asp:ListItem>C++</asp:ListItem>
                        </asp:CheckBoxList>

                  </div>

                  <div>
                      <asp:Label ID="MessageLabel" runat="server" Text="Message" CssClass="formbold-form-label">Message</asp:Label>
                      <asp:TextBox ID="MessageBox" runat="server" TextMode="MultiLine" placeholder="Enter your message ..." CssClass="formbold-form-input"></asp:TextBox>
                  </div>

                    <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="formbold-btn" OnClick="Button1_Click" />
                </form>
              </div>
            </div>



            <asp:Panel ID="output" runat="server" CssClass="formbold-main-wrapper-output" Visible="false">

                <h2>Personal Information</h2>
                 <br />
                <div>
                      <asp:Label ID="NameL" runat="server" Text="Name" >Name: </asp:Label>
                      <asp:Label ID="NameOutput" runat="server" Text=" "></asp:Label>
                </div>
                <br />
                <div>
                      <asp:Label ID="EmailL" runat="server" Text="Emai">E-mail: </asp:Label>
                      <asp:Label ID="EmailOutput" runat="server" Text=" "></asp:Label>
                </div>
                <br />
                <div>
                      <asp:Label ID="IdL" runat="server" Text="Id">ID: </asp:Label>
                      <asp:Label ID="IdOutput" runat="server" Text=" "></asp:Label>
                </div>
                <br />
                <div>
                      <asp:Label ID="GenderL" runat="server" Text="Gender" >Gender: </asp:Label>
                      <asp:Label ID="GenderOutput" runat="server" Text=" "></asp:Label>
                </div>
                <br />
                <div>
                      <asp:Label ID="CoursesL" runat="server" Text="Courses" >Courses: </asp:Label>
                      <asp:Label ID="CoursesOutput" runat="server" Text=" "></asp:Label>
                </div>
                <br />
                <div>
                      <asp:Label ID="MessageL" runat="server" Text="Message" >Message: </asp:Label>
                      <asp:Label ID="MessageOutput" runat="server" Text=" "></asp:Label>
                </div>

            </asp:Panel>
           


        </div>

    </form>

</body>
</html>
