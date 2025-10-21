using Microsoft.EntityFrameworkCore;
using WEB_API.Data;
using WEB_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KhanhConn")));

// Đăng ký Repository Pattern
builder.Services.AddScoped<INhomRepository, NhomRepository>();
builder.Services.AddScoped<IThietBiRepository, ThietBiRepository>();

// >>> THÊM 1: Cấu hình dịch vụ CORS <<<
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// >>> THÊM 2: Sử dụng middleware CORS <<<
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();