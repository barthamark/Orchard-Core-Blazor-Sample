using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using System;

namespace OrchardCoreBlazorSample.Module1
{
    // This is an Orchard Core Startup class. This one is specifically created to initialize Blazor services and the SignalR hub.
    // Note, that it should run only once so you might want to create a Blazor base module where you put this Startup class and
    // use that module as a dependency for all your Blazor-specific modules.
    public class BlazorStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddServerSideBlazor();
        }

        public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapBlazorHub();
        }
    }
}
