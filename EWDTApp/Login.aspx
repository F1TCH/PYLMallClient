<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EWDTApp.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="login_page">
        <div class="loginBox">
            <br />
            <h2>&nbspLogin</h2>
            <table>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp; Username: </td>
                    <td>
                        <asp:TextBox ID="tbxUsername" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp; Password : </td>
                    <td>
                        <asp:TextBox ID="tbxPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <br />
                    </td>

                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp; <a href="#">Forget Password</a>&nbsp;&nbsp; </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="81px" CssClass="btn btn-default" OnClick="btnLogin_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

            <%--Sign Up--%>
            <h2>&nbsp;Sign Up</h2>
            <table>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp; Username: </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpUser" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp; Password : </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpPass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; Email Address: </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; Telephone Number: </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpTeleNo" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; Handphone Number: </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpHpNo" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                

                <tr>
                    <td class="auto-style1">
                        <br />
                    </td>

                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp; &nbsp; </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSignUp" runat="server" Text="Login" Width="81px" CssClass="btn btn-default" OnClick="btnSignUp_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
