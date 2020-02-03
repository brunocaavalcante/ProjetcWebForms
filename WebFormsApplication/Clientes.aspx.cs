using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApplication
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGridClientes();
            }
        }

        public void CarregarGridClientes()
        {
            var listaClientes = new BLLCliente().ListarClientes();
            if (listaClientes.Rows.Count > 0)
            {

                this.gridClientes.DataSource = listaClientes;
                this.gridClientes.DataBind();
            }
            else
            {
                listaClientes.Rows.Add(listaClientes.NewRow());
                gridClientes.DataSource = listaClientes;
                gridClientes.DataBind();
                gridClientes.Rows[0].Cells.Clear();
                gridClientes.Rows[0].Cells.Add(new TableCell());
                gridClientes.Rows[0].Cells[0].ColumnSpan = listaClientes.Columns.Count;
                gridClientes.Rows[0].Cells[0].Text = "Nenhum cliente encontrado..!";
                gridClientes.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void gridClientes_OnRowCommand(Object sender, GridViewCommandEventArgs e)
        {
            try
            {
                this.lblSuccessMessage.Text = "";
                if (e.CommandName.Equals("AddNew"))
                {
                    BLLCliente bLLCliente = new BLLCliente();
                    Cliente c = new Cliente();

                    if (validaCampos())
                    {
                        c.Nome = (gridClientes.FooterRow.FindControl("txtNomeFooter") as TextBox).Text.Trim();
                        c.RG = (gridClientes.FooterRow.FindControl("txtRGFooter") as TextBox).Text.Trim();
                        c.CPF = (gridClientes.FooterRow.FindControl("txtCPFFooter") as TextBox).Text.Trim();
                        c.PontuacaoCliente = Convert.ToDecimal((gridClientes.FooterRow.FindControl("txtPontuacaoClienteFooter") as TextBox).Text.Trim());
                        c.dataNascimento = Convert.ToDateTime((gridClientes.FooterRow.FindControl("txtdataNascimentoFooter") as TextBox).Text.Trim());

                        bLLCliente.InserirCliente(c);
                        CarregarGridClientes();
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

        protected void gridClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridClientes.EditIndex = e.NewEditIndex;
            CarregarGridClientes();
        }

        protected void gridClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridClientes.EditIndex = -1;
            CarregarGridClientes();
        }

        protected void gridClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                BLLCliente bLLCliente = new BLLCliente();
                Cliente f = new Cliente();

                f.Id = Convert.ToInt32(gridClientes.DataKeys[e.RowIndex].Value.ToString());
                f.Nome = (gridClientes.Rows[e.RowIndex].FindControl("txtNome") as TextBox).Text.Trim();
                f.RG = (gridClientes.Rows[e.RowIndex].FindControl("txtRG") as TextBox).Text.Trim();
                f.CPF = (gridClientes.Rows[e.RowIndex].FindControl("txtCPF") as TextBox).Text.Trim();
                //f.Administrado = Convert.ToBoolean((gridClientes.Rows[e.RowIndex].FindControl("txtEmailFooter") as TextBox).Text.Trim());
                f.PontuacaoCliente = Convert.ToDecimal((gridClientes.Rows[e.RowIndex].FindControl("txtPontuacaoCliente") as TextBox).Text.Trim());
                f.dataNascimento = Convert.ToDateTime((gridClientes.Rows[e.RowIndex].FindControl("txtdataNascimento") as TextBox).Text.Trim());
                bLLCliente.UpdateCliente(f);
                gridClientes.EditIndex = -1;
                CarregarGridClientes();
                lblSuccessMessage.Text = "Cliente Atualizado com Sucesso!";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gridClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                BLLCliente bLLCliente = new BLLCliente();
                Cliente f = new Cliente();

                f.Id = Convert.ToInt32(gridClientes.DataKeys[e.RowIndex].Value.ToString());
                bLLCliente.DeleteCliente(f);
                CarregarGridClientes();

                lblSuccessMessage.Text = "Cliente deletado com sucesso!";
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
            if ((gridClientes.FooterRow.FindControl("txtNomeFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo nome deve ser preenchido<br>";
                erro++;
            }
            if ((gridClientes.FooterRow.FindControl("txtRGFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo RG deve ser preenchido<br>";
                erro++;
            }
            if ((gridClientes.FooterRow.FindControl("txtCPFFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo CPF deve ser preenchido<br>";
                erro++;
            }
            if ((gridClientes.FooterRow.FindControl("txtPontuacaoClienteFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo pontuacao deve ser preenchido<br>";
                erro++;
            }
            if ((gridClientes.FooterRow.FindControl("txtdataNascimentoFooter") as TextBox).Text.Trim().Equals(""))
            {
                msg += "* O campo data deve ser preenchido<br>";
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