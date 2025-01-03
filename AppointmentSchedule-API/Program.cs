using AppointmentSchedule.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Rewrite;
using AppointmentSchedule.Infra.Repository.Interfaces;
using AppointmentSchedule.Infra.Repository;
using AppointmentSchedule.Application.Services.Interfaces;
using AppointmentSchedule.Application.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IDoctorService, DoctorService>();


builder.Services.AddControllers();


// Register ApplicationDbContext with SQL Server connection
builder.Services.AddDbContext<AppointmentScheduleContext>(option =>
{
    //option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("AppointmentSchedule-API"));
});


// Configuração do Swagger
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "AppointmentSchedule-API",
            Version = "v1",
            Description = "A user-friendly app designed to streamline medical appointment scheduling and management efficiently.",
            Contact = new OpenApiContact
            {
                Name = "Leonardo Silva",
                Url = new Uri("https://github.com/leosilvajr")
            }
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.

// Configuração do Swagger
app.UseSwagger();
app.UseSwaggerUI(view => {
    view.SwaggerEndpoint("/swagger/v1/swagger.json", "API - Authentication");
});

// Redireciona a rota raiz para o Swagger
var option = new RewriteOptions();
option.AddRedirect("^$", "swagger");
app.UseRewriter(option);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
