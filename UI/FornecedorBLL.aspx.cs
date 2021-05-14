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
    public partial class FornecedorBLL : System.Web.UI.Page
    {
        FornecedorDTO objetoDTO = new FornecedorDTO();
        ForncedorBLL objetobll = new ForncedorBLL();

        public void carregarGrid()
        {
            gridFornecedor.DataSource = objetobll.Selecionar();
            gridFornecedor.DataBind();
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
            objetoDTO.Cnpj = txtCNPJ.Text;
            objetoDTO.Email = txtEmail.Text;
            objetoDTO.Telefone = txtTelefone.Text;
            objetoDTO.NomeResponsavel = txtRepresentante.Text;
            objetoDTO.TelefoneResponsavel = txtTelefoneRepresentante.Text;

            objetobll.Criar(objetoDTO);
            carregarGrid();
        }

        protected void gridFornecedor_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.Values["ID"]);
            objetobll.Delete(objetoDTO);
            carregarGrid();
        }

        protected void gridFornecedor_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridFornecedor.EditIndex = e.NewEditIndex;
            carregarGrid();
        }

        protected void gridFornecedor_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.NewValues[0]);
            objetoDTO.Nome = e.NewValues[1].ToString();
            objetoDTO.Cnpj = e.NewValues[2].ToString();
            objetoDTO.Email = e.NewValues[3].ToString();
            objetoDTO.Telefone = e.NewValues[4].ToString();
            objetoDTO.NomeResponsavel = e.NewValues[5].ToString();
            objetoDTO.TelefoneResponsavel = e.NewValues[6].ToString();


            objetobll.Alterar(objetoDTO);
            gridFornecedor.EditIndex = -1;
            carregarGrid();
        }

        protected void gridFornecedor_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridFornecedor.EditIndex = -1;
            carregarGrid();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            Response.Redirect("index.aspx");
        }
    }
}