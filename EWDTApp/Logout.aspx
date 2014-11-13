<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="EWDTApp.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="container">
            <div class="form-signin">
                <h2 class="form-signin-heading">Account Signoff...</h2>
                Is this goodbye?
          <br />
                Are you really sure that you want to logout from the awesome page? 
                <br />
                <br />
                <asp:Button ID="btnBack" runat="server" CssClass="btn btn-info btn-block" Text="Logout" OnClick="btnBack_Click" />
                <br />
                <asp:Button ID="btnlogout" runat="server" CssClass="btn btn-default btn-block" Text="Back" OnClick="btnlogout_Click" />
                <br />
            </div>
    </div>
</asp:Content>
