using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastracture.Persistence.Data.DbContextServices;

namespace CleanArchitecture.Infrastracture.Factories
{
    public static class DbContextFactory
    {
        public static IDbContextBuilder ContextBuilder(string type)
        {
            switch (type)
            {
                case "Sql":
                    return new SQLDbContextService();
                case "Cosmos":
                    return new CosmosDbContextService();
                case "Graph":
                    return new GraphDbContextService();
                default: return null!;
            }
        }
    }
}
