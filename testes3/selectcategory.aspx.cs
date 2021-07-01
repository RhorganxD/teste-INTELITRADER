using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testes3
{
    public partial class selectcategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                Response.Redirect("/selectpizza.aspx");
            }
        }
    }
}