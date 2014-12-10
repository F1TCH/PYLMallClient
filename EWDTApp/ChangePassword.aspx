<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="EWDTApp.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>Change Password</h1>
        <h4>It's good that you keep the habit of changing your password to make your account secure!</h4>

        <div class="ProfileBody">
            <br />
            <table style="width: 100%;">
                <tr>
                    <td>Current Password: </td>
                    <td>
                        <asp:Textbox ID="tbxCurrentPw" runat="server" TextMode="Password" ForeColor="Black"></asp:Textbox></td>
                </tr>
                <tr>
                    <td>New Password: </td>
                    <td>
                        <asp:Textbox ID="tbxPassword" runat="server" TextMode="Password" ForeColor="Black"></asp:Textbox></td>
                </tr>
                <tr>
                    <td>Retype New Password: </td>
                    <td>
                        <asp:Textbox ID="tbxRetypePw" runat="server" TextMode="Password" ForeColor="Black"></asp:Textbox>

                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnChange" runat="server" Text ="Change Password now" ForeColor="Black" />
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
