<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Parcial_Practico.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="assets/css/log.css" rel="stylesheet" />
</head>

    <body>
        <div class="login">
	<h1>Login</h1>
            <form id="form1" runat="server">
                <asp:TextBox ID="TextBox1" placeholder="Usuario"  runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox2" placeholder="Contraseña" runat="server"></asp:TextBox>
                <button type="submit" class="btn btn-primary btn-block btn-large">Entrar</button>
                <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#99FF33" >Crear cuenta</asp:LinkButton>
            </form>

            
</div>

  
    </body>

  
  
</html>
