<%@ Page Title="" Language="C#" MasterPageFile="~/EWDTMain.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="EWDTApp.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content_body" runat="server">
    <div class="profilePage">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xs-offset-0 col-sm-offset-0 col-md-offset-3 col-lg-offset-3 toppad">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <h3 class="panel-title">&nbsp;</h3>
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-3 col-lg-3 ">
                                    <img alt="User Pic" src="https://lh5.googleusercontent.com/-b0-k99FZlyE/AAAAAAAAAAI/AAAAAAAAAAA/eu7opA4byxI/photo.jpg?sz=100" class="img-circle" />
                                </div>
                                <div class=" col-md-9 col-lg-9 ">
                                    <table class="table table-user-information">
                                        <tbody>
                                            <tr>
                                                <td class="auto-style1">Name:</td>
                                                <td>
                                                    <asp:Label ID="lblName" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">NRIC:</td>
                                                <td>
                                                    <asp:Label ID="lblNRIC" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Date Of Birth:</td>
                                                <td>
                                                    <asp:Label ID="lblDOB" runat="server"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Email:</td>
                                                <td>
                                                    <asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Handphone:</td>
                                                <td>
                                                    <asp:Label ID="lblHandphone" runat="server"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Telephone:</td>
                                                <td>
                                                    <asp:Label ID="lblTele" runat="server"></asp:Label>
                                                    <br>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Gender:</td>
                                                <td>
                                                    <asp:Label ID="lblGender" runat="server"></asp:Label>
                                                    &nbsp;</td>

                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Address:</td>
                                                <td>
                                                    <asp:Label ID="lblAddress" runat="server"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Qualification</td>
                                                <td>
                                                    <asp:Label ID="lblQualification" runat="server"></asp:Label>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Work Experience</td>
                                                <td>
                                                    <asp:Label ID="lblWorkExperience" runat="server"></asp:Label>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Unique Key</td>
                                                <td>
                                                    <asp:Label ID="lblUniquekey" runat="server"></asp:Label>
                                            </tr>
                                            <tr>
                                                <td class="auto-style1">Additional Info</td>
                                                <td>
                                                    <asp:Label ID="lblAdditionalInfo" runat="server"></asp:Label>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <asp:Button ID="btnCreateprofile" runat="server" class="btn btn-success btn-block" Text="Create Profile" />
                                    <asp:Button ID="btnEditprofile" runat="server" class="btn btn-warning btn-block" Text="Edit Profile"  />
                                    <asp:Button ID="btnPassword" runat="server" class="btn btn-info btn-block" Text="Change Password" />
                                    <br />
                                    <asp:Button ID="btnDeleteprofile1" runat="server" class="btn btn-danger btn-block" Text="Delete Profile" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
