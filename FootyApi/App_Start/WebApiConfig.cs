using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http;
using FootApi.Models;

namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "TeamApi",
                routeTemplate: "api/league/{teamId}/team",
                defaults: new {controller = "Team", id = RouteParameter.Optional}
                );

            config.Routes.MapHttpRoute(
                name: "TeamPlayerApi",
                routeTemplate: "api/league/{teamId}/team/{playerId}",
                defaults: new {controller = "Team", id = RouteParameter.Optional}
                );

            config.Routes.MapHttpRoute(
                name: "LeagueTeamApi",
                routeTemplate: "api/league/{teamId}",
                defaults: new { controller = "League", id = RouteParameter.Optional }
                );

            config.Routes.MapHttpRoute(
                name: "LeagueApi",
                routeTemplate: "api/league",
                defaults: new {controller = "League", id = RouteParameter.Optional}
                );

//            config.Routes.MapHttpRoute(
//                name: "LeagueApi",
//                routeTemplate: "api/{controller}/{id}",
//                defaults: new {id = RouteParameter.Optional}
//                );
        }
    }
}
