<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session.aspx.cs" Inherits="Tarea._2.session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <table style="width:100%;">
            <tr>
                <td>
                    Producto</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
                    <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                        Text="Agregar" />
                </td>
            </tr>
        </table>
 
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" 
        NavigateUrl="~/resultadoSes.aspx">resultado</asp:HyperLink>
    
  
    </form>
</body>
</html>
