using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DTO;

namespace lojavirtualvb.UI
{
    public partial class ProdutoGrid : System.Web.UI.Page
    {
        ProdutoDTO objetoDTO = new ProdutoDTO();
        ProdutoBLL objetobll = new ProdutoBLL();

        public void carregarGrid()
        {
            gridProduto.DataSource = objetobll.Selecionar();
            gridProduto.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carregarGrid();
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            objetoDTO.Nome = txtNome.Text;
            objetoDTO.Valor = txtValor.Text;
            objetoDTO.Descricao = txtDescricao.Text;
            objetoDTO.FornecedorId = txForncedorId.Text;
            objetoDTO.CateoriaId = txtCategoriaId.Text;
            objetoDTO.QuantidadeEstoque = txtQuantidade.Text;
            objetoDTO.ClienteId = int.Parse(txtClientes_id.Text);
            objetoDTO.Fornecedores_Id = int.Parse(txtFornecedor_id.Text) ;
            objetoDTO.Categorias_id = int.Parse(txtCategorias_id.Text);

            objetobll.Criar(objetoDTO);
            carregarGrid();
        }

        protected void gridProduto_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.Values["ID"]);
            objetobll.Delete(objetoDTO);
            carregarGrid();
        }

        protected void gridProduto_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridProduto.EditIndex = e.NewEditIndex;
            carregarGrid();
        }

        protected void gridProduto_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.NewValues[0]);
            objetoDTO.Nome = e.NewValues[1].ToString();
            objetoDTO.Valor = e.NewValues[2].ToString();
            objetoDTO.Descricao = e.NewValues[3].ToString();
            objetoDTO.FornecedorId = e.NewValues[4].ToString();
            objetoDTO.CateoriaId = e.NewValues[5].ToString();
            objetoDTO.QuantidadeEstoque = e.NewValues[6].ToString();
            objetoDTO.ClienteId = int.Parse(e.NewValues[7].ToString());
            objetoDTO.Fornecedores_Id = int.Parse(e.NewValues[8].ToString());
            objetoDTO.Categorias_id = int.Parse(e.NewValues[9].ToString());

            objetobll.Alterar(objetoDTO);
            gridProduto.EditIndex = -1;
            carregarGrid();
        }

        protected void gridProduto_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridProduto.EditIndex = -1;
            carregarGrid();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}