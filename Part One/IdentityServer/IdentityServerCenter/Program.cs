using IdentityServerCenter.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:5000");

builder.Services.AddIdentityServer()
    .AddDeveloperSigningCredential()
    .AddInMemoryPersistedGrants()
    .AddInMemoryApiResources(Config.GetResource())
    .AddInMemoryApiScopes(Config.GetApiScopes())
    .AddInMemoryClients(Config.GetClients());

builder.Services.AddControllersWithViews(); 

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseIdentityServer();


app.Run();
