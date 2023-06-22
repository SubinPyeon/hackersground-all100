using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.MapGet("/", async context =>
{
    var message = "Hello, World!!!!!!!";
    var message1 = "Hello!!!!!!!";
    await context.Response.WriteAsync($"<h1>{message}</h1>");
    await context.Response.WriteAsync($"<h1>{message1}</h1>");
});

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.Run();