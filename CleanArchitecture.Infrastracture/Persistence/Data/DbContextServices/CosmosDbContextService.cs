using CleanArchitecture.Core.Interfaces;

namespace CleanArchitecture.Infrastracture.Persistence.Data.DbContextServices
{
    public class CosmosDbContextService : IDbContextBuilder
    {
        public dynamic GetDbContextBasedOnType()
        {
            return "CosmosDbContext";
        }
    }
}
