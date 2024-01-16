using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastracture.Brokers;
using CleanArchitecture.Infrastracture.Persistence;
using CleanArchitecture.Infrastracture.Persistence.Data.DbContextServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastracture
{
    public static class InfrastructureRegistration
    {
        public static void AddInfrastructureRegistration(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddTransient<IDbContextBuilder, SQLDbContextService>();
            builder.Services.AddTransient<IDbContextBuilder, CosmosDbContextService>();
            builder.Services.AddTransient<IDbContextBuilder, GraphDbContextService>();

            builder.Services.AddScoped<IMainBroker, MainBroker>();
            builder.Services.AddScoped<IExternalServices, ExternalServices>();
        }
    }
}
