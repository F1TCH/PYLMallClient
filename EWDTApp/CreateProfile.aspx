<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="CreateProfile.aspx.cs" Inherits="EWDTApp.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>Create Profile Information</h1>
        <h4>Insert in your profile information</h4>

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
                        <asp:Button ID="btnCreateProfile" runat="server" Text="Create" ForeColor="Black" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnBack" runat="server" Text="Back to profile page!" ForeColor="Black" OnClick="btnBack_Click" Width="287px" />
                    </td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>
