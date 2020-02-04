using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void goToDestino_Click(object sender, ImageClickEventArgs e)
        {
            var page = sender.GetType().GetProperty("AlternateText").GetValue(sender);
            switch (page)
            {
                case "Funcionarios": Response.Redirect("Funcionarios.aspx"); break;

                case "Clientes": Response.Redirect("Clientes.aspx"); break;

                case "Fornecedores": Response.Redirect("Fornecedores.aspx"); break;

            }
        }
    }
}