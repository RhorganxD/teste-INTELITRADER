<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="selectyourpizza.aspx.cs" Inherits="testes3.selectyourpizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:HiddenField runat="server" Value="3" ClientIDMode="Static" ID="rateresult" />
    <div style="margin:5%"></div>  

    <div id="text" class="text-center">
        <asp:Label runat="server" Text="O que voce acha da pizza de: " Font-Size="X-Large"></asp:Label>
        <asp:Label runat="server" Font-Bold="true" ID="lbpizza" Font-Size="X-Large"></asp:Label>
        <br />

        <div style="margin:30px"></div>
        <asp:Image runat="server" Width="300" Height="300" ID="saborlb" />

        <div style="margin:25px"></div>

        <h3>SUA NOTA</h3>
        <asp:Label ID="lb" runat="server"></asp:Label>
        <br />

	    <div class="emoji">😑</div>
	       <input id="inputx" type="range" min="1" max="5" step="0">

        <br />
        <div style="margin:25px"></div>
        <asp:Button runat="server" Text="Continuar" ID="sendrate" OnClick="Unnamed_Click" CssClass="btn-success"/>
        <br />
        <div style="margin:2%"></div>
        <asp:ImageButton runat="server" id="retro" OnClick="retro_Click" ImageUrl="/images/backpng.png" Width="50" Height="50" />

    </div>
   
        

    <div style="margin: 20px;"></div>

      <script>
          var emojis = ['', '😠', '😦', '😑', '😀', '😍'];
          $("input").mousemove(function () {
              var i = $("#inputx").val();
              $(".emoji").html(emojis[i]);
              $("#rateresult").val(i);
          });
      </script>
</asp:Content>
