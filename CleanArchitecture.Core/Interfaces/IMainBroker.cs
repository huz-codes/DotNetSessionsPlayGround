using CleanArchitecture.Shared.Models;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IMainBroker
    {
        ValueTask<List<MobileModel>> Get(string url);
        ValueTask<MobileModel> Get(string url, int id);
        ValueTask<bool> Delete(string url, string id);
        ValueTask<MobileModel> Post(string url, MobileModel content);
        string Put(string url, string content);
    }
}
