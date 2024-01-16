using CleanArchitecture.Core.Interfaces;

namespace CleanArchitecture.Infrastracture.Persistence.Data.DbContextServices
{
    public class SQLDbContextService : IDbContextBuilder
    {
        public dynamic GetDbContextBasedOnType()
        {
            return "SqlDbContext";
        }
    }
}
