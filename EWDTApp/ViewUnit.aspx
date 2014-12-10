<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ViewUnit.aspx.cs" Inherits="EWDTApp.WebForm13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 424px;
            width: 506px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="ProfilePage">
        <h1>View a Unit</h1>
        <h4>Take a look at all of our unit</h4>

        <div class="ProfileBody">
            <img alt="" class="auto-style1" src="Images/Paya-Lebar-Square.jpg" /><br />
            <br />
            <asp:Label ID="lblUnit" runat="server" Text="Unit No. : #"></asp:Label>
            <asp:DropDownList ID="ddlUnit" runat="server" ForeColor="Black">
                <asp:ListItem Text="01-01"></asp:ListItem>
                <asp:ListItem Text="01-02"></asp:ListItem>
                <asp:ListItem Text="01-03"></asp:ListItem>
                <asp:ListItem Text="01-04"></asp:ListItem>
                <asp:ListItem Text="01-05"></asp:ListItem>
                <asp:ListItem Text="01-06"></asp:ListItem>
                <asp:ListItem Text="01-07"></asp:ListItem>
                <asp:ListItem Text="01-08"></asp:ListItem>
                <asp:ListItem Text="01-09"></asp:ListItem>
                <asp:ListItem Text="01-10"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnView" runat="server" Text="View" Height="24px" Width="66px" ForeColor="Black" Font-Bold="True" Font-Size="15px"/><br />
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnViewBid" runat="server" Text ="View Bid" ForeColor="Black" OnClick="btnViewBid_Click" /><br />

        </div>
    </div>  
</asp:Content>
