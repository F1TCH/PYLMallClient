﻿<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EWDTApp.WebForm2" %>

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

        .auto-style3 {
            width: 299px;
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
                    <td class="auto-style3">&nbsp;&nbsp; Username: </td>
                    <td>
                        <asp:TextBox ID="tbxUsername" runat="server" CssClass="form-control" Width="270px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp; Password : </td>
                    <td>
                        <asp:TextBox ID="tbxPassword" runat="server" CssClass="form-control" TextMode="Password" Width="270px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <br />
                    </td>

                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp; <a href="#">Forget Password</a>&nbsp;&nbsp; </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
        <table style="table-layout: auto; width: 1000px;">
            <tr>
                <td class="auto-style1">Username: </td>
                <td>
                    <asp:TextBox ID="tbxSignUpUser" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td class="auto-style2">&nbsp;</td>
                <td>NRIC:</td>
                <td>
                    <asp:TextBox ID="tbxNric" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td></td>
                <td>Secret Question 1: </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="121px">
                        <asp:ListItem>What is the name of your first pet?</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password : </td>
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
                <td></td>
                <td>Answer: </td>
                <td>
                    <asp:TextBox ID="tbxSQAnswer1" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email Address: </td>
                <td>
                    <asp:TextBox ID="tbxSignUpEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td></td>
                <td>Address: </td>
                <td>
                    <textarea id="txtareaAddress" class="form-control" rows="3"></textarea></td>
            </tr>
            <tr>
                <td>Telephone Number: </td>
                <td>
                    <asp:TextBox ID="tbxSignUpTeleNo" runat="server" CssClass="form-control"></asp:TextBox></td>
                <td></td>
                <td>Date Of Birth</td>
                <td>
                    <asp:TextBox ID="tbxDOB" runat="server" CssClass="form-control"></asp:TextBox>

                    <ajaxToolkit:CalendarExtender ID="tbxDOB_CalendarExtender" runat="server" TargetControlID="tbxDOB">
                    </ajaxToolkit:CalendarExtender>

                </td>
            </tr>
            <tr>
                <td>Handphone Number: </td>
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
</asp:Content>
