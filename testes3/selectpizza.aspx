<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="selectpizza.aspx.cs" Inherits="testes3.selectpizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function redirectpizzatest() {
            window.open("https://dojopuzzles.com/problems/escolhendo-uma-pizza/", '_blank');

        }
    </script>

       <div class="row m-0 text-center">
            <div style="margin-top:5%;"></div>
            <div style="margin-left:0px; width:50%" class="col col-md-6">
               <h2>Como funciona ?</h2>
                <br />
                <p style="font-weight:bold">Você trabalha em uma empresa de desenvolvimento, e precisa selecionar os sabores de pizza, das quais você mais gosta, para comparar com os sabores de seus colegas.</p>
                <p style="font-weight:bold">Seu trabalho tem 8 pessoas contando com você ( Voce, Renato, Marcelo, Lenon, Renata, Washington, Tino e Luca )</p><br />
                Link do teste<br /><linkbutton onclick="redirectpizzatest()" style="color: dodgerblue; cursor:pointer">https://dojopuzzles.com/problems/escolhendo-uma-pizza/</linkbutton>
                <div style="margin:40px"></div>

                <h3>Vamos lá?</h3>    
                <br />
                <asp:Button runat="server" OnClick="Unnamed_Click" Text="Iniciar teste" CssClass="btn-success" />
            </div>
        
            <div class="col col-md-6">
                <image runat="server" style="width:90%" src="/images/eatingpizza.jpg" />
            </div>
        </div>
</asp:Content>
