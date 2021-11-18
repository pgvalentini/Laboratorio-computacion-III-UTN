<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxCuit.ascx.cs" Inherits="TextBoxCuit" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="ValidarCuit" ControlToValidate="TextBox1" ErrorMessage="CustomValidator"></asp:CustomValidator>