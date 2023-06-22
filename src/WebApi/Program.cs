
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.MapGet("/", async context =>
{

    // HTML 페이지를 작성합니다.
    var htmlContent = @"
    <!DOCTYPE html>
    <html>
    <head>
        <title>My Web Page</title>
        <style>
            /* CSS 스타일을 적용합니다. */
            body {
                background-color: #f1f1f1;
                font-family: Arial, sans-serif;
                text-align: center;
            }
            
            h1 {
                color: #333;
                font-size: 24px;
                margin-top: 20px;
            }
            
            /* KIMI 스타일을 수정합니다. */
            .kimi {
                font-size: 30px;
                font-weight: bold;
                color: white;
            }
        </style>
    </head>
    <body>
        <h1>모든 치매 환자를 위한 서비스</h1>
        <h1 class=""kimi"">KIMI</h1>

        <!-- 이미지를 추가합니다. -->
        <img src=""https://images.unsplash.com/photo-1503614472-8c93d56e92ce?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2011&q=80"" width=""50"" height=""50"">
        <img src=src/WebApi/bongbong.jpeg width=""50"" height=""50"">
        <img src=""/workspaces/hackersground-all100/picture2.jpg"" width=""50"" height=""50"">
    </body>
    </html>
    ";

    // HTML 응답을 반환합니다.
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(htmlContent);
});

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.Run();