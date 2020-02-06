<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stoliki.aspx.cs" Inherits="Kelner.Stoliki" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="nav-justified">
            
            <tr>
                <td rowspan="4" style="vertical-align: top;">

                        <asp:DropDownList ID="ddlStoliki" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px" CssClass="dropdown">
                            <asp:ListItem>wybierz stolik</asp:ListItem>
                            <asp:ListItem>Stolik 1</asp:ListItem>
                            <asp:ListItem>Stolik 2</asp:ListItem>
                            <asp:ListItem>Stolik 3</asp:ListItem>
                            <asp:ListItem>Stolik 4</asp:ListItem>
                            <asp:ListItem>Stolik 5</asp:ListItem>
                        </asp:DropDownList>

                </td>
                <td colspan="2">
                    <asp:Label ID="lblZamowienie" runat="server" Text="Zamówione dania" Visible="False"></asp:Label>
                </td>
                <td style="width: 168px">
                    <asp:Label ID="lblOferta" runat="server" Text="Oferta" Visible="False"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="vertical-align: top; width: 28px;";>
                    <asp:ListBox ID="lstZamowienie" runat="server" Height="229px" Visible="False" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="lstZamowienie_SelectedIndexChanged" style="margin-right: 20px"></asp:ListBox>
                </td>
                <td style="width: 335px" class="modal-sm">
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
                        <asp:DropDownList ID="ddlIloscZmien" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlIlosc_SelectedIndexChanged" Visible="False">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                        </asp:DropDownList>
                    
                </td>
                <td style="vertical-align: top; width: 168px;">
                    
                    <asp:ListBox ID="lstOferta" runat="server" AutoPostBack="True" Height="227px" OnSelectedIndexChanged="lstOferta_SelectedIndexChanged" Visible="False" Width="200px"></asp:ListBox>
                    <br />
                    <br />
                </td>
                <td>
                    <asp:Label ID="lblCena" runat="server" Text="Cena: " Visible="False"></asp:Label>
                    <asp:Label ID="lblCenaWartosc" runat="server" Visible="False"></asp:Label>
                    <br />
                    <asp:Label ID="lblIlosc" runat="server" Text="Ilość" Visible="False"></asp:Label>
                    &nbsp;
                    <asp:DropDownList ID="ddlIlosc" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlIlosc_SelectedIndexChanged" Visible="False">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:Button ID="btnDodaj" runat="server" AutoPostBack="True" OnClick="btnDodaj_Click" Text="Dodaj" Visible="False" Enabled="False" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td ;="" style="vertical-align: top; width: 28px;">
                    <asp:Label ID="lblSuma" runat="server" Text="Suma" Visible="False"></asp:Label>
                </td>
                <td style="width: 335px" class="modal-sm">
                    <asp:Label ID="lblSumaWartosc" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td style="vertical-align: top; width: 168px;">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            
            
            <tr>
                <td ;="" style="vertical-align: top; width: 28px;">
                    <asp:Button ID="btnZaplac" runat="server" OnClick="btnZaplac_Click" Text="Zapłać" Visible="False" />
                </td>
                <td class="modal-sm" style="width: 335px">&nbsp;</td>
                <td style="vertical-align: top; width: 168px;">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            
            
        </table>
        <table class="nav-justified">
                    </table>
    </asp:Panel>
</asp:Content>
