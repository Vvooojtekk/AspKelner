<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stoliki.aspx.cs" Inherits="Kelner.Stoliki" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
            <div class="container">
                <div class="row my-4">
                    <div class="col">
                        <h2>Wybierz stolik</h2>
                            <asp:DropDownList ID="ddlStoliki" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px" class="dropdown-list m-10">
                                <asp:ListItem>wybierz stolik</asp:ListItem>
                                <asp:ListItem>Stolik 1</asp:ListItem>
                                <asp:ListItem>Stolik 2</asp:ListItem>
                                <asp:ListItem>Stolik 3</asp:ListItem>
                                <asp:ListItem>Stolik 4</asp:ListItem>
                                <asp:ListItem>Stolik 5</asp:ListItem>
                            </asp:DropDownList>


                    </div>
                
            
                    <div class="col">                        
                        <div class="m-1"><h6><asp:Label ID="lblOferta3" runat="server" Text="Produkty zamówione do stolika" Visible="False"></asp:Label></h6></div>
                        <asp:ListBox ID="lstZamowienie" runat="server" Height="229px" Visible="False" Width="230px" AutoPostBack="True" OnSelectedIndexChanged="lstZamowienie_SelectedIndexChanged" style="margin-right: 20px"></asp:ListBox>
                    </div>

                    <div class="col">
                        <asp:Label ID="lblNazwaDania" runat="server" Text="Nazwa :" Visible="False"></asp:Label>
                        <asp:Label ID="lblNazwaDaniaWartosc" runat="server" Visible="False"></asp:Label>
                        <br />
                        <asp:Label ID="lblCenaJedn" runat="server" Text="Cena za 1szt. :" Visible="False"></asp:Label>
                        <asp:Label ID="lblCenaJednWartosc" runat="server" Visible="False"></asp:Label>
                        <br />
                        <asp:Label ID="lblCenaZaWszystkie" runat="server" Text="Cena za wszystkie :" Visible="False"></asp:Label>
                        <asp:Label ID="lblCenaZaWszystkieWartosc" runat="server" Visible="False"></asp:Label>

                    
                    
                        <asp:Button ID="btnUsun" runat="server" AutoPostBack="True" OnClick="btnUsun_Click" Text="Usuń" Visible="False" />
                    
                        <% if (this.btnUsun.Visible) { %>
                            <hr />
                        <% } %>
                        <asp:Button ID="btnZmienIlosc" runat="server" Text="Zmień ilość" OnClick="btnZmienIlosc_Click" Visible="False" />
                        <asp:DropDownList ID="ddlIloscZmien" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlIloscZmien_SelectedIndexChanged" Visible="False">
                        </asp:DropDownList>
                    
                    </div>
            
                
                
                </div>
                <div class="row">
                    <div class="col">
                        <h2><asp:Label ID="lblOferta" runat="server" Text="Oferta" Visible="False"></asp:Label></h2>
                    </div>
                    <div class="col">
                        <div class="m-1"><h6><asp:Label ID="lblOferta2" runat="server" Text="Dodaj produkt do zamówienia" Visible="False"></asp:Label></h6></div>
                        <asp:ListBox ID="lstOferta" runat="server" AutoPostBack="True" Height="227px" OnSelectedIndexChanged="lstOferta_SelectedIndexChanged" Visible="False" Width="230px"></asp:ListBox>

                    </div>
            
                    <div class="col">
                        <asp:Label ID="lblCena" runat="server" Text="Cena: " Visible="False"></asp:Label>
                        <asp:Label ID="lblCenaWartosc" runat="server" Visible="False"></asp:Label>
                        <br />
                        <asp:Label ID="lblIlosc" runat="server" Text="Ilość" Visible="False"></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddlIlosc" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlIlosc_SelectedIndexChanged" Visible="False">
                        </asp:DropDownList>
                        <asp:Button ID="btnDodaj" runat="server" AutoPostBack="True" OnClick="btnDodaj_Click" Text="Dodaj" Visible="False" Enabled="False" class="btn-warning" />
                    </div>
                </div>
                <div class="row my-3">
                    <div class="col">
                        <h3><asp:Label ID="lblSuma" runat="server" Text="Suma" Visible="False"></asp:Label></h3>
                    </div>
                    <div class="col">
                        <h3><asp:Label ID="lblSumaWartosc" runat="server" Text="0" Visible="False"></asp:Label></h3>
                    </div>
                    <div class="col">
                    </div>
                </div>
            
            
            
                <div class="row">
                    <div class="col">
                        <asp:Button ID="btnZaplac" runat="server" OnClick="btnZaplac_Click" Text="Zapłać" Visible="False" class="btn-success" Width="205px" />
                    </div>

                </div>
            </div>
        
    </asp:Panel>
</asp:Content>
