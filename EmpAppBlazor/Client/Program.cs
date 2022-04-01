global using EmpAppBlazor.Client.Services.ProjectService;
global using EmpAppBlazor.Client.Services.WorkloadService;
global using EmpAppBlazor.Shared;
global using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EmpAppBlazor.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//services
builder.Services.AddScoped<IProjectService, ProjectService>(); 
builder.Services.AddScoped<IWorkloadService, WorkloadService>();

await builder.Build().RunAsync();
