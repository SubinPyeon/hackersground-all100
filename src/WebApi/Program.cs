using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 웹 서버에서 정적 파일을 제공하기 위한 설정
builder.WebHost.UseWebRoot("wwwroot");

var app = builder.Build();

// 정적 파일 제공을 위한 미들웨어 등록
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.Run();