<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mediator.aspx.cs" Inherits="FrontMediator.Mediator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 65px;
        }
        .auto-style3 {
            width: 309px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:DropDownList ID="DLUsuario" runat="server" DataSourceID="BDDUsuario" DataTextField="cod_usuario" DataValueField="cod_usuario" Height="36px" TabIndex="1" Width="116px">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="BDDUsuario" runat="server" ConnectionString="<%$ ConnectionStrings:todolistConnectionString %>" SelectCommand="SELECT * FROM [usuario]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="Label2" runat="server" Text="Mensaje:"></asp:Label>
                            </td>
                            <td class="auto-style3">
                                <asp:TextBox ID="TxtMensaje" runat="server" Height="36px" Width="270px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="BtnEnviar" runat="server" OnClick="BtnEnviar_Click" Text="Enviar" Width="99px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GV1" runat="server" AutoGenerateColumns="False" DataKeyNames="COD_MENSAJE" DataSourceID="BDDMediator">
                        <Columns>
                            <asp:BoundField DataField="COD_MENSAJE" HeaderText="COD_MENSAJE" InsertVisible="False" ReadOnly="True" SortExpression="COD_MENSAJE" />
                            <asp:BoundField DataField="USUARIO_MENSAJE" HeaderText="USUARIO_MENSAJE" SortExpression="USUARIO_MENSAJE" />
                            <asp:BoundField DataField="MENSAJE" HeaderText="MENSAJE" SortExpression="MENSAJE" />
                            <asp:BoundField DataField="TIPO_MENSAJE" HeaderText="TIPO_MENSAJE" SortExpression="TIPO_MENSAJE" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="BDDMediator" runat="server" ConnectionString="<%$ ConnectionStrings:todolistConnectionString %>" SelectCommand="SELECT * FROM [MENSAJE]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
