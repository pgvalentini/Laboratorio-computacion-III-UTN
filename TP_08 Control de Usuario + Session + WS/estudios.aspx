<%@ Page Language="C#" AutoEventWireup="true" CodeFile="estudios.aspx.cs" Inherits="estudios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Antecedentes Educacionales</h1>
            <asp:Label ID="Label5" runat="server" Text="Nivel de estudio: "></asp:Label>
            <asp:TextBox ID="NivelEstudio" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Titulo: "></asp:Label>
            <asp:TextBox ID="Titulo" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Establecimiento: "></asp:Label>
            <asp:TextBox ID="Establecimiento" runat="server"></asp:TextBox><br />
            <asp:Button ID="Submit" runat="server" Text="Enviar" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
