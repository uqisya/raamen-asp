<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/StaffNavbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ramenAOL.View.User.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
<%--    <h1>ini home page</h1>
    <h2>bisa diakses oleh staff, dan admin</h2>--%>

    <div class="header_top">
        <p class="header_hello">
            Hi,
            <asp:Label CssClass="lblUsername" ID="lblUsername" runat="server" Text=""></asp:Label>
            Selamat Datang.
        </p>
    </div>

    <asp:Panel ID="adminContentPlaceHolder" runat="server">
        <div id="listStaffContainer" runat="server">
            <br />
            <h1>List Staff</h1>
            <asp:ListBox ID="listStaff" runat="server"></asp:ListBox>
        </div>
    </asp:Panel>

    <asp:Panel ID="staffContentPlaceHolder" runat="server">
        <h1>ini staff</h1>
    </asp:Panel>


</asp:Content>
