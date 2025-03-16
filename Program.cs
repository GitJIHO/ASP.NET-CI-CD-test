// Program.cs
using Microsoft.EntityFrameworkCore;
using testapi.Repositories;
using testapi.Services;
using testapi.Data;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // 컨트롤러 서비스 추가

// DBContext 등록
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repository 등록
builder.Services.AddScoped<IMemberRepository, MemberRepository>();

// Service 등록
builder.Services.AddScoped<MemberService>();

// Swagger 설정
builder.Services.AddEndpointsApiExplorer(); // 엔드포인트 탐색기 추가
builder.Services.AddSwaggerGen(c =>
{
    // Swagger 문서화에 대한 설정
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Member API",
        Version = "v1",
        Description = "API to manage members in the system"
    });
});

var app = builder.Build();

// Swagger UI 설정
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Member API v1");
        c.RoutePrefix = string.Empty; // Swagger UI를 루트에서 사용할 수 있도록 설정
    });
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
