<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="lojavirtualvb.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Vai para a tela de cadastro de usuario</h1>
         
            <asp:Button runat="server" ID="btnDirecionar" Text="Cadastrar Usuario" OnClick="btn1_Click"/>
        </div>
        <asp:Label ID="lblProduto" runat="server" Text="Vincule um Produto "></asp:Label>
        <p>
            <asp:Button ID="btnProduto" runat="server" Text="Cadastrar Produto" OnClick="btnProduto_Click" />
        </p>
        <asp:Label ID="lblCategoria" runat="server" Text="Vincule uma Categoria"></asp:Label>
        <p>
            <asp:Button ID="btnCategoria" runat="server" Text="Cadestre uma Categoria" OnClick="btnCategoria_Click" />
        </p>
        <asp:Label ID="lblFornecedor" runat="server" Text="Vincule um Fornecedor"></asp:Label>
        <p>
            <asp:Button ID="btnFornecedor" runat="server" Height="25px" Text="Cadestre um Fornecedor" OnClick="btnFornecedor_Click" />
        </p>
    </form>
</body>
</html>
