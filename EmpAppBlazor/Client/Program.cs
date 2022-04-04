global using EmpAppBlazor.Client.Services.ProjectService;
global using EmpAppBlazor.Client.Services.WorkloadService;
global using EmpAppBlazor.Shared;
global using System.Net.Http.Json;
global using EmpAppBlazor.Client.Services.AuthService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EmpAppBlazor.Client;
using MudBlazor.Services;
using MudBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//services
builder.Services.AddScoped<IProjectService, ProjectService>(); 
builder.Services.AddScoped<IWorkloadService, WorkloadService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
});

await builder.Build().RunAsync();
