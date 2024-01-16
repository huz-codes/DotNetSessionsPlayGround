using CleanArchitecture.Infrastracture;
using CleanArchitecture.Infrastracture.Persistence.Data;
using CleanArchitecture.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// service registration (IServiceCollection)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.AddInfrastructureRegistration(); 
builder.AddServiceRegistrations();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(""));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
