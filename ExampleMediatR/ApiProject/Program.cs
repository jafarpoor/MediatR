using ExampleMediatR.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"),
    b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));
});
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

#region Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("", new OpenApiInfo
    {
        Version = "",
        Title = "",
    });
});
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#region Swagger
app.UseSwagger();
//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint();
//});
#endregion
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
