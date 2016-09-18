<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qstringinicio.aspx.cs" Inherits="Tarea._2.qstringincio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="qstringrecibe.aspx" method="get">
    <div>
    
        <asp:TextBox ID="textNombre" runat="server"></asp:TextBox>
        <asp:Button ID="btnEnviar" runat="server" Text="enviar" />
    
    </div>
        <p>
            <asp:TextBox ID="textApellido" runat="server"></asp:TextBox>
        </p>
    </form>
    <p>
        formulario para enviar un dato por medio de Querystring</p>
</body>
</html>
