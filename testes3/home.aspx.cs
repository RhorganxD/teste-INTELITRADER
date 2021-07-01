using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["username"];

            if (name != null)
            {
                Response.Redirect("/selectcategory.aspx");
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {

            HttpCookie name = Request.Cookies["username"];

            if (TbName.Text.Length < 3)
            {
                LbEmptyWarn.Text = "Pedimos que digite um nome válido";
                LbEmptyWarn.Visible = true;
                return;
            }

            else if (TbName.Text == "")
            {

                LbEmptyWarn.Text = "Por favor digite seu nome acima";
                LbEmptyWarn.Visible = true;
            }




            /* Essa condição é uma camada de segurança importante, para o usuário não fazer mais de um post no aplicativo
                  usando o mesmo botão, porém em outra aba, caso queira entender isso na prática, basta abrir duas abas no navegador
                simultaneamente na mesma página /home.aspx, e colocar um " Primeiro Nome " diferente do outro, e clicar no botão " continuar ", se remover a condição
                o usuário poderá trocar o nome, isso seria um bug no sistema, onde se estivesse sendo usado um banco de dados por exemplo,
                poderia comprometer completamente algo do mesmo, dependendo do que for.*/

            else if (name != null)
            {
                Response.Redirect("/selectcategory.aspx");
            }

            else
            {
                HttpCookie cookieuser = new HttpCookie("username");
                cookieuser.Expires = DateTime.Now.AddDays(2);
                cookieuser.Values.Add("username", TbName.Text);
                Response.Cookies.Add(cookieuser);
                Response.Redirect("/selectcategory.aspx");
            }    
        }  
    }   
}
