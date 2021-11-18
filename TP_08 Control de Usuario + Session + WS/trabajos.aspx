<%@ Page Language="C#" AutoEventWireup="true" CodeFile="trabajos.aspx.cs" Inherits="trabajos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Experiencia Laboral</h1>
            <asp:Label ID="Label5" runat="server" Text="Periodo de Ocupación: "></asp:Label>
            <asp:TextBox ID="PeriodoOcupacion" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Lugar de Trabajo: "></asp:Label>
            <asp:TextBox ID="LugarTrabajo" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Tarea desempeñada: "></asp:Label>
            <asp:TextBox ID="TareaDesempeniada" runat="server"></asp:TextBox><br />
            <asp:Button ID="Submit" runat="server" Text="Enviar" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
