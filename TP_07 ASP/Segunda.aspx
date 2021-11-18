<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Segunda.aspx.cs" Inherits="_Segunda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 544px">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><br />
            <asp:TextBox ID="nombre" runat="server" Width="115px"></asp:TextBox>
            


            <asp:TextBox ID="apellido" runat="server" Width="127px"></asp:TextBox>
            
            
            
            <br /><asp:Label ID="Label2" runat="server" Text="Nombre de usuario"></asp:Label>
            <br /><br /><asp:TextBox ID="nombreUsuario" runat="server" Width="248px"></asp:TextBox>
            
            
            <br /><br /><asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <br /><asp:TextBox ID="pass" runat="server" Width="241px" style="margin-left: 0px"></asp:TextBox>
            <br />
            <br /><asp:Label ID="Label4" runat="server" Text="Repita Password"></asp:Label>
            <br /><asp:TextBox ID="repitePass" runat="server" Width="241px" style="margin-left: 0px"></asp:TextBox>
            
            <br /><br /><asp:Label ID="Label5" runat="server" Text="Fecha de nacimiento"></asp:Label>
            <br /><asp:TextBox ID="diaNac" type="number" min="1" max="31" runat="server" Width="41px" style="margin-left: 0px"></asp:TextBox>
            
            <asp:DropDownList ID="mesNac" runat="server">
                <asp:ListItem>Enero</asp:ListItem>
                <asp:ListItem>Febrero</asp:ListItem>
                <asp:ListItem>Marzo</asp:ListItem>
                <asp:ListItem>Abril</asp:ListItem>
                <asp:ListItem>Mayo</asp:ListItem>
                <asp:ListItem>Junio</asp:ListItem>
                <asp:ListItem>Julio</asp:ListItem>
                <asp:ListItem>Agosto</asp:ListItem>
                <asp:ListItem>Septiembre</asp:ListItem>
                <asp:ListItem>Agosto</asp:ListItem>
                <asp:ListItem>Noviembre</asp:ListItem>
                <asp:ListItem>Diciembre</asp:ListItem>
            </asp:DropDownList>
           
            <asp:TextBox ID="anioNac" runat="server" Width="98px" style="margin-left: 0px" type="number" min="1930" max="2021"></asp:TextBox>
            
            
            <br /><br /><asp:Label ID="Label6" runat="server" Text="Sexo"></asp:Label>
            <br /><asp:DropDownList ID="sexo" runat="server" Width="241px">
                <asp:ListItem>Femenino</asp:ListItem>
                <asp:ListItem>Masculino</asp:ListItem>
            </asp:DropDownList>
           
            
            <br /><asp:Label ID="Label7" runat="server" Text="Teléfono"></asp:Label>
            <br /><asp:TextBox ID="tel" runat="server" Width="241px" style="margin-left: 0px"></asp:TextBox>
            
            
            <br /><br /><asp:Label ID="Label8" runat="server" Text="Demuéstranos que no estes un robot"></asp:Label>
            <br /><asp:Image ImageUrl="img.jpg" runat="server" Width="249px" />
            
            
            <br /><asp:Label ID="Label9" runat="server" Text="Escribe las dos palabras"></asp:Label>
            <br /><asp:TextBox ID="robot" runat="server" Width="241px" style="margin-left: 0px"></asp:TextBox>
            
            
            <br /><br /><asp:Label ID="Label10" runat="server" Text="Ubicación"></asp:Label>
            <br /><asp:DropDownList ID="ubicacion" runat="server" Width="240px">
                <asp:ListItem>Argentina</asp:ListItem>
                <asp:ListItem>Otro</asp:ListItem>
            </asp:DropDownList>
            
            
            <br /><br /><br /><asp:CheckBox ID="aceptarCondiciones" runat="server" Text="Acepto las condiciones del servicio" />

            
            <br /><br /><asp:Button runat="server" Text="Enviar" OnClick="Unnamed2_Click"/>




            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="nombre" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="nombre"
            ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="apellido" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="apellido"
            ErrorMessage="RegularExpressionValidator" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="nombreUsuario" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="pass" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="pass" ClientValidationFunction="ValidPass">La password debe contener alguno de los carácteres !@#$%^&*+;:</asp:CustomValidator>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="repitePass" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            <asp:CompareValidator id="RequiredFieldValidator10" ControlToValidate="repitePass" ControlToCompare="pass" Type="String" ErrorMessage="Las contraseñas deben coincidir" runat="server" />
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="diaNac" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="anioNac" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="robot" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="tel" runat="server" ErrorMessage="No pueden haber campos vacíos"></asp:RequiredFieldValidator>
           
        </div>
    </form>
</body>
</html>
