﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(WebClientSnake.Startup))]

namespace WebClientSnake
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var hubConfiguration = new HubConfiguration();
            ////hubConfiguration.EnableDetailedErrors = true;
            //hubConfiguration.EnableJavaScriptProxies = true;

            //app.MapSignalR(hubConfiguration);
            
        }
    }
}
