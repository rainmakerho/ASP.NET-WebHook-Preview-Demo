using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace WebHookDemo.Sender
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //https://github.com/aspnet/WebHooks
            //https://blogs.msdn.microsoft.com/webdev/2015/09/15/sending-webhooks-with-asp-net-webhooks-preview/
            //http://blogs.msdn.com/b/webdev/archive/2015/11/07/updates-to-microsoft-asp-net-webhooks-preview.aspx
            // Load Web API controllers and Azure Storage store
            config.InitializeCustomWebHooks();
            config.InitializeCustomWebHooksSqlStorage();
            config.InitializeCustomWebHooksApis();

        }
    }
}
