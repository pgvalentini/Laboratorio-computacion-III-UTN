<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TextBoxNoEmpty.ascx.cs" Inherits="WebUserControl" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>