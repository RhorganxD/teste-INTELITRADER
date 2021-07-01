<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="testes3.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            $("#<%=TbName.ClientID%>").mask("SSSSSSSSSSSSSSS");

        });
    </script>

    <div class="text-center">
         <div style="margin:100px"></div>
         <asp:Image runat="server" ImageUrl="/images/intelitrader.svg" />
         <div style="margin:100px"></div>
         <label style="font-family:'Comic Sans MS'">Digite seu primeiro nome, para continuar</label>
         <div style="margin:15px"></div>
         <asp:TextBox runat="server" ClientIDMode="Static" ID="TbName"></asp:TextBox>
         <asp:Button runat="server" OnClick="btn_Click" ID="btn" CssClass="btn-primary" Text="Continuar" />
         <div style="margin:15px"></div>
         <asp:Label runat="server"  Visible="false" ForeColor="Red" id="LbEmptyWarn"/>

         <div style="margin:30px"></div>
    </div>
</asp:Content>
