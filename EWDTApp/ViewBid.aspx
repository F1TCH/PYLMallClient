<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ViewBid.aspx.cs" Inherits="EWDTApp.WebForm12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1096px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>View Current Bid</h1>
        <h3>View the bids that you currently have</h3>

        <table class="auto-style1" border="1">
            <tr>
                <td>Bidding Amount <asp:Label ID="lblBA" runat="server" Text=""></asp:Label></td>
                <td>Date</td>
                <td>Time</td>
                <td>
                    <asp:Button ID="Button1" runat="server" ForeColor="Black" Height="37px" OnClick="Button1_Click" Text="Create Bid" Width="149px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    $ <asp:Label ID ="lblBiddingAmount" runat="server" Text=""></asp:Label></td>
                <td>
                    <asp:Label ID ="lblDate" runat="server" Text=""></asp:Label></td>
                <td>
                    <asp:Label ID ="lblTime" runat="server" Text=""></asp:Label></td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" ForeColor="Black" OnClick="btnUpdate_Click" /></td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" ForeColor="Black" OnClick="btnDelete_Click" /></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
