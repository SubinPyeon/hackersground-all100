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
            </style>
        </head>
        <body>
            <h1>" + message + @"</h1>
            <h1>" + message1 + @"</h1>

            <!-- 이미지를 추가합니다. -->
            <img src="background_img.jpg">
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
