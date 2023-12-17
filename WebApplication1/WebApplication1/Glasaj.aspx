<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="WebApplication1.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Image ID="Image1" runat="server" ImageUrl="~/logo-large-500x500_2.png" />
    <br />

     <asp:Label ID="professor" runat="server" Text=""></asp:Label>

    <asp:ListBox ID="predmeti" runat="server" OnSelectedIndexChanged="predmeti_SelectedIndexChanged" AutoPostBack="true">
        
    </asp:ListBox>
  

     <asp:ListBox ID="krediti" runat="server">
     
     </asp:ListBox>
     

    <asp:Button ID="Button1" runat="server" Text="Glasaj" OnClick="Button1_Click" />

    <div >
        predmet:
        <asp:TextBox ID="imePredmet" runat="server"></asp:TextBox>
    </div>
        <div >
        Krediti:
        <asp:TextBox ID="kreditVrednost" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="dodadi" runat="server" Text="Dodadi" OnClick="dodadi_Click" />
    <asp:Button ID="izbrisi" runat="server" Text="izbrisi" OnClick="izbrisi_Click" />


    

</asp:Content>
