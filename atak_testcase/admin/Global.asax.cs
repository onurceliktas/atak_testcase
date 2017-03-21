using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace atak_testcase.admin
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Urunler adında bir Route oluşturuyoruz ve Kategori, UrunTuru adında iki parametre ekliyoruz.
            //RouteTable.Routes.Add("haber_duzenle", new Route("haber_duzenle/{haberID}/}", new PageRouteHandler("~/haber_duzenle.aspx")));

            RouteTable.Routes.Add("haberduzenle", new Route("haber_duzenle/{haberID}", new PageRouteHandler("~/haber_duzenle.aspx")));
            RouteTable.Routes.Add("haberekle", new Route("haberler/haber_ekle", new PageRouteHandler("~/haber_ekle.aspx")));

            // Add Routes.
            //   RegisterCustomRoutes(RouteTable.Routes);
           // RegisterRoutes(RouteTable.Routes);


        }
        public void RegisterRoutes(RouteCollection routes)
        {


            routes.MapPageRoute("haberduzenle", "haber_duzenle/{haberID}", "~/haber_duzenle.aspx");
            routes.MapPageRoute("haberekle", "haberler/ekle", "~/haber_ekle.aspx");
    //        routes.MapPageRoute(
    //   "haber_duzenle",      // Route name
    //   "haberler/{haberID}",      // Route URL
    //   "~/haber_duzenle.aspx" // Web page to handle route
    //);

        }




        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}