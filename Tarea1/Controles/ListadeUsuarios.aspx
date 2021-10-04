<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadeUsuarios.aspx.cs" Inherits="Tarea1.Controles.ListadeUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1>Lista de Usuarios</h1>
        </div>
        <asp:GridView ID="IdgdUsuarios"
            runat="server" 
            AutoGenerateColumns="False" 
            Width="825px"
            BackColor="White"   
            CellPadding="4" 
            GridLines="None"
            EmptyDataText="No se encontraron registros disponibles"           
            PageSizee="10"
            ForeColor="#333333"
            OnRowCommand="IdgdUsuarios_RowCommand"
            DataKeyNames="PK_USER"
            OnSelectedIndexChanged="IdgdUsuarios_SelectedIndexChanged">


        <columns>
           
            <asp:BoundField DataField="PK_USER" SortExpression="PK_USER" HeaderText="Id">
                </asp:BoundField>
            <asp:BoundField DataField ="FL_NOMBRE" HeaderText="Nombre">
                </asp:BoundField>
            <asp:BoundField DataField ="FL_APELLIDO_P" HeaderText="Apellido">
                </asp:BoundField>
            <asp:BoundField DataField ="FL_EMAIL" HeaderText="Email">
                </asp:BoundField>
            <asp:ButtonField ButtonType="Button" runat="server" HeaderText="Borrar" Text="Borrar registro"  HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left"/>

              
        </columns>
      
        </asp:GridView>
        <p>
            <asp:TextBox ID="IdNombre"  runat="server" Height="140px" Width="364px" Visible="false" ></asp:TextBox>
            <asp:TextBox ID="IdEmail"  runat="server" Height="140px" Width="364px"  Visible="false"></asp:TextBox>
            <asp:TextBox ID="IdApp"  runat="server" Height="140px" Width="364px"  Visible="false"></asp:TextBox>
        </p>
    </form>
</body>
</html>
