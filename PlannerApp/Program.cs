using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Blazored.LocalStorage;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using PlannerApp.Client;
using PlannerApp.Shared.Services;

namespace PlannerApp
{
    public class Program
    {
        private const string Url = "https://plannerappserver20200228091432.azurewebsites.net";

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped(s => { return new AuthenticationService(Url); });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddScoped(s => { return new Authen})

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            builder.RootComponents.Add<App>("app");
            await builder.Build().RunAsync();
        }
    }
}
