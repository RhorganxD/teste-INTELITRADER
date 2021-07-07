<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="caixa.aspx.cs" Inherits="testes3.Caixa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script>
        function redirectkeymachine() {
            window.open("https://dojopuzzles.com/problems/caixa-eletronico/", '_blank');

        }
    </script>

    <div class="row m-0 text-center">
        <div style="margin-top:5%;"></div>
        <div style="margin-left:0px; width:50%" class="col col-md-6">
        <h2>Como funciona ?</h2>
        <br />
        O programa irá simular a entrega de notas quando um cliente efetuar um saque em um caixa eletrônico. Os requisitos básicos são os seguintes:

        Entregar o menor número de notas;
        É possível sacar o valor solicitado com as notas disponíveis;
        Saldo do cliente infinito;
        Quantidade de notas infinito (pode-se colocar um valor finito de cédulas para aumentar a dificuldade do problema);
        Notas disponíveis de R$ 100,00; R$ 50,00; R$ 20,00 e R$ 10,00
        Exemplos:

        Valor do Saque: R$ 30,00 – Resultado Esperado: Entregar 1 nota de R$20,00 e 1 nota de R$ 10,00.
        Valor do Saque: R$ 80,00 – Resultado Esperado: Entregar 1 nota de R$50,00 1 nota de R$ 20,00 e 1 nota de R$ 10,00.
        <br />Link do teste<br /><linkbutton onclick="redirectkeymachine()" style="color: dodgerblue; cursor:pointer">https://dojopuzzles.com/problems/caixa-eletronico/</linkbutton>
        <div style="margin:40px"></div>

        <h3>Vamos lá?</h3>    
        <br />
        <asp:Button runat="server" OnClick="Unnamed_Click" Text="Iniciar Teste" CssClass="btn-success" />
     </div>
        
     <div class="col col-md-6">
        <image runat="server" style="width:90%" src="/images/allcoins.png" />
     </div>
   </div>
</asp:Content>
