﻿using System.Web.Mvc;

namespace Phoenix.Server.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_Login",
                "Admin/login",
                new { controller = "Admin", action = "Login", id = UrlParameter.Optional },
                new[] { "Phoenix.Server.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional },
                new[] { "Phoenix.Server.Web.Areas.Admin.Controllers" }
            );
        }
    }
}