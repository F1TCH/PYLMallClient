<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="DeleteProfilePage.aspx.cs" Inherits="EWDTApp.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Are you Sure??" Font-Size="X-Large"></asp:Label>
    <br />
    <asp:Label ID="lblText" runat="server" Text="Deleting this will result all data lost!!!!!!"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnDelete" runat="server" Text="Delete Profile" ForeColor="Black" OnClick="btnDelete_Click" />
    <asp:Button ID="btnBack" runat="server" Text="Back to safety" ForeColor="Black" OnClick="btnBack_Click" />
</asp:Content>
