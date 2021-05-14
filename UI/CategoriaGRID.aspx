<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoriaGRID.aspx.cs" Inherits="lojavirtualvb.UI.CategoriaGRID" %>

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
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            Id</p>

             <p>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            Nome</p>
        <p>
            <asp:TextBox ID="txtDescricao" runat="server" Height="16px"></asp:TextBox>
            descricao</p>
        <asp:Button ID="btnSalvar" runat="server" OnClick="Button1_Click" Text="Salvar" />
 <asp:GridView ID="gridCategoria" runat="server" 
    AutoGenerateColumns="False" 
    Height="295px" Width="1011px" OnRowDeleting="gridCategoria_RowDeleting1" OnRowEditing="gridCategoria_RowEditing" OnRowUpdating="gridCategoria_RowUpdating" OnRowCancelingEdit="gridCategoria_RowCancelingEdit">
    <Columns>
        <asp:BoundField DataField="ID" 
            HeaderText="ID" InsertVisible="True" />
        <asp:BoundField DataField="Nome" 
            HeaderText="Nome" SortExpression="Nome" />
        <asp:BoundField DataField="descricao" 
            HeaderText="descricao" SortExpression="descricao" />
         <asp:CommandField ShowDeleteButton="True" 
            ShowEditButton="True" />
    </Columns>
</asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Voltar" />
    </form>
</body>
</html>
