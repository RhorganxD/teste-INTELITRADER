<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pizzaresult.aspx.cs" Inherits="testes3.pizzaresult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center" style="margin-top: 30px">
        <label style="font-family:'Comic Sans MS'; color:green;">O teste chegou ao fim</label>
        <br />
        <asp:Label runat="server" ID="YourPalate"></asp:Label>

        <div style="margin:25px"></div>

        <asp:Button OnClick="Unnamed_Click" runat="server" text="Refazer teste" CssClass="btn-warning" />
        <br />
        <br />

        <label style="font-weight:bold">Sua nota para cada pizza</label>
        <br />
        <br />
        <asp:GridView HorizontalAlign="Center" ID="GridView1" runat="server" ForeColor="#333333">  
        </asp:GridView>  

        <div style="margin:40px"></div>


        <asp:Label runat="server" Font-Bold="true" Text="Nota de seus colegas"></asp:Label>

        <div style="margin:25px"></div>

        <div class="row m-0">
             <div class="col-md-4">
                 <asp:Label runat="server" Text="Renato"></asp:Label>
                 <asp:GridView HorizontalAlign="Center" ID="GridView2" runat="server" ForeColor="#333333">  
                 </asp:GridView>  
             </div>

            <div class="col-md-4">
                <asp:Label runat="server" Text="Marcelo"></asp:Label>
                <asp:GridView HorizontalAlign="Center" ID="GridView3" runat="server" ForeColor="#333333">  
                </asp:GridView>  
            </div>

            <div class="col-md-4">
                <asp:Label runat="server" Text="Lenon"></asp:Label>
                <asp:GridView HorizontalAlign="Center" ID="GridView4" runat="server" ForeColor="#333333">  
                </asp:GridView>  
            </div>

            <div style="margin-top:40px"></div>

            <div class="col-md-4">
                 <asp:Label runat="server" Text="Renata"></asp:Label>
                 <asp:GridView HorizontalAlign="Center" ID="GridView5" runat="server" ForeColor="#333333">  
                 </asp:GridView>  
             </div>

            <div class="col-md-4">
                <asp:Label runat="server" Text="Washington"></asp:Label>
                <asp:GridView HorizontalAlign="Center" ID="GridView6" runat="server" ForeColor="#333333">  
                </asp:GridView>  
            </div>

            <div class="col-md-4">
                <asp:Label runat="server" Text="Tino"></asp:Label>
                <asp:GridView HorizontalAlign="Center" ID="GridView7" runat="server" ForeColor="#333333">  
                </asp:GridView>  
            </div>

            <div style="margin-top:40px"></div>
            <div class="col-md-4">
                 <asp:Label runat="server" Text="Luca"></asp:Label>
                 <asp:GridView HorizontalAlign="Center" ID="GridView8" runat="server" ForeColor="#333333">  
                 </asp:GridView>  
             </div>

        </div>
    </div>
</asp:Content>
