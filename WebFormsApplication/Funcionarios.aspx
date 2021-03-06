﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Funcionarios.aspx.cs" Inherits="WebFormsApplication.Funcionarios" %>



<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <br /><br />

    <div>
        <div class="divGrid">
            <asp:GridView ID="gridFuncionarios" AutoGenerateColumns="false" ShowFooter="true" ShowHeaderWhenEmpty="true" DataKeyNames="Id"
                OnRowCommand="gridFuncionarios_OnRowCommand"
                OnRowEditing="gridFuncionarios_RowEditing"
                OnRowCancelingEdit="gridFuncionarios_RowCancelingEdit"
                OnRowUpdating="gridFuncionarios_RowUpdating"
                OnRowDeleting="gridFuncionarios_RowDeleting"
                runat="server" CellPadding="1" Height="149px" Width="1047px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellSpacing="1">
                <EditRowStyle HorizontalAlign="Justify" Width="200px" />
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
                <RowStyle ForeColor="#000066" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" HorizontalAlign="Center" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />

                <Columns>

                    <asp:TemplateField HeaderText="Nome">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("nome") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNome" Text='<%# Eval("nome") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNomeFooter" Text='<%# Eval("nome") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="RG">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("RG") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRG" Text='<%# Eval("RG") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtRGFooter" Text='<%# Eval("RG") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="CPF">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("CPF") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCPF" Text='<%# Eval("CPF") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtCPFFooter" Text='<%# Eval("CPF") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Salario">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("salario") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSalario" Text='<%# Eval("salario") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtSalarioFooter" Text='<%# Eval("salario") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Cargo">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("cargo") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCargo" Text='<%# Eval("cargo") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtCargoFooter" Text='<%# Eval("cargo") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Data de Nascimento">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("dataNascimento") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtdataNascimento" Text='<%# Eval("dataNascimento") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtdataNascimentoFooter" Text='<%# Eval("dataNascimento") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField >
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/Imagens/edit.png" runat="server" CommandName="Edit" ToolTip="Editar" Width="20px" Height="20px" />
                            <asp:ImageButton ImageUrl="~/Imagens/delete.png" runat="server" CommandName="Delete" ToolTip="Excluir" Width="20px" Height="20px" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="~/Imagens/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px" />
                            <asp:ImageButton ImageUrl="~/Imagens/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="~/Imagens/addnew.png" runat="server" CommandName="AddNew" ToolTip="Adicionar" Width="20px" Height="20px" />
                        </FooterTemplate>
                    </asp:TemplateField>

                </Columns>
            
            </asp:GridView>
            <br />
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
        </div>
    </div>


</asp:Content>




