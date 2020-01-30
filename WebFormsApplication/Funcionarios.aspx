<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Funcionarios.aspx.cs" Inherits="WebFormsApplication.Funcionarios" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="divGrid">
                <asp:GridView ID="gridFuncionarios" AutoGenerateColumns="False" ShowFooter="true" ShowHeaderWhenEmpty="true"
                    OnRowCommand="gridFuncionarios_OnRowCommand" 
                    OnRowEditing="gridFuncionarios_RowEditing" 
                    OnRowCancelingEdit="gridFuncionarios_RowCancelingEdit"
                    OnRowUpdating="gridFuncionarios_RowUpdating" 
                    OnRowDeleting="gridFuncionarios_RowDeleting"

                    runat="server" CellPadding="1" Height="149px" Width="724px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellSpacing="1">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />

                    <Columns>

                        <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                                <asp:Label Text='<%# Eval("id") %>' runat="server"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtId" Text='<%# Eval("id") %>' runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtIdFooter" Text='<%# Eval("id") %>' runat="server"></asp:TextBox>
                            </FooterTemplate>
                        </asp:TemplateField>

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

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton ImageUrl="~/Imagens/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px" />
                                <asp:ImageButton ImageUrl="~/Imagens/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:ImageButton ImageUrl="~/Imagens/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px" />
                                <asp:ImageButton ImageUrl="~/Imagens/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:ImageButton ImageUrl="~/Imagens/addnew.png" runat="server" CommandName="AddNew" ToolTip="AddNew" Width="20px" Height="20px" />
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
    </form>
</body>
</html>
