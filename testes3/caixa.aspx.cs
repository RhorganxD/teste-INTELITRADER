using System;
using System.Web;

namespace testes3
{
    public partial class Caixa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["username"];
            HttpCookie mymoney = Request.Cookies["mymoney"];

            if (name == null)
            {
                Response.Redirect("/home.aspx");
            }

            if(mymoney != null)
            {
                Response.Redirect("/caixatest.aspx");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("/caixatest.aspx");
        }
    }
}