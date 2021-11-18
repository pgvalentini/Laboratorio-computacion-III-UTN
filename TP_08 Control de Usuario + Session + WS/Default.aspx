<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>
<%@ Register Src="~/TextBoxCuit.ascx" TagPrefix="uc1" TagName="TextBoxCuit" %>
<%@ Register Src="~/TextBoxMayorEdad.ascx" TagPrefix="uc1" TagName="TextBoxMayorEdad" %>
<%@ Register Src="~/RadioButtonSex.ascx" TagPrefix="uc1" TagName="RadioButtonSex" %>
<%@ Register Src="~/ComboPaises.ascx" TagPrefix="uc1" TagName="ComboPaises" %>
<%@ Register Src="~/RangoHijosMenores.ascx" TagPrefix="uc1" TagName="RangoHijosMenores" %>







<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
            <uc1:TextBoxNoEmpty runat="server" ID="TextBoxNoEmpty" /><br />
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <uc1:TextBoxNoEmpty runat="server" ID="TextBoxNoEmpty1" /><br />
            <asp:Label ID="Label3" runat="server" Text="N de CUIT"></asp:Label>
            <uc1:TextBoxCuit runat="server" id="TextBoxCuit" />
            <br /><asp:Label ID="Label4" runat="server" Text="Edad del solicitante"></asp:Label>
            <uc1:TextBoxMayorEdad runat="server" id="TextBoxMayorEdad" />
            <br /><asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label>
            <uc1:RadioButtonSex runat="server" ID="RadioButtonSex" />
            <br /><asp:Label ID="Label6" runat="server" Text="Nacionalidad"></asp:Label>
            <uc1:ComboPaises runat="server" ID="ComboPaises" />
            <br /><asp:Label ID="Label7" runat="server" Text="N de hijos menores de edad"></asp:Label>
            <uc1:RangoHijosMenores runat="server" ID="RangoHijosMenores" />
            <br /><asp:Button ID="Button1" runat="server" Text="Validar" />
        </div>
    </form>
</body>
</html>
