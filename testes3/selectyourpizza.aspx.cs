using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class selectyourpizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["username"];
            HttpCookie cookiepizza = Request.Cookies["pizzatest"];
            HttpCookie margpizz = Request.Cookies["MargPi"];
            HttpCookie QuaPi = Request.Cookies["QuaPi"];
            HttpCookie EscPiz = Request.Cookies["EscPi"];
            HttpCookie PorPi = Request.Cookies["PorPi"];
            HttpCookie FraPi = Request.Cookies["FraPi"];
            HttpCookie NapPi = Request.Cookies["NapPi"];

            if (name == null)
            {
                Response.Redirect("/home.aspx");
            }

            else if (Request.QueryString["id"] == null)
            {
                if (cookiepizza != null)
                {
                    Response.Redirect("/selectyourpizza.aspx?id=" + cookiepizza["pizzatest"]);
                }
                else
                {
                    if(margpizz != null)
                    {
                        margpizz.Expires.AddSeconds(-1);
                    }
                    else if (QuaPi != null)
                    {
                        QuaPi.Expires.AddSeconds(-1);
                    }
                    else if (EscPiz != null)
                    {
                        EscPiz.Expires.AddSeconds(-1);
                    }
                    else if(PorPi != null)
                    {
                        PorPi.Expires.AddSeconds(-1);
                    }
                    else if (FraPi != null)
                    {
                        FraPi.Expires.AddSeconds(-1);
                    }
                    else if (NapPi != null)
                    {
                        NapPi.Expires.AddSeconds(-1);
                    }
                    Response.Redirect("/selectpizza.aspx");
                }
            }


            try
            {
                int i = Int32.Parse(Request.QueryString["id"]);

                if (i == 0)
                {
                    if (cookiepizza != null)
                    {
                        Response.Redirect("/selectyourpizza.aspx?id=" + cookiepizza["pizzatest"]);
                    }
                    else
                    {
                        Response.Redirect("/selectpizza.aspx");
                    }
                }

                if (i < 8)
                {
                    if (cookiepizza == null)
                    {
                       Response.Redirect("/selectpizza.aspx");
                    }


                    if(cookiepizza["pizzatest"] == "7" && margpizz != null && QuaPi != null && EscPiz != null && PorPi != null && FraPi != null && NapPi != null) 
                    {
                        Response.Redirect("/selectpizza.aspx");
                    }

                    if (i == 1)
                    {
                       retro.Visible = false;
                       saborlb.ImageUrl = "/images/margueritapizza.jpg";
                       lbpizza.Text = "Marguerita" + " ?";
                    }

                    if (i == 2)
                    {   
                        if(margpizz == null | Int32.Parse(cookiepizza["pizzatest"]) < 2)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=1", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                       saborlb.ImageUrl = "/images/queijopizza.jpg";
                       lbpizza.Text = "Quatro queijos" + " ?";
                    }
                    if (i == 3)
                    {
                        if (margpizz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=1", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }
                        else if (QuaPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=2", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        if (Int32.Parse(cookiepizza["pizzatest"]) < 3)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=" + cookiepizza["pizzatest"]);
                        }
                        saborlb.ImageUrl = "/images/escarolapizza.png";
                        lbpizza.Text = "Escarola" + " ?";
                    }
                    if (i == 4)
                    {
                        if (margpizz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=1", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (QuaPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=2", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (EscPiz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=3", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        if (Int32.Parse(cookiepizza["pizzatest"]) < 4)
                        {
                           Response.Redirect("/selectyourpizza.aspx?ID=" + cookiepizza["pizzatest"]);
                        }
                        saborlb.ImageUrl = "/images/portuguesapizza.jpg";
                        lbpizza.Text = "Portuguesa" + " ?";
                    }

                    if (i == 5)
                    {
                        if (margpizz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=1", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (QuaPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=2", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (EscPiz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=3", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (PorPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=4", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        if (Int32.Parse(cookiepizza["pizzatest"]) < 5)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=" + cookiepizza["pizzatest"]);
                        }

                        saborlb.ImageUrl = "/images/frangopizza.jpg";
                        lbpizza.Text = "Frango Catupiry" + " ?";
                    }

                    if (i == 6)
                    {
                        if (margpizz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=1", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }
                            
                        else if (QuaPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=2", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (EscPiz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=3", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (PorPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=4", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (FraPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=5", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }
                            
                        if (Int32.Parse(cookiepizza["pizzatest"]) < 6)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=" + cookiepizza["pizzatest"]);
                        }
                         
                        saborlb.ImageUrl = "/images/napolitanapizza.jpg";
                        lbpizza.Text = "Napolitana" + " ?";
                        sendrate.Text = "Enviar notas";
                    }

                    if (i == 7)
                    {
                        if (Int32.Parse(cookiepizza["pizzatest"]) != 7)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=" + cookiepizza["pizzatest"]);
                        }

                        if (margpizz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=1", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (QuaPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=2", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (EscPiz == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=3", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (PorPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=4", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (FraPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=5", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else if (NapPi == null)
                        {
                            Response.Redirect("/selectyourpizza.aspx?ID=6", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }

                        else 
                        {
                            Response.Redirect("/pizzaresult.aspx", false);
                            Context.ApplicationInstance.CompleteRequest();
                        }
                    }
                }
 
                else
                {
                    if (cookiepizza != null)
                    {
                        Response.Redirect("/selectyourpizza.aspx?id=" + cookiepizza["pizzatest"]);
                    }
                    else
                    {
                        Response.Redirect("/selectpizza.aspx");
                    }
                }
            }

            catch
            {
                Response.Redirect("/selectpizza.aspx");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie cookiepizza = Request.Cookies["pizzatest"];

            if(cookiepizza == null)
            {
                Response.Redirect("/selectpizza.aspx");
            }

            if(Int32.Parse(cookiepizza["pizzatest"]) < 7)
            {

                if (Int32.Parse(Request.QueryString["ID"]) == 1)
                {
                    HttpCookie margpizz = new HttpCookie("MargPi");

                    margpizz.Expires = DateTime.Now.AddDays(2);
                    margpizz.Values.Add("Marguerita", rateresult.Value);
                    Response.Cookies.Add(margpizz);
                 
                }

                if (Int32.Parse(Request.QueryString["ID"]) == 2)
                {
                    HttpCookie quapizz = new HttpCookie("QuaPi");

                    quapizz.Expires = DateTime.Now.AddDays(2);
                    quapizz.Values.Add("QuatroQueijos", rateresult.Value);
                    Response.Cookies.Add(quapizz);
                }

                if (Int32.Parse(Request.QueryString["ID"]) == 3)
                {
                    HttpCookie EscPi = new HttpCookie("EscPi");
                    EscPi.Expires = DateTime.Now.AddDays(2);
                    EscPi.Values.Add("Escarola", rateresult.Value);
                    Response.Cookies.Add(EscPi);
                }

                if (Int32.Parse(Request.QueryString["ID"]) == 4)
                {
                    HttpCookie Por = new HttpCookie("PorPi");
                    Por.Expires = DateTime.Now.AddDays(2);
                    Por.Values.Add("Portuguesa", rateresult.Value);
                    Response.Cookies.Add(Por);
                }

                if (Int32.Parse(Request.QueryString["ID"]) == 5)
                {
                    HttpCookie Fra = new HttpCookie("FraPi");
                    Fra.Expires = DateTime.Now.AddDays(2);    
                    Fra.Values.Add("FrangoCatupiry", rateresult.Value);
                    Response.Cookies.Add(Fra);
                }

                if (Int32.Parse(Request.QueryString["ID"]) == 6)
                {
                    HttpCookie Nap = new HttpCookie("NapPi");
                    Nap.Expires = DateTime.Now.AddDays(2);
                    Nap.Values.Add("Napolitana", rateresult.Value);
                    Response.Cookies.Add(Nap);
                }

                int cookieloop = Int32.Parse(Request.QueryString["ID"]) + 1;

                cookiepizza = new HttpCookie("pizzatest");
                cookiepizza.Expires = DateTime.Now.AddDays(2);
                cookiepizza.Values.Add("pizzatest", cookieloop.ToString());
                Response.Cookies.Add(cookiepizza);

                Response.Redirect("/selectyourpizza.aspx?ID=" + cookiepizza["pizzatest"]);
            }

            else if(Int32.Parse(cookiepizza["pizzatest"]) == 7)
            {
                if ( Request.QueryString["ID"] == "1")
                {
                    HttpCookie margpizz = new HttpCookie("MargPi");
                    margpizz.Expires = DateTime.Now.AddDays(2);
                    margpizz.Values.Add("Marguerita", rateresult.Value);
                    Response.Cookies.Add(margpizz);
                    Response.Redirect("/pizzaresult.aspx");
                }

                else if (Request.QueryString["ID"] == "2")
                {
                    HttpCookie quapizz = new HttpCookie("QuaPi");
                    quapizz.Expires = DateTime.Now.AddDays(2);
                    quapizz.Values.Add("QuatroQueijos", rateresult.Value);
                    Response.Cookies.Add(quapizz);
                    Response.Redirect("/pizzaresult.aspx");
                }

                else if (Request.QueryString["ID"] == "3")
                {
                    HttpCookie EscPi = new HttpCookie("EscPi");
                    EscPi.Expires = DateTime.Now.AddDays(2);
                    EscPi.Values.Add("Escarola", rateresult.Value);
                    Response.Cookies.Add(EscPi);
                    Response.Redirect("/pizzaresult.aspx");
                }

                else if (Request.QueryString["ID"] == "4")
                {
                    HttpCookie Por = new HttpCookie("PorPi");
                    Por.Expires = DateTime.Now.AddDays(2);
                    Por.Values.Add("Portuguesa", rateresult.Value);
                    Response.Cookies.Add(Por);
                    Response.Redirect("/pizzaresult.aspx");
                }

                else if (Request.QueryString["ID"] == "5")
                {
                    HttpCookie Fra = new HttpCookie("FraPi");
                    Fra.Expires = DateTime.Now.AddDays(2);
                    Fra.Values.Add("FrangoCatupiry", rateresult.Value);
                    Response.Cookies.Add(Fra);
                    Response.Redirect("/pizzaresult.aspx");
                }

                else if (Request.QueryString["ID"] == "6")
                {
                    HttpCookie Nap = new HttpCookie("NapPi");
                    Nap.Expires = DateTime.Now.AddDays(2);
                    Nap.Values.Add("Napolitana", rateresult.Value);
                    Response.Cookies.Add(Nap);
                    Response.Redirect("/pizzaresult.aspx");
                }

                else
                {
                    Response.Redirect("/pizzaresult.aspx");
                }
            }
        }

        protected void retro_Click(object sender, ImageClickEventArgs e)
        {
            HttpCookie cookiepizza = Request.Cookies["pizzatest"];

            if (cookiepizza == null)
            {
                Response.Redirect("/selectpizza.aspx");
            }

            else
            {
                int redirectcorrect = Int32.Parse(Request.QueryString["ID"]) - 1;
                Response.Redirect("/selectyourpizza.aspx?ID=" + redirectcorrect.ToString());
               
            }
        }
    }
}