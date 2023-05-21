using CsvBlazor.Client;
using CsvBlazor.Client.Core;
using CsvBlazor.Client.Implementations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace CsvBlazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<IUiMessage, ToastrMessage>();
            // enable IHttpClientFactory
            builder.Services.AddHttpClient();

            await builder.Build().RunAsync();
        }
    }
}