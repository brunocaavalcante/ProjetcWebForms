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
    public partial class Funcionarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarGridFuncionarios();
            }
        }

        public void CarregarGridFuncionarios()
        {
            var listaFuncionarios = new BLLFuncionario().ListarFuncionarios();
            if (listaFuncionarios.Count > 0)
            {
                this.gridFuncionarios.DataSource = listaFuncionarios;
                this.gridFuncionarios.DataBind();
            }
            else
            {
                gridFuncionarios.DataSource = listaFuncionarios;
                gridFuncionarios.DataBind();
                gridFuncionarios.Rows[0].Cells.Clear();
                gridFuncionarios.Rows[0].Cells.Add(new TableCell());
                gridFuncionarios.Rows[0].Cells[0].ColumnSpan = 0;
                gridFuncionarios.Rows[0].Cells[0].Text = "No Data Found ..!";
                gridFuncionarios.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }

        }

        protected void gridFuncionarios_OnRowCommand(Object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddNew"))
                {
                    BLLFuncionario bLLFuncionario = new BLLFuncionario();
                    Funcionario f = new Funcionario();


                    f.Nome = (gridFuncionarios.FooterRow.FindControl("txtNomeFooter") as TextBox).Text.Trim();
                    f.RG = (gridFuncionarios.FooterRow.FindControl("txtRGFooter") as TextBox).Text.Trim();
                    f.CPF = (gridFuncionarios.FooterRow.FindControl("txtCPFFooter") as TextBox).Text.Trim();
                    f.Cargo = (gridFuncionarios.FooterRow.FindControl("txtCargoFooter") as TextBox).Text.Trim();
                    //f.Administrado = Convert.ToBoolean((gridFuncionarios.FooterRow.FindControl("txtEmailFooter") as TextBox).Text.Trim());
                    f.Salario = Convert.ToDecimal((gridFuncionarios.FooterRow.FindControl("txtSalarioFooter") as TextBox).Text.Trim());
                    f.dataNascimento = Convert.ToDateTime((gridFuncionarios.FooterRow.FindControl("txtdataNascimentoFooter") as TextBox).Text.Trim());

                    bLLFuncionario.InserirFuncionario(f);
                    CarregarGridFuncionarios();
                    this.lblSuccessMessage.Text = "New Record Added";
                    lblErrorMessage.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gridFuncionarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridFuncionarios.EditIndex = e.NewEditIndex;
            CarregarGridFuncionarios();
        }

        protected void gridFuncionarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridFuncionarios.EditIndex = -1;
            CarregarGridFuncionarios();
        }

        protected void gridFuncionarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                BLLFuncionario bLLFuncionario = new BLLFuncionario();
                Funcionario f = new Funcionario();

                f.Id = Convert.ToInt32(gridFuncionarios.DataKeys[e.RowIndex].Value.ToString());
                f.Nome = (gridFuncionarios.Rows[e.RowIndex].FindControl("txtNome") as TextBox).Text.Trim();
                f.RG = (gridFuncionarios.Rows[e.RowIndex].FindControl("txtRG") as TextBox).Text.Trim();
                f.CPF = (gridFuncionarios.Rows[e.RowIndex].FindControl("txtCPF") as TextBox).Text.Trim();
                f.Cargo = (gridFuncionarios.Rows[e.RowIndex].FindControl("txtCargo") as TextBox).Text.Trim();
                //f.Administrado = Convert.ToBoolean((gridFuncionarios.Rows[e.RowIndex].FindControl("txtEmailFooter") as TextBox).Text.Trim());
                f.Salario = Convert.ToDecimal((gridFuncionarios.Rows[e.RowIndex].FindControl("txtSalario") as TextBox).Text.Trim());
                f.dataNascimento = Convert.ToDateTime((gridFuncionarios.Rows[e.RowIndex].FindControl("txtdataNascimento") as TextBox).Text.Trim());
                bLLFuncionario.UpdateFuncionario(f);
                gridFuncionarios.EditIndex = -1;
                CarregarGridFuncionarios();
                lblSuccessMessage.Text = "Usuario Atualizado com Sucesso!";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gridFuncionarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                BLLFuncionario bLLFuncionario = new BLLFuncionario();
                Funcionario f = new Funcionario();

                f.Id = Convert.ToInt32(gridFuncionarios.DataKeys[e.RowIndex].Value.ToString());
                bLLFuncionario.DeleteFuncionario(f);
                CarregarGridFuncionarios();

                lblSuccessMessage.Text = "Funcionario deletado com sucesso!";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }


    }
}