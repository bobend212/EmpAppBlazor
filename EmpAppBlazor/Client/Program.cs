global using EmpAppBlazor.Client.Services.AuthService;
global using EmpAppBlazor.Client.Services.ProjectService;
global using EmpAppBlazor.Client.Services.WorkloadService;
global using EmpAppBlazor.Shared;
global using Microsoft.AspNetCore.Components.Authorization;
global using System.Net.Http.Json;
global using EmpAppBlazor.Shared.DTOs;
global using MudBlazor;
using Blazored.LocalStorage;
using EmpAppBlazor.Client;
using EmpAppBlazor.Client.Services.TaskItemService;
using EmpAppBlazor.Client.Services.UserService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//services
builder.Services.AddScoped<IProjectServiceClient, ProjectServiceClient>();
builder.Services.AddScoped<IWorkloadServiceClient, WorkloadServiceClient>();
builder.Services.AddScoped<IAuthServiceClient, AuthServiceClient>();
builder.Services.AddScoped<ITaskItemServiceClient, TaskItemServiceClient>();
builder.Services.AddScoped<IUserServiceClient, UserServiceClient>();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
    config.SnackbarConfiguration.VisibleStateDuration = 1000;
});
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();