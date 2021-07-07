using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class caixatest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie mymoney = Request.Cookies["mymoney"];
            HttpCookie usern = Request.Cookies["username"];
            if(usern == null)
            {
                Response.Redirect("/home.aspx");
            }

            if(mymoney == null)
            {
                noselec.Visible = true;
                Div1.Visible = false;
            }

            else
            {
                qtyced.InnerText = "Cédulas disponiveis: R$ 100.00,  R$ 50.00, R$ 20.00 e R$ 10.00";
                noselec.Visible = false;
                MyMoney.Text = "R$ "+ mymoney["mymoney"];
                Div1.Visible = true;
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpCookie mymoney = new HttpCookie("mymoney");

            HttpCookie usern = Request.Cookies["username"];
            if (usern == null)
            {
                Response.Redirect("/home.aspx");
            }

            HttpCookie mymon = Request.Cookies["mymoney"];
            if(mymon != null)
            {
                Response.Redirect("/caixatest.aspx");
            }

            else
            {
                mymoney.Expires = DateTime.Now.AddDays(2);
                mymoney.Values.Add("mymoney", TbMoney.Text);

                Response.Cookies.Add(mymoney);

                Response.Redirect("/caixatest.aspx");
            }
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            HttpCookie mymoney = Request.Cookies["mymoney"];
            HttpCookie usern = Request.Cookies["username"];
            if (usern == null)
            {
                Response.Redirect("/home.aspx");
            }

            if (mymoney == null)
            {
                Response.Redirect("/caixatest.aspx");
            }

            if(withdrawlbtn.Text == "")
            {
                errors.Text = "Digite um valor";
                Ced100.Visible = false;
                Ced50.Visible = false;
                Ced20.Visible = false;
                Ced10.Visible = false;
            }

            else if(Convert.ToDouble(mymoney["mymoney"]) < Convert.ToDouble(withdrawlbtn.Text))
            {
                errors.Text = "Você não possui saldo suficiente";
                Ced100.Visible = false;
                Ced50.Visible = false;
                Ced20.Visible = false;
                Ced10.Visible = false;
            }
            else if (Convert.ToDouble(withdrawlbtn.Text) % 10 != 0)
            {
                errors.Text = "O banco não consegue entregar esse valor";
                Ced100.Visible = false;
                Ced50.Visible = false;
                Ced20.Visible = false;
                Ced10.Visible = false;
            }
            else
            {
                Ced100.Visible = false;
                Ced50.Visible = false;
                Ced20.Visible = false;
                Ced10.Visible = false;

                    
                int a = Convert.ToInt32(withdrawlbtn.Text);
                int number = Convert.ToInt32(withdrawlbtn.Text);
                int total = 0;

                errors.Visible = false;

                while (number >= 100)
                {
                    int cem;
                    cem = a /= 100;
                    number = number % 100;
                    Ced100.Visible = true;
                    Ced100.Text = "O banco lhe entregou o total de " + cem.ToString() + " notas de R$ 100,00 reais";
                    total += 100 * cem;
                }
              
                while (number >= 50)
                {
                    int cinquenta;
                    int divi = number;
                    cinquenta = divi /= 50;
                    number = number % 50;
                    Ced50.Visible = true;
                    Ced50.Text = "O banco lhe entregou o total de " + cinquenta.ToString() + " notas de R$ 50,00 reais";
                    total += 50 * cinquenta;
                }

                   
                while (number >= 20)
                {
                    int vinte;
                    int divi = number;
                    vinte = divi /= 20;
                    number = number % 20;
                    Ced20.Visible = true;
                    Ced20.Text = "O banco lhe entregou o total de " + vinte.ToString() + " notas de R$ 20,00 reais";
                    total += 20 * vinte;
                }   
                   
                while (number >= 10)
                {
                    int dez;
                    int divi = number;
                    dez = divi /= 10;
                    number = number % 10;
                    Ced10.Visible = true;
                    Ced10.Text = "O banco lhe entregou o total de " + dez.ToString() + " notas de R$ 10,00 reais";
                    total += 10 * dez;
                }

                double numb = Convert.ToDouble(mymoney["mymoney"]);
                double result = numb - total;

                HttpCookie mymon = new HttpCookie("mymoney");
                mymon.Values.Add("mymoney", result.ToString());
                mymon.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(mymon);
                MyMoney.Text = "R$ "+ result.ToString();
            }            
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            HttpCookie usern = Request.Cookies["username"];
            if (usern == null)
            {
                Response.Redirect("/home.aspx");
            }

            HttpCookie mymon = Request.Cookies["mymoney"];
            if (mymon == null)
            {
                Response.Redirect("/caixatest.aspx");
            }

            else
            {
                HttpCookie mymoney = new HttpCookie("mymoney");

                double numb = Convert.ToDouble(mymon["mymoney"]);
                double result = numb + Convert.ToDouble(deposit.Text);

                mymoney.Values.Add("mymoney", result.ToString());
                mymoney.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(mymoney);

                MyMoney.Text = "R$ "+ result.ToString();
            }
        }
    }
}
