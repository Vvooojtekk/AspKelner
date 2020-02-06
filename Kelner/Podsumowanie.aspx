<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Podsumowanie.aspx.cs" Inherits="Kelner.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table">
    <tr>
        <td>
            <h1><asp:Label ID="lblPodsumowanie" runat="server" Text="Podsumowanie"></asp:Label></h1>
        </td>
        
    </tr>
    <tr>
        <td>
            <h5>  <asp:Label ID="lblStolik" runat="server"></asp:Label></h5>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblTresc" runat="server"></asp:Label>
        </td>
        <td colspan="2">&nbsp;</td>
    </tr>
</table>
</asp:Content>
