namespace CleanArchitecture.Core.Interfaces
{
    public interface IProductsBroker
    {
        dynamic Get(string url);
        dynamic Post(string url, string content);
        dynamic Put(string url, string content);
        dynamic Delete(string url);
    }
}
