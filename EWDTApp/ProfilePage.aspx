<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="EWDTApp.WebForm4" %>

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
                        <button id="btnGroupVerticalDrop1" type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-expanded="false">
                            Dropdown
          <span class="caret"></span>
                        </button>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>

                </tr>
            </table>

        </div>
    </div>
</asp:Content>
