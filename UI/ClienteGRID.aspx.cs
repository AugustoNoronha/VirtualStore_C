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
    public partial class ClienteGRID : System.Web.UI.Page
    {
        ClienteDTO objetoDTO = new ClienteDTO();
        ClienteBLL objetobll = new ClienteBLL();

        public void carregarGrid()
        {
            gridCliente.DataSource = objetobll.Selecionar();
            gridCliente.DataBind();
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
            objetoDTO.Cpf = txtCPF.Text;
            objetoDTO.Endereco = txtEndereco.Text;
            objetoDTO.Telefone = txtTelefone.Text;
            objetoDTO.Email = txtEmail.Text;
            objetoDTO.Senha = txtSenha.Text;

            objetobll.Criar(objetoDTO);
            carregarGrid();
        }

        protected void gridCliente_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.Values["ID"]);
            objetobll.Delete(objetoDTO);
            carregarGrid();
        }

        protected void gridCliente_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridCliente.EditIndex = e.NewEditIndex;
            carregarGrid();
        }

        protected void gridCliente_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            objetoDTO.Id = Convert.ToInt32(e.NewValues[0]);
            objetoDTO.Nome = e.NewValues[1].ToString();
            objetoDTO.Cpf = e.NewValues[2].ToString();
            objetoDTO.Endereco = e.NewValues[3].ToString();
            objetoDTO.Telefone = e.NewValues[4].ToString();
            objetoDTO.Email = e.NewValues[5].ToString();

            objetobll.Alterar(objetoDTO);
            gridCliente.EditIndex = -1;
            carregarGrid();
        }

        protected void gridCliente_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridCliente.EditIndex = -1;
            carregarGrid();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}