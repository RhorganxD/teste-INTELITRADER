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
            HttpCookie name = Request.Cookies["username"];

            if (name == null)
            {
                Response.Redirect("/home.aspx");
            }

            else{
                
            }
        }
    }
}