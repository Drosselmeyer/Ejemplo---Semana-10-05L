<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroMaterias.aspx.cs" Inherits="RegistroNotas.RegistroMaterias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDocente" runat="server" Text="Docente"></asp:Label>
            <br />
            <asp:TextBox ID="txtDocente" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
        <div class="datos">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
            <asp:Table ID="tblDatos" runat="server">
            </asp:Table>
        </div>
    </form>
</body>
</html>
