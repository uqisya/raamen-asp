<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testing_session.aspx.cs" Inherits="ramenAOL.View.testing_session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="userLbl" runat="server" Text="Username: "></asp:Label>
            <input id="userTxt" type="text" runat="server" placeholder="username" />
            <br />
            <asp:Label ID="passLbl" runat="server" Text="Password: "></asp:Label>
            <input id="passTxt" type="password" runat="server" placeholder="password" />
            <br />
            <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me" />
            <br />
            <asp:Button ID="loginBtn" runat="server" Text="Log In" OnClick="loginBtn_Click" />
            <br />
            <asp:Label ID="errLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
