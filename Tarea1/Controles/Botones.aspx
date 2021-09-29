<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Botones.aspx.cs" Inherits="Tarea1.Controles.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <br/>
        <br/>
        <asp:Button ID="btnCrear" runat="server" Text="Crear"/>
        <br/>
        <br/>
        <asp:Button ID="btnRecuperar" runat="server" Text="Recuperar"/>
       <br/>
        <br/>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar"/>
        <br/>
        <br/>
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar"/>
        <br/>
        <br/>
        </div>
    </form>
</body>
</html>
