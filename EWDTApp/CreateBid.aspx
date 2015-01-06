<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="CreateBid.aspx.cs" Inherits="EWDTApp.WebForm10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>Create a Bid</h1>
        <h4>Bid for a room</h4>

        <div class="ProfileBody">
            <h2 style="text-align:center">Minimum bid: $10,000</h2><br />
            <table style="width: 100%;">
                <tr>
                    <td>Username: </td>
                    <td>
                        <asp:Label ID="lblUsername" runat="server" ForeColor="Black"></asp:Label></td>
                </tr>
                <tr>
                    <td>Bidding amount: </td>
                    <td>
                        <asp:TextBox ID="tbxBiddingAmount" runat="server" ForeColor="Black"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Date:</td>
                    <td>
                        <asp:Label ID="lblDate" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Time:</td>
                    <td>
                        <asp:Label ID="lblTime" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCreateBid" runat="server" Text="Create Bid" ForeColor="Black" OnClick="btnCreateBid_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnBack" runat="server" Text="Back " ForeColor="Black" OnClick="btnBack_Click" Width="181px" Height="32px" />
                    </td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>
