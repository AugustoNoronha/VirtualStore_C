using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lojavirtualvb.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
     
        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClienteGRID.aspx");
        }

        protected void btnProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProdutoGrid.aspx");
        }

        protected void btnCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoriaGRID.aspx");
        }

        protected void btnFornecedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("FornecedorBLL.aspx");
        }
    }
}