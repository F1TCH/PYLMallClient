<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ChangeEmailAddress.aspx.cs" Inherits="EWDTApp.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>Change Email Address</h1>
        <h4>It's good that you keep your email updated!</h4>

        <div class="ProfileBody">
            <br />
            <table style="width: 100%;">
                <tr>
                    <td>Email: </td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>New Email Address: </td>
                    <td>
                        <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Retype Email Address: </td>
                    <td>
                        <asp:TextBox ID="tbxRetypeEmailAddress" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnChange" runat="server" Text ="Change Email Address" ForeColor="Black" OnClick="btnChange_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnBack" runat="server" Text="Back" ForeColor="Black" OnClick="btnBack_Click" />
                    </td>
                </tr>
                </table>

        </div>
    </div>
</asp:Content>
