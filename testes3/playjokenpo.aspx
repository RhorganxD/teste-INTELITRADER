<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="playjokenpo.aspx.cs" Inherits="testes3.playjokenpo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        $(function () {
            $("#<%=play1tb.ClientID%>").mask("9");
            $("#<%=play2tb.ClientID%>").mask("9");
        });

        $(document).keypress(
            function (event) {
                if (event.which == '13') {
                    event.preventDefault();
                }
            });

        function play1click() {
            if ($("#<%=play1tb.ClientID%>").val() == "") {
                alert("Jogador 1 deve digitar um número, de 1 a 3");
            }

            else {

                if ($("#<%=play1tb.ClientID%>").val() != "1" && $("#<%=play1tb.ClientID%>").val() != "2" && $("#<%=play1tb.ClientID%>").val() != "3") {
                    alert("Jogador 1 deve digitar um número, de 1 a 3");
                }

                else {
                    var play1 = document.getElementById("play1");
                    var play2 = document.getElementById("play2");
                    play1.style.display = "none";

                    if (play2.style.display == "none") {
                        var verify = document.getElementById("verify");
                        verify.style.display = "block";
                    }
                }
            }
        }
    
        function play2click() {
            if ($("#<%=play2tb.ClientID%>").val() == "") {
                alert("Jogador 2 deve digitar um número, de 1 a 3");
            }

            else {
                if ($("#<%=play2tb.ClientID%>").val() != "1" && $("#<%=play2tb.ClientID%>").val() != "2" && $("#<%=play2tb.ClientID%>").val() != "3") {
                    alert("Jogador 2 deve digitar um número, de 1 a 3");
                }

                else {
                    var play1 = document.getElementById("play2");
                    var play2 = document.getElementById("play1");
                    play1.style.display = "none";

                    if (play2.style.display == "none") {
                        var verify = document.getElementById("verify");
                        verify.style.display = "block";
                    }
                }
            }
        }
    </script>

    <br />
    <br />

    <div class="text-center">

        <div runat="server" visible="false" id="Div1">
            <asp:Label ID="lbempate" runat="server" Font-Size="Larger" Font-Bold="true" ForeColor="DarkGoldenrod"></asp:Label>
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" Font-Bold="true" ForeColor="DarkGreen"></asp:Label>
            <div style="margin:50px"></div>
        </div>

        <h3>Digite 1 para PEDRA</h3>
        <h3>Digite 2 para PAPEL</h3>
        <h3>Digite 3 para TESOURA</h3>
    </div>

    <br />
    <br />

    <div class="row m-0 text-center">
        <div style="height:100%;width:45%;background-color:lightgray" class="col-md-4">
            <div style="margin-top:20%"></div>
            <div class="text-center">
                <asp:Label runat="server" ForeColor="Red" ID="DangerPlay1"></asp:Label>
                <br />
                <h3>Jogador 1</h3>
                <br />
                <h3>Digite aqui</h3>
                <br />
                <asp:TextBox TextMode="Password" width="50%" ID="play1tb" runat="server" placeholder="Digite aqui"></asp:TextBox>    
                <br />
                <br />
                <label style="color:red; display:none">Digite um número correspondente, a Pedra, Papel ou Tesoura</label>
                <br />
                <button type="button" id="play1" onclick="play1click()" class="btn-success">Jogar</button>
            </div>

            <br />
            <br />
        </div>
            
       <div class="col-md-4" style="width:10%;">
           <div style="margin-top:100%"></div>
            <h1>X</h1>
       </div>


        <div style="height:100%; width:45%; background-color:antiquewhite" class="col-md-4">
            <div style="margin-top:20%"></div>
            <div class="text-center">
                <h3>Jogador 2</h3>
                <br />
                <h3>Digite aqui</h3>
                <br />
                <asp:TextBox TextMode="Password" ID="play2tb" runat="server" width="50%" placeholder="Digite aqui"></asp:TextBox>
                <br />
                <label style="color:red; display:none">Digite um número correspondente, a Pedra, Papel ou Tesoura</label>
                <br />
                <button type="button" id="play2" onclick="play2click()" class="btn-success">Jogar</button>
            </div>

             <br /><br /><br />
        </div>
        
    </div>

    <div style="margin:15px"></div>
    
     <br />
    <div class="text-center" style="display:none" id="verify">
         <asp:Button runat="server" OnClick="verifywin_Click" ID="verifywin" style="margin-left: auto;margin-right: auto;" Text="Verificar ganhador" CssClass="btn-success"/>
    </div>
    <br /><br>
</asp:Content>
