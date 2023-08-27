﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;
using static System.Collections.Specialized.BitVector32;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.MapRoute("Default", "{controller}/{action}/{id}", new
            {
                controller = "Home",
                action = "Index",
                id = UrlParameter.Optional
            },
            new[] { "UrlsAndRoutes.Controllers" });
        
            // Learn: Constraining Routes
            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new
            //    {
            //        controller = "Home",
            //        action ="Index",
            //        id = UrlParameter.Optional
            //    },
            //    new
            //    {
            //        controller = "^H.*",
            //        action = "^Index$|^About$",
            //        httpMethod = new HttpMethodConstraint("GET"),
            //        id = new CompoundRouteConstraint( new IRouteConstraint[] {
            //                new AlphaRouteConstraint(),
            //                new MinLengthRouteConstraint(6)
            //            })
            //    },
            //    new[] { "URLsAndRoutes.Controllers" });



            // Learn: Prioritizing Controller by Namespace
            //Route myRoute =
            //    routes.MapRoute("AddContollerRoute", "{controller}/{action}/{id}/{*catchall}",
            //        new
            //        {
            //            controller = "Home",
            //            action = "Index",
            //            id = UrlParameter.Optional
            //        },
            //        new[] { "URLsAndRoutes.AdditionalControllers" });

            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    },
            //    new[] { "URLsAndRoutes.Controllers" });



            // Learn: Static URL and Segments
            //routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });

            //routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            //routes.MapRoute("", "X{controller}/{action}");

            //routes.MapRoute(
            //    name: "MyRoute", 
            //    url: "{controller}/{action}",
            //    defaults: new { controller = "Home", action = "index" });

            //routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });

            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
