using System;
using System.Web.Routing;

namespace testes3
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RoutingData(RouteTable.Routes);
        }

       
        private void RoutingData(RouteCollection routeCollection)
        {
            routeCollection.MapPageRoute("", "", "~/home.aspx");
        }
        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}