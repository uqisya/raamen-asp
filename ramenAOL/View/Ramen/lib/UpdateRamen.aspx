<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="ramenAOL.View.Ramen.UpdateRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Ramen Name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblBroth" runat="server" Text="Broth Type: "></asp:Label>
            <asp:TextBox ID="txtBroth" runat="server"></asp:TextBox>
            <br />
            
            <asp:Label ID="lblPrice" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
