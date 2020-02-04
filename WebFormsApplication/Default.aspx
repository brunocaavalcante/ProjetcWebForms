<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/Dafault.css" rel="stylesheet" />
    <asp:Panel ID="PanelHome" runat="server">
        <div class="limit">

            <asp:Label ID="lblFuncionarioLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="funcionarioLog" runat="server"
                    AlternateText="Funcionarios"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    OnClick="goToDestino_Click"
                    ImageUrl="Imagens/funcionarioLog.png" />
                <p class="txtItemHome">Funcionários</p>
            </asp:Label>

            <asp:Label ID="clienteLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="Image3" runat="server"
                    AlternateText="Clientes"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    OnClick="goToDestino_Click"
                    ImageUrl="Imagens/clienteLog.png" />
                <p class="txtItemHome">Clientes</p>
            </asp:Label>

            <asp:Label ID="admLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="Image7" runat="server"
                    AlternateText="Funcionarios"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    ImageUrl="Imagens/administradorLog.png" />
                <p class="txtItemHome">Administrador</p>
            </asp:Label>

            <asp:Label ID="relatorioLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="Image1" runat="server"
                    AlternateText="Funcionarios"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    ImageUrl="Imagens/relatorioLog.png" />
                <p class="txtItemHome">Relatórios</p>
            </asp:Label>

            <asp:Label ID="fornecedorLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="Image2" runat="server"
                    AlternateText="Fornecedores"
                    OnClick="goToDestino_Click"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    ImageUrl="Imagens/fornecedorLog.png" />
                <p class="txtItemHome">Fornecedores</p>
            </asp:Label>

            <asp:Label ID="vendaLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="Image5" runat="server"
                    AlternateText="Funcionarios"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    ImageUrl="Imagens/vendaLog.png" />
                <p class="txtItemHome">Vendas</p>
            </asp:Label>

            <asp:Label ID="testeLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="Image6" runat="server"
                    AlternateText="Funcionarios"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    ImageUrl="Imagens/produtoLog.png" />
                <p class="txtItemHome">Produtos</p>
            </asp:Label>

            <asp:Label ID="estoqueLog" runat="server" CssClass="item-menu-square">
                <asp:ImageButton ID="Image4" runat="server"
                    AlternateText="Funcionarios"
                    CssClass="img-icone-dafault"
                    ImageAlign="left"
                    ImageUrl="Imagens/estoqueLog.png" />
                <p class="txtItemHome">Estoque</p>
            </asp:Label>

        </div>
    </asp:Panel>

</asp:Content>
