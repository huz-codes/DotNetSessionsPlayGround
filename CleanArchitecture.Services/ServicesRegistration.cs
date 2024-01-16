using CleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Services
{
    public static class ServicesRegistration
    {
        public static void AddServiceRegistrations(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ICarServices, CarServices>();
            builder.Services.AddScoped<IDependencyInjectionUser, DependencyInjectionUser>();
            builder.Services.AddScoped<IDependencyInjectionDepartment, DependencyInjectionDepartment>();
            builder.Services.AddScoped<ICircularDependency, CircularDependency>();
            builder.Services.AddScoped<IUsers, TEst>();
        }
    }
}
