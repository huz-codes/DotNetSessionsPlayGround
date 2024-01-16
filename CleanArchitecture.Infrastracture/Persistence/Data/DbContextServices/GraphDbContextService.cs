using CleanArchitecture.Core.Interfaces;

namespace CleanArchitecture.Infrastracture.Persistence.Data.DbContextServices
{
    public class GraphDbContextService : IDbContextBuilder
    {
        public dynamic GetDbContextBasedOnType()
        {
            return "GraphDbContext";
        }
    }
}
