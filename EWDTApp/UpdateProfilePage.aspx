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
                    <td>Username: </td>
                    <td>
                        <asp:TextBox ID="tbxUsername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>NRIC: </td>
                    <td>
                        <asp:TextBox ID="tbxNRIC" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email: </td>
                    <td>
                        <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Telephone Number</td>
                    <td>
                        <asp:TextBox ID="tbxTeleNum" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Handphone Number: </td>
                    <td>
                        <asp:TextBox ID="tbxHandPhoneNum" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:DropDownList ID="ddlGender" runat="server" ForeColor="Black">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Address: </td>
                    <td>
                        <asp:TextBox ID="tbxAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
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
