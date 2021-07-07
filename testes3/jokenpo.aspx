<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="jokenpo.aspx.cs" Inherits="testes3.jokenpo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <script>
        function redirectjokenpo() {
            window.open("https://dojopuzzles.com/problems/jokenpo/", '_blank');

        }
    </script>

    <div class="row m-0 text-center">
        <div style="margin-top:5%;"></div>
        <div style="margin-left:0px; width:50%" class="col col-md-6">
        <h2>Como funciona ?</h2>
        <br />
        Jokenpo é uma brincadeira japonesa, onde dois jogadores escolhem um dentre três possíveis itens: Pedra, Papel ou Tesoura.

        As regras são as seguintes:

        Pedra empata com Pedra e ganha de Tesoura
        Tesoura empata com Tesoura e ganha de Papel
        Papel empata com Papel e ganha de Pedra
        <br />
        <br />Link do teste<br /><linkbutton onclick="redirectjokenpo()" style="color: dodgerblue; cursor:pointer">https://dojopuzzles.com/problems/jokenpo/</linkbutton>
        <div style="margin:40px"></div>

        <h3>Vamos lá?</h3>    
        <br />
        <asp:Button runat="server" OnClick="Unnamed_Click" Text="Jogar Agora" CssClass="btn-success" />
     </div>
        
     <div class="col col-md-6">
        <image runat="server" style="width:90%" src="/images/jokenpo.jpg" />
     </div>
   </div>
</asp:Content>
