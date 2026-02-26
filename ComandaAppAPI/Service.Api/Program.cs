using Infrastructure.Shared.Context;
using Microsoft.EntityFrameworkCore;
using Service.Api.Extensions;
using Service.Api.Shared.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddNpgsql<BaseContext>(connectionString);
builder.Services.AddApplication();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BaseContext>();
    dbContext.Database.EnsureCreated();
}

if (app.Environment.IsEnvironment("Development") || app.Environment.IsEnvironment("Local"))
{
    app.ApplyMigration();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()
);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
