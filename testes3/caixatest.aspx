<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="caixatest.aspx.cs" Inherits="testes3.caixatest" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        $(function () {
            $("#<%=withdrawlbtn.ClientID%>").mask("99999");
            $("#<%=deposit.ClientID%>").mask("99999");
        });

        $(document).keypress(
            function (event) {
                if (event.which == '13') {
                    event.preventDefault();
                }
            });


        function divopen() {
            var d1 = document.getElementById("div");
            var d2 = document.getElementById("div1");

            if (d1.style.display == "none") {
                d1.style.display = "block";
                d2.style.display = "none";
            }

            else {
                d1.style.display = "none";
                d2.style.display = "none";
            }
        }

        function div1open() {
            var d1 = document.getElementById("div1");
            var d2 = document.getElementById("div");

            if (d1.style.display == "none") {
                d1.style.display = "block";
                d2.style.display = "none";
            }

            else {
                d1.style.display = "none";
                d2.style.display = "none";
            }
        }
    </script>

    <div id="noselec" class="text-center" runat="server">
        <div style="margin:10%"></div>

        <asp:Label Font-Bold="true" Font-Names="Comic Sans MS" Font-Size="Larger" runat="server" Text="Você possui quantos R$ ?"></asp:Label>
        <br />
        <asp:TextBox ID="TbMoney" TextMode="Number" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" OnClick="Unnamed_Click" Text="Enviar" CssClass="btn-success"/>
    </div>

    
    <div id="Div1" class="text-center" runat="server">
        <div style="margin:3%"></div>
        <h2>Caixa Eletronico Virtual</h2>
        <br />
        <asp:Label runat="server" ID="errors" ForeColor="Red" Font-Bold="true"></asp:Label>
        <br />
        <div style="margin:3%"></div>
        <br />
        <h6 runat="server" id="qtyced">Cédulas disponiveis: R$ 100.00, R$ 50.00, R$ 20.00 e R$ 10.00 
        </h6>
        <br />
        <br />
        <div class="row m-0">
            <div class="col-md-6">
                <button runat="server" onclick="divopen()" type="button" class="btn-success">Retirar dinheiro</button>
            </div>

            <br />
            <br />

            <div class="col-md-6">
                <button runat="server" onclick="div1open()" type="button" class="btn-danger">Depositar dinheiro</button>
            </div>
        </div>

        <br />
        <div style="display:none" id="div">
            <div style="margin:30px"></div>
            <label>Quantos R$ você deseja retirar ?</label>
            <br />
            <br />
            <asp:TextBox ID="withdrawlbtn" runat="server"></asp:TextBox>
            <asp:Button runat="server" ID="width" OnClick="Unnamed_Click1" Text="Retirar" CssClass="btn-success"/>
        </div>
        
        <div style="display:none" id="div1">
            <div style="margin:30px"></div>
            <label>Quantos R$ você deseja depositar ?</label>
            <br />
            <br />
            <asp:TextBox ID="deposit" runat="server"></asp:TextBox>
            <asp:Button runat="server" OnClick="Unnamed_Click2" Text="Depositar" CssClass="btn-danger"/>
        </div>

        <br />
        <asp:Label runat="server" Font-Bold="true" ID="Ced100"></asp:Label>
        <br />
        <asp:Label runat="server" Font-Bold="true" ID="Ced50"></asp:Label>
        <br />
        <asp:Label runat="server" Font-Bold="true" ID="Ced20"></asp:Label>
        <br />
        <asp:Label runat="server" Font-Bold="true" ID="Ced10"></asp:Label>

        <div style="margin:50px"></div>

        <label style="font-weight:bold;">Saldo atual</label>
        <br />
        
        <asp:Label runat="server" Font-Bold="true" ID="MyMoney"></asp:Label>

        <div style="margin:25px"></div>
    </div>
</asp:Content>
