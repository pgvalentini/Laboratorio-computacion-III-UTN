<%@ Page Language="C#" AutoEventWireup="true" CodeFile="datospersonales.aspx.cs" Inherits="datospersonales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Datos personales</h1>
            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="Nombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Apellido: "></asp:Label>
            <asp:TextBox ID="Apellido" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="DNI: "></asp:Label>
            <asp:TextBox ID="DNI" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Domicilio: "></asp:Label>
            <asp:TextBox ID="Domicilio" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Nacionalidad: "></asp:Label>
            <asp:TextBox ID="Nacionalidad" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Sexo: "></asp:Label>
            <asp:TextBox ID="Sexo" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Fecha Nacimiento: "></asp:Label>
            <asp:TextBox ID="FechaNacimiento" runat="server"></asp:TextBox><br />
            <asp:Button ID="Submit" runat="server" Text="Enviar" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
