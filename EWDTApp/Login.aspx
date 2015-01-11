<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EWDTApp.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 605px;
        }

        .auto-style2 {
            width: 1000px;
        }

        .auto-style3 {
            width: 177px;
        }
        .auto-style4 {
            width: 1421px;
        }
        .auto-style5 {
            width: 1000px;
        }
        .auto-style6 {
            width: 1020px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="login_page">
        <div class="loginBox">
            <br />
            <h2>&nbspLogin</h2>
            <table class="loginTable">
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp; Username: </td>
                    <td>
                        <asp:TextBox ID="tbxUsername" runat="server" CssClass="form-control" Width="213px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp; Password : </td>
                    <td>
                        <asp:TextBox ID="tbxPassword" runat="server" CssClass="form-control" TextMode="Password" Width="213px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <br />
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp; <a href="#">Forget Password</a>&nbsp;&nbsp; </td>
                    <td>&nbsp;&nbsp;<asp:Label ID="lblStatus" runat="server"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="81px" CssClass="btn btn-default" OnClick="btnLogin_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
        </div>

        <%--Sign Up--%>
        <h2>&nbsp;Sign Up</h2>
        <table class="loginTablebtm" style="table-layout: auto; width: 1500px;">
            <tr>
                <td class="auto-style1">Username: </td>
                <td>
                    <asp:TextBox ID="tbxSignUpUser" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">NRIC:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbxNric" runat="server" CssClass="form-control" Width="150px" TabIndex="6"></asp:TextBox></td>
                <td></td>
                <td class="auto-style4">Secret Question 1: </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="300px" ForeColor="Black">
                        <asp:ListItem>What is the name of your first pet?</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password : </td>
                <td>
                    <asp:TextBox ID="tbxSignUpPass" runat="server" CssClass="form-control" TextMode="Password" TabIndex="1"></asp:TextBox>
                    <ajaxToolkit:PasswordStrength ID="tbxSignUpPass_PasswordStrength" runat="server" TargetControlID="tbxSignUpPass">
                    </ajaxToolkit:PasswordStrength>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style6">Gender: </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlGender" runat="server" ForeColor="Black">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td></td>
                <td class="auto-style4">Answer: </td>
                <td>
                    <asp:TextBox ID="tbxSQAnswer1" runat="server" CssClass="form-control" Width="272px" TabIndex="8"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email Address: </td>
                <td>
                    <asp:TextBox ID="tbxSignUpEmail" runat="server" CssClass="form-control" TabIndex="3"></asp:TextBox></td>
                <td class="auto-style2"></td>
                <td class="auto-style6">Date Of Birth</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbxDOB" runat="server" CssClass="form-control" Width="150px" TabIndex="7"></asp:TextBox>

                    <ajaxToolkit:CalendarExtender ID="tbxDOB_CalendarExtender" runat="server" TargetControlID="tbxDOB">
                    </ajaxToolkit:CalendarExtender>

                </td>
                <td></td>
                <td class="auto-style4">Secret Question 2: </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="19px" Width="300px" ForeColor="Black">
                        <asp:ListItem>What is your mother&#39;s maiden name?</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>Telephone Number: </td>
                <td>
                    <asp:TextBox ID="tbxSignUpTeleNo" runat="server" CssClass="form-control" TabIndex="4"></asp:TextBox></td>
                <td class="auto-style2"></td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td></td>
                <td class="auto-style4">Answer: </td>
                <td><asp:TextBox ID="tbxSQAnswer2" runat="server" CssClass="form-control" Width="272px" TabIndex="9"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Handphone Number: </td>
                <td>
                    <asp:TextBox ID="tbxSignUpHpNo" runat="server" CssClass="form-control" TabIndex="5"></asp:TextBox></td>
            </tr>


            <tr>
                <td class="auto-style1">
                    <br />
                </td>

            </tr>
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp; &nbsp; </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" Width="81px" CssClass="btn btn-default" OnClick="btnSignUp_Click" />
                    <ajaxToolkit:ConfirmButtonExtender ID="btnSignUp_ConfirmButtonExtender" runat="server" TargetControlID="btnSignUp" ConfirmText=" ARE YOU SURE ?">
                    </ajaxToolkit:ConfirmButtonExtender>
                </td>
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
</asp:Content>
