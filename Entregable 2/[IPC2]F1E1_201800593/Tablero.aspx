<%@ Page Title="Partida" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tablero.aspx.cs" Inherits="_IPC2_F1E1_201800593.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lbljugador" runat="server" Text="Turno de: Jugador 1" Font-Bold="True" Font-Italic="True" Font-Names="Museo 500" Font-Overline="False" Font-Size="XX-Large"></asp:Label>
    <div id="tablero" style="height:600px; width:600px; position:fixed; left:50%; margin-left:-300px; top:50%; margin-top:-250px">
        <div id="principal" align="center">
            <asp:Panel ID="TopPanel" runat="server" Height="60px" Width="400px"></asp:Panel>
            <asp:Panel ID="BoardPanel" runat="server" Height="400px" Width="400px"></asp:Panel>
            
        </div>
        <div id="abajo" style="margin-top:20px;" align="center">
            <asp:Panel ID="BottomPanel" runat="server" Height="60px" Width="400px"></asp:Panel>
        </div>
        <div id="izquierda" style="height:400px; width:60px; float:left; margin-top:-470px; margin-right:-20px; position:fixed;">
            <asp:Panel ID="LeftPanel" runat="server" Height="400px" Width="60px"></asp:Panel>
        </div>
        <div id="derecha" style="height:400px; width:60px; float:right; margin-top:-470px; margin-left:-20px; position:relative;">
            <asp:Panel ID="RightPanel" runat="server" Height="400px" Width="60px"></asp:Panel>
        </div>
    </div>

</asp:Content>
