using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MusicAppLints.DAL;

namespace MusicAppLints
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["dataFilePath"] = HttpContext.Current.Server.MapPath("~/App_Data/MusicData.xml");
        }

        protected void Session_Start()
        {
            Session["MusicAlbums"] = InitializeSeedData.GetAllMusicAlbums();
        }
    }
}
