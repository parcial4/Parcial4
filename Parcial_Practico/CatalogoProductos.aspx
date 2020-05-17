<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="Parcial_Practico.CatalogoProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="odsCatalogoProductos">

    </asp:GridView>
<asp:ObjectDataSource ID="odsCatalogoProductos" runat="server"></asp:ObjectDataSource>
</asp:Content>
