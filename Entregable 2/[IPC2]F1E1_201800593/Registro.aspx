<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="_IPC2_F1E1_201800593.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <h1 style="font-family:Verdana, Geneva, Tahoma, sans-serif; text-align:center;">Registro de Usuarios</h1>
     <div align="center" id="cont">
         <div id="textareas1">
         <asp:Label ID="Label1" runat="server" Text="Nombre: " Width="200px"></asp:Label>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label2" runat="server" Text="Apellidos: " Width="200px"></asp:Label>
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label3" runat="server" Text="Username: " Width="200px"></asp:Label>
         <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label4" runat="server" Text="Contraseña: " Width="200px"></asp:Label>
         <asp:TextBox ID="TextBox4" textmode="Password" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label5" runat="server" Text="Fecha de nacimiento: " Width="200px"></asp:Label>
         <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label6" runat="server" Text="País: " Width="200px"></asp:Label>
         <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label7" runat="server" Text="E-mail: " Width="200px"></asp:Label>
         <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
         </div>

         <br />
         <br />
         <br />
         <asp:Button ID="Button1" runat="server" Text="Registrar" Width="200px" OnClick="Button1_Click"/>


     </div>
</asp:Content>
