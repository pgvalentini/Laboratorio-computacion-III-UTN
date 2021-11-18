<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxMayorEdad.ascx.cs" Inherits="TextBoxMayorEdad" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" Type="Integer" MinimumValue="18" MaximumValue="150" ControlToValidate="TextBox1" ErrorMessage="RangeValidator"></asp:RangeValidator>