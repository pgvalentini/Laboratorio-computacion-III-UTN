<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RangoHijosMenores.ascx.cs" Inherits="RangoHijosMenores" %>

<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" Type="Integer" MinimumValue="0" MaximumValue="18" ControlToValidate="TextBox1" ErrorMessage="RangeValidator"></asp:RangeValidator>