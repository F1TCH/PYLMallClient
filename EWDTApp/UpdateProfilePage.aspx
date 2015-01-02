<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="EWDTApp.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>Update Profile Information</h1>
        <h4>Keep your profile updated on the Go!</h4>

        <div class="ProfileBody">
            <br />
            <table style="width: 100%;">
                <tr>
                    <td>Telephone Number</td>
                    <td>
                        <asp:TextBox ID="tbxTeleNum" runat="server" ForeColor="Black"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Handphone Number: </td>
                    <td>
                        <asp:TextBox ID="tbxHandPhoneNum" runat="server" ForeColor="Black"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblStatus" runat ="server" Text=""></asp:Label></td>
                    <td>
                        <asp:Button ID="btnUpdateProfile" runat="server" Text="Update now!" ForeColor="Black" OnClick="btnUpdateProfile_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnBack" runat="server" Text="Back to profile page!" ForeColor="Black" Width="287px" OnClick="btnBack_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>
