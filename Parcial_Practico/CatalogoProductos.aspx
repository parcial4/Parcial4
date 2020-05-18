<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="Parcial_Practico.CatalogoProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="odsCatalogoProductos" AutoGenerateColumns="False" class="table-wrapper">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID"/>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
            <asp:BoundField DataField="Nombre_Producto" HeaderText="Nombre Producto" SortExpression="Nombre_Producto" />
            <asp:BoundField DataField="id_Categoria" HeaderText="Categoria" SortExpression="id_Categoria" />
            <asp:BoundField DataField="Precio_unitario" HeaderText="Precio Unitario" SortExpression="Precio_unitario" />
            <asp:BoundField DataField="Detalles" HeaderText="Detalles de Producto" SortExpression="Detalles" />
            <asp:TemplateField HeaderText="Opciones">
                <ItemTemplate>
                    <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" CommandArgument='<%#Eval("ID")%>' runat="server" Text="Agregar" class="button small"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>
    </div>
    
    <asp:ObjectDataSource ID="odsCatalogoProductos" runat="server" SelectMethod="MostrarTodosProductos" TypeName="Parcial_Practico.ProductosBLL"></asp:ObjectDataSource>
</asp:Content>
