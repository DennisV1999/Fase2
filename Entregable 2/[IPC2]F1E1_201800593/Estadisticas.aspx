<%@ Page Title="Estadísticas del Jugador" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Estadisticas.aspx.cs" Inherits="_IPC2_F1E1_201800593.Estadisticas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Nombre: -</h4>
    <h4>Apellido: -</h4>
    <h4>Username: -</h4>
    <h4>Victorias: 0</h4>
    <h4>Derrotas: 0</h4>
    <h4>Empates: 0</h4>
    <br />
    <br />
    <br />
    <div>
        <asp:Table ID="Table1" runat="server" BorderStyle="Solid">
             <asp:TableRow BorderStyle="Solid">
                <asp:TableCell BorderStyle="Solid">Tipo de Partida</asp:TableCell>
                <asp:TableCell BorderStyle="Solid">Movimientos</asp:TableCell>
                <asp:TableCell BorderStyle="Solid">Resultado</asp:TableCell>
             </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Multijugador</asp:TableCell>
                <asp:TableCell>0</asp:TableCell>
                <asp:TableCell>Victoria</asp:TableCell>
             </asp:TableRow>
        </asp:Table>


    </div>
</asp:Content>
