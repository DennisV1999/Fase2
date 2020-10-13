<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Opciones.aspx.cs" Inherits="_IPC2_F1E1_201800593.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font-family:Verdana, Geneva, Tahoma, sans-serif; text-align:center;">¡Elija una opción!</h1>
    <div id="opciones" style="text-align:center;">


        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Cargar Partida" Width="200px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Un Jugador" Width="200px"/>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Dos Jugadores" Width="200px"/>
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Torneos" Width="200px"/>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Estadísticas del jugador" Width="200px" OnClick="Button5_Click"/>
        <br />
        <br />
        <br />
        <br />


    </div>
</asp:Content>
