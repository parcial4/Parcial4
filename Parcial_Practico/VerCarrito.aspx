<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="VerCarrito.aspx.cs" Inherits="Parcial_Practico.VerCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView2" runat="server" EmptyDataText="No hay nada en su carrito de compras." AutoGenerateColumns="False" DataSourceID="odsMostrarCarrito" OnRowCommand="GridView2_RowCommand" OnRowDataBound="GridView2_RowDataBound"></asp:GridView>
    <asp:ObjectDataSource ID="odsMostrarCarrito" runat="server" SelectMethod="CapturarProducto" TypeName="Parcial_Practico.CarroDeCompras"></asp:ObjectDataSource>
</asp:Content>
