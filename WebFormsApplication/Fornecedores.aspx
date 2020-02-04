<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fornecedores.aspx.cs" Inherits="WebFormsApplication.Fornecedores" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <br /><br />
    <link href="Content/Dafault.css" rel="stylesheet" />
    <div>
        <div class="divGrid">
            <asp:GridView ID="gridFornecedores" AutoGenerateColumns="false" ShowFooter="true" ShowHeaderWhenEmpty="true" DataKeyNames="Id"
                OnRowCommand="gridFornecedores_OnRowCommand"
                OnRowEditing="gridFornecedores_RowEditing"
                OnRowCancelingEdit="gridFornecedores_RowCancelingEdit"
                OnRowUpdating="gridFornecedores_RowUpdating"
                OnRowDeleting="gridFornecedores_RowDeleting"
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
                            <asp:Label Text='<%# Eval("RazaoSocial") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRazaoSocial" Text='<%# Eval("RazaoSocial") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtRazaoSocialFooter" Text='<%# Eval("RazaoSocial") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="CNPJ">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("CNPJ") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCNPJ" Text='<%# Eval("CNPJ") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtCNPJFooter" Text='<%# Eval("CNPJ") %>' runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Telefone">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("TelefoneEmpresa") %>' runat="server"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTelefoneEmpresa" Text='<%# Eval("TelefoneEmpresa") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtTelefoneEmpresaFooter" Text='<%# Eval("TelefoneEmpresa") %>' runat="server"></asp:TextBox>
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
