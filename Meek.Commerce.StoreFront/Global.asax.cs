using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Meek.Web.Mvc;
using ExtendedRazorViewEngine = Meek.Commerce.Web.Mvc.ExtendedRazorViewEngine;

namespace Meek.Commerce.StoreFront
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Root", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();

            //var fileName = VirtualPathUtility.GetFileName(@"~\Config\Views.Config");
            //var fileName = System.IO.Path.GetFullPath(@"Config\Views.config");
            var fileName = HttpContext.Current.Server.MapPath(@"~\Config\Views.config");

            var viewConfigSource = ViewConfigSource.Create(fileName);
            //var viewConfigSource = ViewConfigSource.Create(@"D:\studio032\Meek.Commerce\Meek.Commerce.StoreFront\Config\Views.config");
            
            var engine = new ExtendedRazorViewEngine();
            engine.SetViewConfigSource(viewConfigSource);
            
            ViewEngines.Engines.Add(engine);
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}