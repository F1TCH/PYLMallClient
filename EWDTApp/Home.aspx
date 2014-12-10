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

            <iframe src="https://www.google.com/maps/embed?pb=!1m10!1m8!1m3!1d15954.849005629592!2d103.93181229999999!3d1.3491560999999999!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2ssg!4v1418241342945" width="600" height="450" frameborder="0" style="border:0"></iframe>
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
