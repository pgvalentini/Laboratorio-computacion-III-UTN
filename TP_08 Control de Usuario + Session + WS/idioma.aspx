<%@ Page Language="C#" AutoEventWireup="true" CodeFile="idioma.aspx.cs" Inherits="idioma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Idiomas</h1>
            <asp:Label ID="Label6" runat="server" Text="Idioma: "></asp:Label>
            <asp:TextBox ID="Idioma" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Nivel de Conocimiento: "></asp:Label>
            <asp:TextBox ID="NivelConocimiento" runat="server"></asp:TextBox><br />
            <asp:Button ID="Submit" runat="server" Text="Enviar" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
