using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace lojavirtualvb.UI
{
    public partial class CategoriaGRID : System.Web.UI.Page
    {

        CategoriaDTO objetoDTO = new CategoriaDTO();
        CategoriaBLL objetobll = new CategoriaBLL();

        public void carregarGrid()
        {
            gridCategoria.DataSource = objetobll.Selecionar();
            gridCategoria.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carregarGrid();
            }

        }


        protected void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
   
            objetoDTO.Nome = txtNome.Text;
            objetoDTO.Descricao = txtDescricao.Text;

            objetobll.Criar(objetoDTO);
            carregarGrid();
        }

        protected void gridCategoria_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.Values["ID"]);
            objetobll.Delete(objetoDTO);
            carregarGrid();
        }

        protected void gridCategoria_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridCategoria.EditIndex = e.NewEditIndex;
            carregarGrid();
        }

        protected void gridCategoria_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.NewValues[0]);
            objetoDTO.Nome = e.NewValues[1].ToString();
            objetoDTO.Descricao = e.NewValues[2].ToString();

            objetobll.Alterar(objetoDTO);
            gridCategoria.EditIndex = -1;
            carregarGrid();
        }

        protected void gridCategoria_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridCategoria.EditIndex = -1;
            carregarGrid();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}