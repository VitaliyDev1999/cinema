﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            //кастомный роут
            //routes.MapRoute
            //(
            //    name:"MoviesByDate",
            //    url:"movies/released/{entrydate}",
            //    defaults: new { controller = "Movies" , action = "Entry"}
            //);

            //routes.MapRoute
            //(
            //    name: "MoviesByRealeseDate",
            //    url: "movies/released/{year}/{month}",
            //    defaults: new { controller = "Movies", action = "ReleaseDate" },
            //    //ограничение символов d - значит digit
            //    new { year = @"2016|2017" , month = @"\d{2}"}

            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
