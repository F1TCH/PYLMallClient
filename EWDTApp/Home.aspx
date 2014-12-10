<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EWDTApp.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    TopJobAgency   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="jumbotron">
        <div class="container">
            <h1>Find a place to rent.</h1>
            <p>Rent from us from over more than 19'000 units.</p>

            <table>
                <tr>
                    <td><asp:Label ID="lblSessionName" runat="server" Text="Session Number:" ForeColor="Black"></asp:Label></td>
                    <td><asp:TextBox ID="tbxSessionNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnSave" runat="server" Text="Save Session" ForeColor="Black" OnClick="btnSave_Click" /></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
