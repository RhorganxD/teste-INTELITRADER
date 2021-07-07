using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class selectpizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie pizza = Request.Cookies["pizzatest"];
            HttpCookie name = Request.Cookies["username"];

            if(name == null)
            {
                Response.Redirect("/home.aspx");
            }

            if (pizza != null && Int32.Parse(pizza["pizzatest"]) < 7)
            {
                Response.Redirect("/selectyourpizza.aspx?id=" + pizza["pizzatest"]);
            }

            else if(pizza != null && Convert.ToInt32(pizza["pizzatest"]) == 7)
            {
                Response.Redirect("/pizzaresult.aspx");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie pizza = Request.Cookies["pizzatest"];


            if (pizza != null)
            {
                Response.Redirect("/selectyourpizza.aspx?id=" + pizza["pizzatest"]);
            }

            else
            {
                HttpCookie margpizz = new HttpCookie("MargPi");
                HttpCookie QuaPi = new HttpCookie("QuaPi");
                HttpCookie EscPiz = new HttpCookie("EscPi");
                HttpCookie PorPi = new HttpCookie("PorPi");
                HttpCookie FraPi = new HttpCookie("FraPi");
                HttpCookie NapPi = new HttpCookie("NapPi");

                if (margpizz != null)
                {
                    margpizz.Expires = DateTime.Now.AddSeconds(-1);
                    Response.Cookies.Add(margpizz);
                }
                if (QuaPi != null)
                {
                    QuaPi.Expires = DateTime.Now.AddSeconds(-1);
                    Response.Cookies.Add(QuaPi);
                }
                if (EscPiz != null)
                {
                    EscPiz.Expires = DateTime.Now.AddSeconds(-1);
                    Response.Cookies.Add(EscPiz);
                }
                if (PorPi != null)
                {
                    PorPi.Expires = DateTime.Now.AddSeconds(-1);
                    Response.Cookies.Add(PorPi);
                }
                if (FraPi != null)
                {
                    FraPi.Expires = DateTime.Now.AddSeconds(-1);
                    Response.Cookies.Add(FraPi);
                }
                if (NapPi != null)
                {
                    NapPi.Expires = DateTime.Now.AddSeconds(-1);
                    Response.Cookies.Add(NapPi);
                }

                HttpCookie cookiepizza = new HttpCookie("pizzatest");
                cookiepizza.Expires = DateTime.Now.AddDays(2);
                cookiepizza.Values.Add("pizzatest", "1");
                
                Response.Cookies.Add(cookiepizza);

                Response.Redirect("/selectyourpizza.aspx?id=1");
            }
        }
    }
}