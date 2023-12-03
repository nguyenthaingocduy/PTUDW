using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _63CNTT4N2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Dangnhap",
               url: "dang-nhap",
               defaults: new { controller = "Site", action = "Dangnhap", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Dangky",
               url: "dang-ky",
               defaults: new { controller = "Site", action = "Dangky", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Site", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
