using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["username"];

            if(name != null)
            {
                HelloUser.Text = "Olá, " + name["username"].ToString() + " =)";

            }

            else
            {
                homelb.Visible = false;
                HelloUser.Visible = false;
                LeftUser.Visible = false;
                selectpizza.Visible = false;
                caixa.Visible = false;
                jokenpo.Visible = false;
                menu.Visible = false;
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["username"];

            if (name == null)
            {
                Response.Redirect("/home.aspx");
            }

            else
            {
                Response.Redirect("/selectcategory.aspx");
            }
        }

        protected void LeftUser_Click(object sender, EventArgs e)
        {
            HttpCookie cookieuser = new HttpCookie("username");
            HttpCookie margpizz = new HttpCookie("MargPi");
            HttpCookie quapizz = new HttpCookie("QuaPi");
            HttpCookie EscPi = new HttpCookie("EscPi");
            HttpCookie Por = new HttpCookie("PorPi");
            HttpCookie Fra = new HttpCookie("FraPi");
            HttpCookie Nap = new HttpCookie("NapPi");
            HttpCookie cookiepizza = new HttpCookie("pizzatest");
            HttpCookie mymon = new HttpCookie("mymoney");

            if(cookiepizza != null)
            {
                cookiepizza.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(cookiepizza);
            }
            if(margpizz != null)
            {
                margpizz.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(margpizz);
            }
            if(quapizz != null)
            {
                quapizz.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(quapizz);
            }
            if(EscPi != null)
            {
                EscPi.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(EscPi);
            }
            if(Por != null)
            {
                Por.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(Por);
            }
            if(Fra != null)
            {
                Fra.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(Fra);
            }
            if(Nap != null) 
            {
                Nap.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(Nap);
            }

            if(mymon != null)
            {
                mymon.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(mymon);
            }

            cookieuser.Expires = DateTime.Now.AddSeconds(-1);
            Response.Cookies.Add(cookieuser);

            Response.Redirect("/home.aspx");
        }

        protected void selectpizza_Click(object sender, EventArgs e)
        {
            Response.Redirect("/selectpizza.aspx");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/caixa.aspx");
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            Response.Redirect("/jokenpo.aspx");
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            HttpCookie cookieuser = new HttpCookie("username");
            HttpCookie margpizz = new HttpCookie("MargPi");
            HttpCookie quapizz = new HttpCookie("QuaPi");
            HttpCookie EscPi = new HttpCookie("EscPi");
            HttpCookie Por = new HttpCookie("PorPi");
            HttpCookie Fra = new HttpCookie("FraPi");
            HttpCookie Nap = new HttpCookie("NapPi");
            HttpCookie cookiepizza = new HttpCookie("pizzatest");
            HttpCookie mymon = new HttpCookie("mymoney");

            if (cookiepizza != null)
            {
                cookiepizza.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(cookiepizza);
            }
            if (margpizz != null)
            {
                margpizz.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(margpizz);
            }
            if (quapizz != null)
            {
                quapizz.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(quapizz);
            }
            if (EscPi != null)
            {
                EscPi.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(EscPi);
            }
            if (Por != null)
            {
                Por.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(Por);
            }
            if (Fra != null)
            {
                Fra.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(Fra);
            }
            if (Nap != null)
            {
                Nap.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(Nap);
            }

            if (mymon != null)
            {
                mymon.Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies.Add(mymon);
            }

            cookieuser.Expires = DateTime.Now.AddSeconds(-1);
            Response.Cookies.Add(cookieuser);

            Response.Redirect("/home.aspx");
        }
    }
}