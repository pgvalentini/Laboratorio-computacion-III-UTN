<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Primera.aspx.cs" Inherits="_Primera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>HTML</h1><br /><br />
    <form id="form1">
        <div>
            <table border="1">
                <tr>
                    <td>

                    </td>
                    <td>
                        <b>Componentes</b>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="cajaTexto">Caja de texto</label>
                    </td>
                    <td>
                        <input type="text" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="combo">Combo</label>
                    </td>
                    <td>
                        <select>
                            <option>1</option>
                            <option>2</option>  
                            <option>3</option>
                            <option>4</option>                            
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="imagen">Imagen</label>
                    </td>
                    <td>
                        <img src="https://www.cocinayvino.com/wp-content/uploads/2017/01/comidarapida.jpg"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="checkbox">Checkbox</label>
                    </td>
                    <td>
                        <input type="checkbox" id="si" name="si"/>
                        <label for="si">SI</label>
                        <input type="checkbox" id="no" name="no"/>
                        <label for="no">NO</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="vinculo">Hipervínculo</label>
                    </td>
                    <td>
                        <a href="google.com">Google</a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="radio">Radio Button</label>
                    </td>
                    <td>
                        <input type="radio" id="radioBA" name="radioB" value="alta"/>
                        <label for="radioB">Alta</label>
                        <input type="radio" id="radioBB" name="radioB" value="media"/>
                        <label for="radioB">Media</label>
                        <input type="radio" id="radioBC" name="radioB" value="baja"/>
                        <label for="radioB">Baja</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="oculto">Campo oculto</label>
                    </td>
                    <td>
                        <input type="hidden"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="boton">Button</label>
                    </td>
                    <td>
                        <button>Button</button>
                    </td>
                </tr>
            </table>
        </div>
    </form><br /><br />
    <h1>ASP.Net</h1><br /><br />
    <form id="formASP" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td>

                    </td>
                    <td>
                        <b>Componentes</b>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="txt1" id="lb1" runat="server">Caja de texto</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="combo" id="Label1" runat="server">Combo</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="combo" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="imagen" id="Label2" runat="server">Imagen</asp:Label>
                    </td>
                    <td>
                        <asp:Image id="imagen" height="54" width="54" runat="server" src="https://sevilla.abc.es/gurme/wp-content/uploads/sites/24/2012/01/comida-rapida-casera.jpg"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="checkbox" id="Label3" runat="server">Checkbox</asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="checkBox" runat="server">
                            <asp:ListItem>SI</asp:ListItem>
                            <asp:ListItem>NO</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="vinculo" id="Label4" runat="server">Hipervínculo</asp:Label>
                    </td>
                    <td>
                        <asp:HyperLink ID="link" href="google.com" runat="server">Google</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="radio" id="Label5" runat="server">Radio Button</asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="radio" runat="server">
                            <asp:ListItem>Alta</asp:ListItem>
                            <asp:ListItem>Media</asp:ListItem>
                            <asp:ListItem>Baja</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="oculto" id="Label6" runat="server">Campo oculto</asp:Label>
                    </td>
                    <td>
                        <asp:HiddenField ID="oculto" runat="server" Value="Valor oculto"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label for="boton" id="Label7" runat="server">Button</asp:Label>
                    </td>
                    <td>
                        <asp:Button runat="server" Text="Button" OnClick="Unnamed3_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form><br /><br />
    <table border="1">
        <tr>
            <td>
                <asp:Label id="Label13" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label14" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label15" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label16" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label17" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label18" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label19" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label20" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label id="Label21" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</body>
</html>
