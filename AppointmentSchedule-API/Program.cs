using AppointmentSchedule.Infra.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register ApplicationDbContext with SQL Server connection
builder.Services.AddDbContext<AppointmentScheduleContext>(option =>
{
    //option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("AppointmentSchedule-API"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
