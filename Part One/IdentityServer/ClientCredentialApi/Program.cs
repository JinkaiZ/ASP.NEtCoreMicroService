using Microsoft.IdentityModel.Logging;

var builder = WebApplication.CreateBuilder(args);
IdentityModelEventSource.ShowPII = true;
builder.WebHost.UseUrls("http://localhost:5001");

builder.Services.AddAuthentication("Bearer")
       .AddIdentityServerAuthentication(options =>
       {
           options.Authority = "http://localhost:5000";
           options.RequireHttpsMetadata = false;
           options.ApiName = "api";
       });
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting(); 

app.UseAuthentication(); 
app.UseAuthorization(); 

app.MapControllers();

app.Run();
