<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="selectcategory.aspx.cs" Inherits="testes3.selectcategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
            <div style="margin:70px"></div>
            <asp:Label runat="server" Font-Bold="true" Text="Selecione um teste para continuar" ForeColor="Black" Font-Names="Arial" Font-Size="X-Large"></asp:Label>

            <div style="margin:130px"></div>

            <div class="row m-0">
                <div class="col-md-4">
                    <asp:LinkButton runat="server" Font-Underline="false" OnClick="Unnamed_Click" class="cardcss">
                        <div style="padding-top:35px">
                           <p5 style="font-size:20px;font-weight:bold; color:black;font-family:'Comic Sans MS'">ESCOLHENDO PIZZA</p5>
                        </div>  
                    </asp:LinkButton>
                </div>

                <div class="col-md-4">
                    <asp:LinkButton runat="server" OnClick="Unnamed_Click1" Font-Underline="false" class="cardcss1">
                        <div style="padding-top:35px">
                           <p5 style="font-size:20px;font-weight:bold; color:black;font-family:'Comic Sans MS'">CAIXA ELETRÔNICO</p5>
                        </div>  
                    </asp:LinkButton>
                </div>

                <div class="col-md-4">
                    <asp:LinkButton runat="server" OnClick="Unnamed_Click2" Font-Underline="false" class="cardcss2">
                        <div style="padding-top:35px">
                           <p5 style="font-size:20px;font-weight:bold; color:black;font-family:'Comic Sans MS'">PEDRA, PAPEL OU TESOURA</p5>
                        </div>  
                    </asp:LinkButton>
                </div>
            </div>
        </div>
</asp:Content>
