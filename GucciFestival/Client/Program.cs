using GucciFestival.Client;
using GucciFestival.Client.Models;
using GucciFestival.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Her får den fat i httpclient, for at kunne kommunikere med GucciFestival.Server
builder.Services.AddHttpClient<IShiftService, ShiftService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});


await builder.Build().RunAsync();
