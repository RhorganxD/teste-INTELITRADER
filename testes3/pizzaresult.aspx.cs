using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class pizzaresult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie pizzatest = Request.Cookies["pizzatest"];

            HttpCookie margpizz = Request.Cookies["MargPi"];
            HttpCookie QuaPi = Request.Cookies["QuaPi"];
            HttpCookie EscPiz = Request.Cookies["EscPi"];
            HttpCookie PorPi = Request.Cookies["PorPi"];
            HttpCookie FraPi = Request.Cookies["FraPi"];
            HttpCookie NapPi = Request.Cookies["NapPi"];

            if (pizzatest == null)
            {
                Response.Redirect("/selectpizza.aspx");
            }

            else if (pizzatest["pizzatest"] != "7")
            {
                Response.Redirect("/selectyourpizza.aspx?id=" + pizzatest["pizzatest"]);
            }

            else if (margpizz == null)
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
                Dictionary<string, int> Renato = new Dictionary<string, int>();
                Renato.Add("Marguerita", 4);
                Renato.Add("Quatro queijos", 5);
                Renato.Add("Escarola", 4);
                Renato.Add("Portuguesa", 5);
                Renato.Add("Frango Catupiry", 4);
                Renato.Add("Napolitana", 3);

                Dictionary<string, int> Marcelo = new Dictionary<string, int>();
                Marcelo.Add("Marguerita", 2);
                Marcelo.Add("Quatro queijos", 2);
                Marcelo.Add("Escarola", 1);
                Marcelo.Add("Portuguesa", 3);
                Marcelo.Add("Frango Catupiry", 5);
                Marcelo.Add("Napolitana", 2);

                Dictionary<string, int> Lenon = new Dictionary<string, int>();
                Lenon.Add("Marguerita", 4);
                Lenon.Add("Quatro queijos", 5);
                Lenon.Add("Escarola", 2);
                Lenon.Add("Portuguesa", 1);
                Lenon.Add("Frango Catupiry", 1);
                Lenon.Add("Napolitana", 3);

                Dictionary<string, int> Renata = new Dictionary<string, int>();
                Renata.Add("Marguerita", 4);
                Renata.Add("Quatro queijos", 5);
                Renata.Add("Escarola", 1);
                Renata.Add("Portuguesa", 1);
                Renata.Add("Frango Catupiry", 3);
                Renata.Add("Napolitana", 4);

                Dictionary<string, int> Washington = new Dictionary<string, int>();
                Washington.Add("Marguerita", 1);
                Washington.Add("Quatro queijos", 1);
                Washington.Add("Escarola", 2);
                Washington.Add("Portuguesa", 3);
                Washington.Add("Frango Catupiry", 4);
                Washington.Add("Napolitana", 3);

                Dictionary<string, int> Tino = new Dictionary<string, int>();
                Tino.Add("Marguerita", 1);
                Tino.Add("Quatro queijos", 5);
                Tino.Add("Escarola", 1);
                Tino.Add("Portuguesa", 4);
                Tino.Add("Frango Catupiry", 3);
                Tino.Add("Napolitana", 2);

                Dictionary<string, int> Luca = new Dictionary<string, int>();
                Luca.Add("Marguerita", 5);
                Luca.Add("Quatro queijos", 4);
                Luca.Add("Escarola", 3);
                Luca.Add("Portuguesa", 4);
                Luca.Add("Frango Catupiry", 3);
                Luca.Add("Napolitana", 2);

                int MargueritaNota = Convert.ToInt32(margpizz["Marguerita"]);
                int QueijoNota = Convert.ToInt32(QuaPi["QuatroQueijos"]);
                int EscarolaNota = Convert.ToInt32(EscPiz["Escarola"]);
                int PortuguesaNota = Convert.ToInt32(PorPi["Portuguesa"]);
                int FrangoNota = Convert.ToInt32(FraPi["FrangoCatupiry"]);
                int NapolitanaNota = Convert.ToInt32(NapPi["Napolitana"]);

                int MargRen = MargueritaNota - Renato["Marguerita"];
                int QueiRen = QueijoNota - Renato["Quatro queijos"];
                int EscRen = EscarolaNota - Renato["Escarola"];
                int PortRen = PortuguesaNota - Renato["Portuguesa"];
                int FraRen = FrangoNota - Renato["Frango Catupiry"];
                int NapRen = NapolitanaNota - Renato["Napolitana"];

                /* Essas condições < 0 é basicamente para pegar as contas que deram negativas e transforma-lás em positivas
                por meio da clássica regra de matemática -- = +, o motivo disso é para o cálculo dar certo, e descobrirmos com qual pessoa,
               seu paladar combina mais, infelizmente para esse cálculo dar certo, teria que verificar número por numero, pois se não se sua nota por exemplo, fosse 2, e a do Bot
                fosse 4, o código já teria um problema ao efetuar o cálculo, pois a resposta seria -2*/

                if (MargRen < 0)
                {
                    MargRen = -MargRen;
                }
                if (QueiRen < 0)
                {
                    QueiRen = -QueiRen;
                }
                if (EscRen < 0)
                {
                    EscRen = -EscRen;
                }
                if (PortRen < 0)
                {
                    PortRen = -PortRen;
                }
                if (FraRen < 0)
                {
                    FraRen = -FraRen;
                }
                if (NapRen < 0)
                {
                    NapRen = -NapRen;
                }

                int NotaRen = MargRen + QueiRen + EscRen + PortRen + FraRen + NapRen;

                int MargMarcelo = MargueritaNota - Marcelo["Marguerita"];
                int QueiMarcelo = QueijoNota - Marcelo["Quatro queijos"];
                int EscaMarcelo = EscarolaNota - Marcelo["Escarola"];
                int PortMarcelo = PortuguesaNota - Marcelo["Portuguesa"];
                int FranMarcelo = FrangoNota - Marcelo["Frango Catupiry"];
                int NapoMarcelo = NapolitanaNota - Marcelo["Napolitana"];

                if (MargMarcelo < 0)
                {
                    MargMarcelo = -MargMarcelo;
                }
                if (QueiMarcelo < 0)
                {
                    QueiMarcelo = -QueiMarcelo;
                }
                if (EscaMarcelo < 0)
                {
                    EscaMarcelo = -EscaMarcelo;
                }
                if (PortMarcelo < 0)
                {
                    PortMarcelo = -PortMarcelo;
                }
                if (FranMarcelo < 0)
                {
                    FranMarcelo = -FranMarcelo;
                }
                if (NapoMarcelo < 0)
                {
                    NapoMarcelo = -NapoMarcelo;
                }

                int NotaMar = MargMarcelo + QueiMarcelo + EscaMarcelo + PortMarcelo + FranMarcelo + NapoMarcelo;

                int MargLenon = MargueritaNota - Lenon["Marguerita"];
                int QueiLenon = QueijoNota - Lenon["Quatro queijos"];
                int EscaLenon = EscarolaNota - Lenon["Escarola"];
                int PortLenon = PortuguesaNota - Lenon["Portuguesa"];
                int FranLenon = FrangoNota - Lenon["Frango Catupiry"];
                int NapoLenon = NapolitanaNota - Lenon["Napolitana"];

                if (MargLenon < 0)
                {
                    MargLenon = -MargLenon;
                }
                if (QueiLenon < 0)
                {
                    QueiLenon = -QueiLenon;
                }
                if (EscaLenon < 0)
                {
                    EscaLenon = -EscaLenon;
                }
                if (PortLenon < 0)
                {
                    PortLenon = -PortLenon;
                }
                if (FranLenon < 0)
                {
                    FranLenon = -FranLenon;
                }
                if (NapoLenon < 0)
                {
                    NapoLenon = -NapoLenon;
                }

                int NotaLen = MargLenon + QueiLenon + EscaLenon + PortLenon + FranLenon + NapoLenon;

                int MargRena = MargueritaNota - Renata["Marguerita"];
                int QueiRena = QueijoNota - Renata["Quatro queijos"];
                int EscRena = EscarolaNota - Renata["Escarola"];
                int PortRena = PortuguesaNota - Renata["Portuguesa"];
                int FraRena = FrangoNota - Renata["Frango Catupiry"];
                int NapRena = NapolitanaNota - Renata["Napolitana"];

                if (MargRena < 0)
                {
                    MargRena = -MargRena;
                }
                if (QueiRena < 0)
                {
                    QueiRena = -QueiRena;
                }
                if (EscRena < 0)
                {
                    EscRena = -EscRena;
                }
                if (PortRena < 0)
                {
                    PortRena = -PortRena;
                }
                if (FraRena < 0)
                {
                    FraRena = -FraRena;
                }
                if (NapRena < 0)
                {
                    NapRena = -NapRena;
                }

                int NotaRena = MargRena + QueiRena + EscRena + PortRena + FraRena + NapRena;

                int MargWash = MargueritaNota - Washington["Marguerita"];
                int QueiWash = QueijoNota - Washington["Quatro queijos"];
                int EscWash = EscarolaNota - Washington["Escarola"];
                int PortWash = PortuguesaNota - Washington["Portuguesa"];
                int FraWash = FrangoNota - Washington["Frango Catupiry"];
                int NapWash = NapolitanaNota - Washington["Napolitana"];

                if (MargWash < 0)
                {
                    MargWash = -MargWash;
                }
                if (QueiWash < 0)
                {
                    QueiWash = -QueiWash;
                }
                if (EscWash < 0)
                {
                    EscWash = -EscWash;
                }
                if (PortWash < 0)
                {
                    PortWash = -PortWash;
                }
                if (FraWash < 0)
                {
                    FraWash = -FraWash;
                }
                if (NapWash < 0)
                {
                    NapWash = -NapWash;
                }

                int NotaWash = MargWash + QueiWash + EscWash + PortWash + FraWash + NapWash;

                int MargTino = MargueritaNota - Tino["Marguerita"];
                int QueiTino = QueijoNota - Tino["Quatro queijos"];
                int EscTino = EscarolaNota - Tino["Escarola"];
                int PortTino = PortuguesaNota - Tino["Portuguesa"];
                int FraTino = FrangoNota - Tino["Frango Catupiry"];
                int NapTino = NapolitanaNota - Tino["Napolitana"];

                if (MargTino < 0)
                {
                    MargTino = -MargTino;
                }
                if (QueiTino < 0)
                {
                    QueiTino = -QueiTino;
                }
                if (EscTino < 0)
                {
                    EscTino = -EscTino;
                }
                if (PortTino < 0)
                {
                    PortTino = -PortTino;
                }
                if (FraTino < 0)
                {
                    FraTino = -FraTino;
                }
                if (NapTino < 0)
                {
                    NapTino = -NapTino;
                }

                int NotaTino = MargTino + QueiTino + EscTino + PortTino + FraTino + NapTino;

                int MargLuca = MargueritaNota - Luca["Marguerita"];
                int QueiLuca = QueijoNota - Luca["Quatro queijos"];
                int EscLuca = EscarolaNota - Luca["Escarola"];
                int PortLuca = PortuguesaNota - Luca["Portuguesa"];
                int FraLuca = FrangoNota - Luca["Frango Catupiry"];
                int NapLuca = NapolitanaNota - Luca["Napolitana"];

                if (MargLuca < 0)
                {
                    MargLuca = -MargLuca;
                }
                if (QueiLuca < 0)
                {
                    QueiLuca = -QueiLuca;
                }
                if (EscLuca < 0)
                {
                    EscLuca = -EscLuca;
                }
                if (PortLuca < 0)
                {
                    PortLuca = -PortLuca;
                }
                if (FraLuca < 0)
                {
                    FraLuca = -FraLuca;
                }
                if (NapLuca < 0)
                {
                    NapLuca = -NapLuca;
                }

                int NotaLuca = MargLuca + QueiLuca + EscLuca + PortLuca + FraLuca + NapLuca;
                var NotsComp = new List<int> { NotaRen, NotaMar, NotaLen, NotaRena, NotaWash, NotaTino, NotaLuca };
                int pos = NotsComp.IndexOf(NotsComp.Min());

                if (pos == 0)
                {
                    YourPalate.Text = "Você tem um paladar parecido com o de Renato, recomendamos que faça pedidos com ele.";
                }
                if (pos == 1)
                {   
                    YourPalate.Text = "Você tem um paladar parecido com o de Marcelo, recomendamos que faça pedidos com ele.";
                }
                if (pos == 2)
                {
                    YourPalate.Text = "Você tem um paladar parecido com o de Lenon, recomendamos que faça pedidos com ele.";
                }
                if (pos == 3)
                {
                    YourPalate.Text = "Você tem um paladar parecido com o de Renata, recomendamos que faça pedidos com ele.";
                }
                if (pos == 4)
                {
                    YourPalate.Text = "Você tem um paladar parecido com o de Washington, recomendamos que faça pedidos com ele.";
                }
                if (pos == 5)
                {
                    YourPalate.Text = "Você tem um paladar parecido com o de Tino, recomendamos que faça pedidos com ele.";
                }
                if (pos == 6)
                {
                    YourPalate.Text = "Você tem um paladar parecido com o de Luca, recomendamos que faça pedidos com ele.";
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("Sabor");
                dt.Columns.Add("Nota");

                dt.Rows.Add("Marguerita", MargueritaNota.ToString());
                dt.Rows.Add("Quatro queijos", QueijoNota.ToString());
                dt.Rows.Add("Escarola", EscarolaNota.ToString());
                dt.Rows.Add("Portuguesa", PortuguesaNota.ToString());
                dt.Rows.Add("Frango Catupiry", FrangoNota.ToString());
                dt.Rows.Add("Napolitana", NapolitanaNota.ToString());
                GridView1.DataSource = dt;
                GridView1.DataBind();

                DataTable dt1 = new DataTable();
                dt1.Columns.Add("Sabor");
                dt1.Columns.Add("Nota");
                    
                dt1.Rows.Add("Marguerita", "4");
                dt1.Rows.Add("Quatro queijos", "5");
                dt1.Rows.Add("Escarola", "4");
                dt1.Rows.Add("Portuguesa", "5");
                dt1.Rows.Add("Frango Catupiry", "4");
                dt1.Rows.Add("Napolitana", "3");
                GridView2.DataSource = dt1;
                GridView2.DataBind();

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("Sabor");
                dt2.Columns.Add("Nota");

                dt2.Rows.Add("Marguerita", "2");
                dt2.Rows.Add("Quatro queijos", "2");
                dt2.Rows.Add("Escarola", "1");
                dt2.Rows.Add("Portuguesa", "3");
                dt2.Rows.Add("Frango Catupiry", "5");
                dt2.Rows.Add("Napolitana", "2");
                GridView3.DataSource = dt2;
                GridView3.DataBind();

                DataTable dt3 = new DataTable();
                dt3.Columns.Add("Sabor");
                dt3.Columns.Add("Nota");

                dt3.Rows.Add("Marguerita", "4");
                dt3.Rows.Add("Quatro queijos", "5");
                dt3.Rows.Add("Escarola", "2");
                dt3.Rows.Add("Portuguesa", "1");
                dt3.Rows.Add("Frango Catupiry", "1");
                dt3.Rows.Add("Napolitana", "3");
                GridView4.DataSource = dt3;
                GridView4.DataBind();

                DataTable dt4 = new DataTable();
                dt4.Columns.Add("Sabor");
                dt4.Columns.Add("Nota");

                dt4.Rows.Add("Marguerita", "4");
                dt4.Rows.Add("Quatro queijos", "5");
                dt4.Rows.Add("Escarola", "1");
                dt4.Rows.Add("Portuguesa", "1");
                dt4.Rows.Add("Frango Catupiry", "3");
                dt4.Rows.Add("Napolitana", "4");
                GridView5.DataSource = dt4;
                GridView5.DataBind();

                DataTable dt5 = new DataTable();
                dt5.Columns.Add("Sabor");
                dt5.Columns.Add("Nota");

                dt5.Rows.Add("Marguerita", "1");
                dt5.Rows.Add("Quatro queijos", "1");
                dt5.Rows.Add("Escarola", "2");
                dt5.Rows.Add("Portuguesa", "3");
                dt5.Rows.Add("Frango Catupiry", "4");
                dt5.Rows.Add("Napolitana", "3");
                GridView6.DataSource = dt5;
                GridView6.DataBind();

                DataTable dt6 = new DataTable();
                dt6.Columns.Add("Sabor");
                dt6.Columns.Add("Nota");

                dt6.Rows.Add("Marguerita", "1");
                dt6.Rows.Add("Quatro queijos", "5");
                dt6.Rows.Add("Escarola", "1");
                dt6.Rows.Add("Portuguesa", "4");
                dt6.Rows.Add("Frango Catupiry", "3");
                dt6.Rows.Add("Napolitana", "2");
                GridView7.DataSource = dt6;
                GridView7.DataBind();

                DataTable dt7 = new DataTable();
                dt7.Columns.Add("Sabor");
                dt7.Columns.Add("Nota");

                dt7.Rows.Add("Marguerita", "5");
                dt7.Rows.Add("Quatro queijos", "4");
                dt7.Rows.Add("Escarola", "3");
                dt7.Rows.Add("Portuguesa", "4");
                dt7.Rows.Add("Frango Catupiry", "3");
                dt7.Rows.Add("Napolitana", "2");
                GridView8.DataSource = dt7;
                GridView8.DataBind();
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie pizzatest = Request.Cookies["pizzatest"];
            
            if(pizzatest == null)
            {
                Response.Redirect("/selectpizza.aspx");
            }

            else
            {
                HttpCookie cookiepizza = new HttpCookie("pizzatest");
                HttpCookie margpizz = new HttpCookie("MargPi");
                HttpCookie QuaPi = new HttpCookie("QuaPi");
                HttpCookie EscPiz = new HttpCookie("EscPi");
                HttpCookie PorPi = new HttpCookie("PorPi");
                HttpCookie FraPi = new HttpCookie("FraPi");
                HttpCookie NapPi = new HttpCookie("NapPi");

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


                Response.Redirect("/selectpizza.aspx");
            }
        }
    }
}