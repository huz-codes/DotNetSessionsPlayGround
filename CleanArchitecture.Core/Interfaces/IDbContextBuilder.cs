namespace CleanArchitecture.Core.Interfaces
{
    public interface IDbContextBuilder
    {
        dynamic GetDbContextBasedOnType();
    }
}
