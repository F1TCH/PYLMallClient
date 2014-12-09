<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="EWDTApp.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="profilePage">
        <div class="containerProfile">
            <div>
                <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xs-offset-0 col-sm-offset-0 col-md-offset-3 col-lg-offset-3 toppad">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <h3 class="panel-title">&nbsp;</h3>
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-3 col-lg-1">
                                    <img alt="User Pic" src="https://lh5.googleusercontent.com/-b0-k99FZlyE/AAAAAAAAAAI/AAAAAAAAAAA/eu7opA4byxI/photo.jpg?sz=100" class="img-circle" />
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="profileTable">
                                    <table class="table table-bordered table-striped">

                                        <tr>
                                            <td class="auto-style1" style="color: #000000">Name:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblName" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1" style="color: #000000">NRIC:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblNRIC" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1" style="color: #000000">Date Of Birth:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblDOB" runat="server"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1" style="color: #000000">Email:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1" style="color: #000000">Handphone:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblHandphone" runat="server"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1" style="color: #000000">Telephone:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblTele" runat="server"></asp:Label>
                                                <br />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1" style="color: #000000">Gender:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblGender" runat="server"></asp:Label>
                                                &nbsp;</td>

                                        </tr>
                                        <tr>
                                            <td class="auto-style1" style="color: #000000">Address:</td>
                                            <td style="color: #000000">
                                                <asp:Label ID="lblAddress" runat="server"></asp:Label></td>
                                        </tr>
                                    </table>
                                </div>
                                <asp:Button ID="btnCreateprofile" runat="server" CssClass="btn btn-success btn-block" Text="Create Profile" />
                                <asp:Button ID="btnEditprofile" runat="server" CssClass="btn btn-warning btn-block" Text="Edit Profile" />
                                <asp:Button ID="btnPassword" runat="server" CssClass="btn btn-info btn-block" Text="Change Password" />
                                <br />
                                <asp:Button ID="btnDeleteprofile1" runat="server" CssClass="btn btn-danger btn-block" Text="Delete Profile" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
