<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_IPC2_F1E1_201800593._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font-family:Verdana, Geneva, Tahoma, sans-serif; text-align:center;">¡Bienvenido a Othello Online!</h1>
    <br />
    <h3 style="font-family: Courier New, Courier, monospace; font-weight:bold; text-align: center;">Iniciar Sesión</h3>
    <br />
    <br />
    <div id="textarea1" style="text-align:center;">

        <asp:Label ID="Label1" runat="server" Text="Usuario: " Width="200px" ForeColor="Black"></asp:Label>

        <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Contraseña: " Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox2" textmode="Password" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Loguear" OnClick="Button1_Click" />

    </div>
        

</asp:Content>
