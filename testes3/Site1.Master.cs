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
                HelloUser.Visible = false;
                LeftUser.Visible = false;
                selectpizza.Visible = false;
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
            cookieuser.Expires = DateTime.Now.AddSeconds(-1);
            Response.Cookies.Add(cookieuser);

            Response.Redirect("/home.aspx");
        }
    }
}