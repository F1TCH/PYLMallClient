<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_Admin.aspx.cs" Inherits="EWDTApp.login_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css/Login.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="Login">
            <h2>&nbsp;&nbsp; Login</h2>
            <ul>
                <li>Username: 
                    <asp:TextBox ID="tbxUsername" runat="server" CssClass="form-control"></asp:TextBox>
                </li>
                <li>&nbsp</li>
                <li>Password : 
                    <asp:TextBox ID="tbxPassword" runat="server" CssClass="form-control"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp; </li>
            </ul>
            <p style="margin-left: 40px">
                &nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <table>
                <tr>
                    <td><a href="#">Sign Up</a></td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="81px" CssClass="btn btn-default" OnClick="btnLogin_Click" />

                    </td>
                </tr>
                <tr>
                    <td><a href="#">Forget Password</a></td>
                </tr>
            </table>
            <br />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
