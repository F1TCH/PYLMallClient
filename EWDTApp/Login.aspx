<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EWDTApp.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 605px;
        }

        .auto-style2 {
            width: 755px;
        }
    </style>
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

            <%--Sign Up--%>
            <h2>&nbsp;Sign Up</h2>
            <table>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp; Username: </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpUser" runat="server" CssClass="form-control"></asp:TextBox></td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>NRIC:</td>
                    <td>
                        <asp:TextBox ID="tbxNric" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp; Password : </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpPass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>Gender: </td>
                    <td>
                        <asp:DropDownList ID="ddlGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; Email Address: </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
                    <td></td>
                    <td>Address: </td>
                    <td>
                        <textarea id="txtareaAddress" class="form-control" rows="3"></textarea></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; Telephone Number: </td>
                    <td>
                        <asp:TextBox ID="tbxSignUpTeleNo" runat="server" CssClass="form-control"></asp:TextBox></td>
                    <td></td>
                    <td>Date Of Birth</td>
                    <td>
                        <div class="form-group">
                            <div class="input-group">
                                <div class="input-group-addon">Day</div>
                                <label class="sr-only" for="exampleInputEmail2">DD</label>

                                <div class="input-group-addon">Month</div>
                                <input type="email" class="form-control" id="exampleInputEmail2" placeholder="Enter email">
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="sr-only" for="exampleInputPassword2">Password</label>
                            <input type="password" class="form-control" id="exampleInputPassword2" placeholder="Password">
                        </div>


                    </td>
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
