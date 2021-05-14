<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteGRID.aspx.cs" Inherits="lojavirtualvb.UI.ClienteGRID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <p>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            nome</p>
        <p>
            <asp:TextBox ID="txtCPF" runat="server" Height="16px"></asp:TextBox>
            cpf</p>
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        endereco<p id="btnSalvar">
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            telefone</p>
        <p>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            email</p>
        <p>
            <asp:TextBox ID="txtSenha" runat="server" OnTextChanged="txtSenha_TextChanged"></asp:TextBox>
            senha</p>
        <asp:Button ID="btnSalvar" runat="server" OnClick="Button1_Click" Text="Salvar" />
 <asp:GridView ID="gridCliente" runat="server" 
    AutoGenerateColumns="False" 
    Height="295px" Width="1011px" OnRowDeleting="gridCliente_RowDeleting1" OnRowEditing="gridCliente_RowEditing" OnRowUpdating="gridCliente_RowUpdating" OnRowCancelingEdit="gridCliente_RowCancelingEdit">
    <Columns>
        <asp:BoundField DataField="ID" 
            HeaderText="ID" InsertVisible="True" />
        <asp:BoundField DataField="Nome" 
            HeaderText="Nome" SortExpression="Nome" />
        <asp:BoundField DataField="CPF" 
            HeaderText="CPF" SortExpression="CPF" />
        <asp:BoundField DataField="Endereco" 
            HeaderText="Endereco" SortExpression="Endereco" />
        <asp:BoundField DataField="Telefone" 
            HeaderText="Telefone" SortExpression="Telefone" />
         <asp:BoundField DataField="Email" 
            HeaderText="Email" SortExpression="Email" />
         <asp:CommandField ShowDeleteButton="True" 
            ShowEditButton="True" />
    </Columns>
</asp:GridView>
          <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Voltar" />
        </form>
</body>
</html>
