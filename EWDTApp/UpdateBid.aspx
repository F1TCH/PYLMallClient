﻿<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="UpdateBid.aspx.cs" Inherits="EWDTApp.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>Update a Bid</h1>
        <h4>Update Bid for a room</h4>

        <div class="ProfileBody">
            <h2 style="text-align:center">Minimum bid: $10,000</h2><br />
            <table style="width: 100%;">
                <tr>
                    <td>Username: </td>
                    <td>
                        <asp:Label ID="lblUsername" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Bidding amount: </td>
                    <td>
                        <asp:TextBox ID="tbxBiddingAmount" runat="server"></asp:TextBox></td>
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
                    <td><asp:Label ID ="lblStatus" runat = "server" Text =""></asp:Label></td>
                    <td>
                        <asp:Button ID="btnUpdateBid" runat="server" Text="Update Bid" ForeColor="Black" OnClick="btnUpdateBid_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnBack" runat="server" Text="Back" ForeColor="Black" OnClick="btnBack_Click" Width="287px" />
                    </td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>
