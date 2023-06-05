<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ramenAOL.View.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="masuk admin cuy"></asp:Label>
            <asp:Label ID="helloTxt" runat="server" Text=""></asp:Label>
        </div>
        <div id="listStaffContainer" runat="server">
            <h1>List Staff</h1>
            <asp:ListBox ID="listStaff" runat="server"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="logOut" runat="server" Text="Log Out" OnClick="logOut_Click" />
        </div>
    </form>
</body>
</html>
