<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="m-4">
            ime:
            <asp:TextBox ID="name" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator
                class="text-bg-danger"
                ID="RequiredFieldValidator1"
                ControlToValidate="name"
                runat="server"
                ErrorMessage="Vnesete ime ">
            </asp:RequiredFieldValidator>
        </div>
        <div class="m-4">
            lozinka:
            <asp:TextBox ID="pass" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator
                class="text-bg-danger"
                ID="RequiredFieldValidator2"
                runat="server"
                ErrorMessage="Vnesete lozinka" ControlToValidate="pass"></asp:RequiredFieldValidator>
        </div>
        <div class="m-4">
            email:
            <asp:TextBox ID="email" runat="server"></asp:TextBox>


            <asp:RegularExpressionValidator
                class="text-bg-danger"
                ID="RegularExpressionValidator1"
                runat="server"
                ValidationExpression="\S+@\w+\.\w+"
                ErrorMessage="Nevaliden format" ControlToValidate="email"></asp:RegularExpressionValidator>
        </div>

        <asp:Button ID="najaviSe" runat="server" Text="Najava" OnClick="najaviSe_Click" />

    </div>

</asp:Content>
