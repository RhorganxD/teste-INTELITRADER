using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class playjokenpo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie name = Request.Cookies["username"];

            if (name == null)
            {
                Response.Redirect("/home.aspx");
            }
        }

        protected void verifywin_Click(object sender, EventArgs e)
        {
            if(play1tb.Text == "" | play2tb.Text == "")
            {
                return;
            }

            if(play1tb.Text != "1" & play1tb.Text != "2" & play1tb.Text != "3")
            {
                return;
            }

            else if(play2tb.Text != "1" & play2tb.Text != "2" & play2tb.Text != "3")
            {
                return;
            }

            else
            {
                string result = "";
                if (play1tb.Text == "1")
                {
                    result = "Pedra";
                }
                if (play1tb.Text == "2")
                {
                    result = "Papel";
                }
                if (play1tb.Text == "3")
                {
                    result = "Tesoura";
                }

                string result1 = "";
                if (play2tb.Text == "1")
                {
                    result1 = "Pedra";
                }
                if (play2tb.Text == "2")
                {
                    result1 = "Papel";
                }
                if (play2tb.Text == "3")
                {
                    result1 = "Tesoura";
                }

                if (play1tb.Text == "1" & play2tb.Text == "1" | play1tb.Text == "2" & play2tb.Text == "2" | play1tb.Text == "3" & play2tb.Text == "3")
                {
                    Label1.Visible = false;
                    lbempate.Visible = true;

                    lbempate.Text = "Jogador 1 e Jogador 2 empataram, pois ambos colocaram " + result + " como opção";
                    Div1.Visible = true;
                }

                else
                {
                    if(play1tb.Text == "1" & play2tb.Text == "2")
                    {
                        Div1.Visible = true;
                        lbempate.Visible = false;
                        Label1.Visible = true;
                        Label1.Text = "Jogador 2 ganhou, pois jogou papel contra pedra do Jogador 1";
                    }

                    if (play1tb.Text == "1" & play2tb.Text == "3" | play1tb.Text == "2" & play2tb.Text == "1" | play1tb.Text == "3" & play2tb.Text == "2")
                    {
                        Div1.Visible = true;
                        lbempate.Visible = false;
                        Label1.Visible = true;
                        Label1.Text = "Jogador 1 ganhou, pois jogou " + result + " contra " + result1 + " do Jogador 2";
                    }

                    if (play2tb.Text == "1" & play1tb.Text == "3" | play2tb.Text == "2" & play1tb.Text == "1" | play2tb.Text == "3" & play1tb.Text == "2")
                    {
                        Div1.Visible = true;
                        lbempate.Visible = false;
                        Label1.Visible = true;
                        Label1.Text = "Jogador 2 ganhou, pois jogou " + result1 + " contra " + result + " do Jogador 1";
                    }
                }
            }
        }
    }
}