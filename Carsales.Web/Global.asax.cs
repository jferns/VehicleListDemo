using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Carsales.Web
{
    public class Global : HttpApplication
    {

        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            log4net.GlobalContext.Properties["Source"] = "Carsales.Web";

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //UnityConfig.RegisterComponents();

            GlobalConfiguration.Configuration.EnsureInitialized();
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}