<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProdutoGrid.aspx.cs" Inherits="lojavirtualvb.UI.ProdutoGrid" %>

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
            nome</p>
        <p>
            <asp:TextBox ID="txtValor" runat="server" Height="16px"></asp:TextBox>
            Valor</p>
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        Descrição<p>
            <asp:TextBox ID="txForncedorId" runat="server"></asp:TextBox>
            FornecedorId</p>
        <p>
            <asp:TextBox ID="txtCategoriaId" runat="server"></asp:TextBox>
            CategoriaId</p>
        <p>
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
            Quantidade no estoque</p>

             <p>
            <asp:TextBox ID="txtClientes_id" runat="server"></asp:TextBox>
            Clientes id</p>

               <p>
             <asp:TextBox ID="txtFornecedor_id" runat="server"></asp:TextBox>
            Fornecedor_id</p>

                  <p>
             <asp:TextBox ID="txtCategorias_id" runat="server"></asp:TextBox>
            Categorias_id</p>

        <asp:Button ID="btnSalvar" runat="server" OnClick="Button1_Click" Text="Salvar" />
 <asp:GridView ID="gridProduto" runat="server" 
    AutoGenerateColumns="False" 
    Height="295px" Width="1011px" OnRowDeleting="gridProduto_RowDeleting1" OnRowEditing="gridProduto_RowEditing" OnRowUpdating="gridProduto_RowUpdating" OnRowCancelingEdit="gridProduto_RowCancelingEdit">
    <Columns>
    <asp:BoundField DataField="ID" 
            HeaderText="ID" InsertVisible="True" />

        <asp:BoundField DataField="Nome" 
            HeaderText="Nome" SortExpression="Nome" />

        <asp:BoundField DataField="Valor" 
            HeaderText="Valor" SortExpression="Valor" />

        <asp:BoundField DataField="Descricao" 
            HeaderText="Descricao" SortExpression="Descricao" />

        <asp:BoundField DataField="FornecedoId" 
            HeaderText="FornecedoId" SortExpression="FornecedoId" />

         <asp:BoundField DataField="CategoriaId" 
            HeaderText="CategoriaId" SortExpression="CategoriaId" />

              <asp:BoundField DataField="QuantidadeEstoque" 
            HeaderText="QuantidadeEstoque" SortExpression="QuantidadeEstoque" />

              <asp:BoundField DataField="Clientes_id" 
            HeaderText="Clientes_id" SortExpression="Clientes_id" />

              <asp:BoundField DataField="Fornecedores_id" 
            HeaderText="Fornecedores_id" SortExpression="Fornecedores_id" />

              <asp:BoundField DataField="categoria_id" 
            HeaderText="categoria_id" SortExpression="categoria_id" />

         <asp:CommandField ShowDeleteButton="True" 
            ShowEditButton="True" />
    </Columns>
</asp:GridView>
        </div>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Voltar" />
    </form>
</body>
</html>
