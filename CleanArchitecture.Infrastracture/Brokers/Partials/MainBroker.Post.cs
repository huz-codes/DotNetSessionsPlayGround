using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Shared.Models;

namespace CleanArchitecture.Infrastracture.Brokers
{
    public partial class MainBroker
    {
        public async ValueTask<MobileModel> Post(string url, MobileModel content)
        {
            var oMobile = await _externalServices.Post<MobileModel, MobileModel>(url, content);
            ///TODO your logic
            return oMobile;
        }
    }
}
