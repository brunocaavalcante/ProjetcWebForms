using BLL;
using BLL.Models;
using System;
using System.Web.UI.WebControls;

namespace WebFormsApplication
{
    public partial class Fornecedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGrid();
            }

        }

        public void CarregarGrid()
        {
            var listaFornecedores = new BLLFornecedor().ListarFornecedores();
            if (listaFornecedores.Rows.Count > 0)
            {

                this.gridFornecedores.DataSource = listaFornecedores;
                this.gridFornecedores.DataBind();
            }
            else
            {
                listaFornecedores.Rows.Add(listaFornecedores.NewRow());
                gridFornecedores.DataSource = listaFornecedores;
                gridFornecedores.DataBind();
                gridFornecedores.Rows[0].Cells.Clear();
                gridFornecedores.Rows[0].Cells.Add(new TableCell());
                gridFornecedores.Rows[0].Cells[0].ColumnSpan = listaFornecedores.Columns.Count;
                gridFornecedores.Rows[0].Cells[0].Text = "Nenhum Fornecedor encontrado..!";
                gridFornecedores.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void gridFornecedores_OnRowCommand(Object sender, GridViewCommandEventArgs e)
        {
            try
            {
                this.lblSuccessMessage.Text = "";
                if (e.CommandName.Equals("AddNew"))
                {
                    BLLFornecedor BLLFornecedor = new BLLFornecedor();
                    Fornecedor f = new Fornecedor();

                    if (validaCampos())
                    {
                        f.RazaoSocial= (gridFornecedores.FooterRow.FindControl("txtRazaoSocialFooter") as TextBox).Text.Trim();
                        f.TelefoneEmpresa = (gridFornecedores.FooterRow.FindControl("txtTelefoneEmpresaFooter") as TextBox).Text.Trim();
                        f.CNPJ = (gridFornecedores.FooterRow.FindControl("txtCNPJFooter") as TextBox).Text.Trim();                     

                        BLLFornecedor.InserirFornecedor(f);
                        CarregarGrid();
                        this.lblSuccessMessage.Text = "New Record Added";
                        lblErrorMessage.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gridFornecedores_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridFornecedores.EditIndex = e.NewEditIndex;
            CarregarGrid();
        }

        protected void gridFornecedores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridFornecedores.EditIndex = -1;
            CarregarGrid();
        }

        protected void gridFornecedores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                BLLFornecedor BLLFornecedor = new BLLFornecedor();
                Fornecedor f = new Fornecedor();

                f.Id = Convert.ToInt32(gridFornecedores.DataKeys[e.RowIndex].Value.ToString());
                f.RazaoSocial = (gridFornecedores.Rows[e.RowIndex].FindControl("txtRazaoSocial") as TextBox).Text.Trim();
                f.TelefoneEmpresa = (gridFornecedores.Rows[e.RowIndex].FindControl("txtTelefoneEmpresa") as TextBox).Text.Trim();
                f.CNPJ = (gridFornecedores.Rows[e.RowIndex].FindControl("txtCNPJ") as TextBox).Text.Trim();

                BLLFornecedor.UpdateFornecedor(f);
                gridFornecedores.EditIndex = -1;
                CarregarGrid();
                lblSuccessMessage.Text = "Fornecedor Atualizado com Sucesso!";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gridFornecedores_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                BLLFornecedor BLLFornecedor = new BLLFornecedor();
                Fornecedor f = new Fornecedor();

                f.Id = Convert.ToInt32(gridFornecedores.DataKeys[e.RowIndex].Value.ToString());
                BLLFornecedor.DeleteFornecedor(f);
                CarregarGrid();

                lblSuccessMessage.Text = "Fornecedor deletado com sucesso!";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected bool validaCampos()
        {
            var msg = "";
            var erro = 0;
            if ((gridFornecedores.FooterRow.FindControl("txtRazaoSocialFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo Razao Social deve ser preenchido<br>";
                erro++;
            }
            if ((gridFornecedores.FooterRow.FindControl("txtCNPJFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo CNPJ deve ser preenchido<br>";
                erro++;
            }
            if ((gridFornecedores.FooterRow.FindControl("txtTelefoneEmpresaFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo Telefone da Empresa deve ser preenchido<br>";
                erro++;
            }
            if (erro > 0)
            {
                this.lblErrorMessage.Text = msg;
                return false;
            }
            return true;
        }

    }
}