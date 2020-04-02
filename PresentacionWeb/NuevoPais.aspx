<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoPais.aspx.cs" Inherits="PresentacionWeb.NuevoPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <h2>Ingreso Nuevo Pais</h2>
    <table style="width: 57%; height: 129px;" class="table table-dark">
        <tr>
            <td style="width: 170px">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre del Pais"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="171px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Campo Obligatorio" ForeColor="#FF3300" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 170px">
                <asp:Button ID="btnConfirmar" CssClass="btn btn-success" runat="server" Text="Confirmar" Width="147px" OnClick="btnConfirmar_Click" />
            </td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />

  
</asp:Content>
