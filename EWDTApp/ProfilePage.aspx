﻿<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="EWDTApp.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>Profile Information</h1>
        <h4>Displays all the information about you!</h4>

        <div class="ProfileBody">
            <br />
            <table style="width: 100%;">
                <tr>
                    <td>Username: </td>
                    <td>
                        <asp:Label ID="lblUsername" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>NRIC: </td>
                    <td>
                        <asp:Label ID="lblNRIC" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Email: </td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Telephone Number</td>
                    <td>
                        <asp:Label ID="lblTeleNum" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Handphone Number: </td>
                    <td>
                        <asp:Label ID="lblHandPhoneNum" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                       <asp:Label ID="lblGender" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnChangeEmail" runat="server" Text="Change Email Address And Password" ForeColor="Black" OnClick="btnChangeEmail_Click"/>
                    </td>
                    <td>
                    <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" ForeColor="Black" OnClick="btnUpdateProfile_Click" />
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnDelete" runat="server" Text="Delete" ForeColor="Black" OnClick="btnDelete_Click"/>
                        <asp:Label ID="lblStatus" runat="server" Text =""></asp:Label>
                    </td>
                    <td>
                    <asp:Button ID="btnDeleteProfile" runat="server" Text="Delete Profile" ForeColor="Black" OnClick="btnDeleteProfile_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>
