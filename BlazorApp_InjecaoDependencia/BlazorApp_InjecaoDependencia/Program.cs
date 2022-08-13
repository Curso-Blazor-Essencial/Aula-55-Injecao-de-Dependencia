using BlazorApp_InjecaoDependencia;
using BlazorApp_InjecaoDependencia.Servicos;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ServicoSingleton>();
builder.Services.AddScoped<ServicoScoped>();
builder.Services.AddTransient<ServicoTransient>();


await builder.Build().RunAsync();
