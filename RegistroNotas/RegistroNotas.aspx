<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroNotas.aspx.cs" Inherits="RegistroNotas.RegistroNotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">
            <asp:Label ID="lblAlumno" runat="server" Text="Alumno"></asp:Label>
            <br />
            
            <asp:DropDownList ID="ddlAlumno" runat="server" DataSourceID="Alumnos" DataTextField="Nombre" DataValueField="Nombre">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Alumnos" runat="server" ConnectionString="<%$ ConnectionStrings:RegistroNotas05LConnectionString %>" SelectCommand="SELECT [Nombre] FROM [Alumno]"></asp:SqlDataSource>
                        
            <br />
            <asp:Label ID="lblMateria" runat="server" Text="Materia"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlMaterias" runat="server" DataSourceID="Materias" DataTextField="Nombre" DataValueField="Nombre">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Materias" runat="server" ConnectionString="<%$ ConnectionStrings:RegistroNotas05LConnectionString %>" SelectCommand="SELECT [Nombre] FROM [Materia]"></asp:SqlDataSource>
            

            <br />
            <asp:Label ID="lblNota" runat="server" Text="Nota"></asp:Label>
            <br />
            <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
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
