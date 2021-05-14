<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FornecedorBLL.aspx.cs" Inherits="lojavirtualvb.UI.FornecedorBLL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            Nome</p>
        <p>
            <asp:TextBox ID="txtCNPJ" runat="server" Height="16px"></asp:TextBox>
            CNPJ</p>
                <p>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            email</p>
            <p>

                  
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            Telefone </p>

                 <p>
        <asp:TextBox ID="txtRepresentante" runat="server"></asp:TextBox>
        Nome Representante </p>
         
            <p>
            <asp:TextBox ID="txtTelefoneRepresentante" runat="server"></asp:TextBox>
            Telefone Representante</p>
    
  
        <asp:Button ID="btnSalvar" runat="server" OnClick="Button1_Click" Text="Salvar" />
 <asp:GridView ID="gridFornecedor" runat="server" 
    AutoGenerateColumns="False" 
    Height="295px" Width="1011px" OnRowDeleting="gridFornecedor_RowDeleting1" OnRowEditing="gridFornecedor_RowEditing" OnRowUpdating="gridFornecedor_RowUpdating" OnRowCancelingEdit="gridFornecedor_RowCancelingEdit">
    <Columns>
        <asp:BoundField DataField="ID" 
            HeaderText="ID" InsertVisible="True" />
        <asp:BoundField DataField="Nome" 
            HeaderText="Nome" SortExpression="Nome" />
        <asp:BoundField DataField="CNPJ" 
            HeaderText="CNPJ" SortExpression="CNPJ" />
        <asp:BoundField DataField="Email" 
            HeaderText="Email" SortExpression="Email" />

        <asp:BoundField DataField="Telefone" 
            HeaderText="Telefone" SortExpression="Telefone" />

        <asp:BoundField DataField="NomeRepresentante" 
            HeaderText="NomeRepresentante" SortExpression="NomeRepresentante" />

         <asp:BoundField DataField="TelefoneRepresentante" 
            HeaderText="TelefoneRepresentante" SortExpression="TelefoneRepresentante" />

         <asp:CommandField ShowDeleteButton="True" 
            ShowEditButton="True" />
    </Columns>
</asp:GridView>
        </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Voltar" />
    </form>
</body>
</html>
