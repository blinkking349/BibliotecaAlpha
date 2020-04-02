<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoAutor.aspx.cs" Inherits="PresentacionWeb.NuevoAutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <h2>Ingreso Autor</h2>
    <table class="nav-justified" style="width: 79%; height: 196px; margin-bottom: 0px;">
        <tr>
            <td>
                <asp:Label ID="lblNombre" runat="server" Text="Ingrese Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblApellido" runat="server" Text="Ingrese Apellido"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="Ingrese Fecha Nacimiento"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFechaNacimiento" runat="server">dd/mm/aaaa</asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPaises" runat="server" Width="141px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" Width="127px" OnClick="btnConfirmar_Click" />
            </td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />

</asp:Content>
