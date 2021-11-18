<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppCliente.aspx.cs" Inherits="AppCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Convertir km a metro</h1><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Km"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Convertir" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label2" runat="server" Text="Clic en convertir para ver el resultado"></asp:Label>
        </div>
    </form>
</body>
</html>
