<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/StaffNavbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ramenAOL.View.User.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
    <h1>ini home page</h1>
    <h2>bisa diakses oleh staff, dan admin</h2>

    <asp:Panel ID="adminContentPlaceHolder" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="masuk admin cuy"></asp:Label>
            <asp:Label ID="helloTxt" runat="server" Text=""></asp:Label>
        </div>
        <div id="listStaffContainer" runat="server">
            <h1>List Staff</h1>
            <asp:ListBox ID="listStaff" runat="server"></asp:ListBox>
        </div>
    </asp:Panel>

    <asp:Panel ID="staffContentPlaceHolder" runat="server">
        <h1>ini staff</h1>
    </asp:Panel>


</asp:Content>
