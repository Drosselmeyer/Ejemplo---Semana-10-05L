﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAlumno.aspx.cs" Inherits="RegistroNotas.RegistroAlumno" %>

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
            <asp:Label ID="lblGrado" runat="server" Text="Grado"></asp:Label>
            <br />
            <asp:TextBox ID="txtGrado" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSeccion" runat="server" Text="Seccion"></asp:Label>
            <br />
            <asp:TextBox ID="txtSeccion" runat="server"></asp:TextBox>
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
