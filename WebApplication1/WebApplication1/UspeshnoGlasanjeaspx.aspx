<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UspeshnoGlasanjeaspx.aspx.cs" Inherits="WebApplication1.UspeshnoGlasanjeaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="cena" runat="server" Text="Label"></asp:Label>
    <asp:ListBox ID="zanrovi" runat="server" OnSelectedIndexChanged="zanrovi_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
    <div class="col-md-2">
    <asp:CheckBoxList ID="filmovi" runat="server" Visible="false">
        
    </asp:CheckBoxList>

        <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Visible="false"></asp:TextBox>

        </div>
   

    <asp:Button ID="kupi" runat="server" Text="kupi" OnClick="kupi_Click" />
</asp:Content>
