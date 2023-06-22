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
            <meta charset=""UTF-8"">
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

                .kimi {
                font-size: 30px;
                font-weight: bold;
                color: blue; /* 원하는 색상으로 변경하세요 */
                }
            </style>
        </head>
        <body>
            <h1>""치매 환자 지킴이 서비스""</h1>
            <h1><span class=""kimi"">KIMI</h1>

            <h1>"" '지킴이' -> '지키미' -> '키미(KIMI)'<br>
        키미앱은 보호자와 보호대상자를 연결하여<br>
        배회하는 치매환자를 지키는 서비스입니다.<br>

        치매환자가 배회할 때 보호자에게 알림이 가고<br>
        보호자는 치매환자의 위치를 확인할 수 있습니다.
        ""</h1>

            <!-- 이미지를 추가합니다. -->
            <img src=""https://cdn-icons-png.flaticon.com/128/9301/9301483.png"" width=""300"" height=""400"">
            <img src=""https://cdn-icons-png.flaticon.com/128/5798/5798277.png"" width=""300"" height=""400"">
            <img src=""https://cdn-icons-png.flaticon.com/128/10551/10551084.png"" width=""300"" height=""400"">
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