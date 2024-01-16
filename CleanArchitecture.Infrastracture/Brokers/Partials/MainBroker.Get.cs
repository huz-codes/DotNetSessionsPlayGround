using CleanArchitecture.Shared.Models;

namespace CleanArchitecture.Infrastracture.Brokers
{
    public partial class MainBroker
    {
        public async ValueTask<List<MobileModel>> Get(string url)
        {
            var oMobiles = await _externalServices.Get<List<MobileModel>>(url);
            ///TODO your logic 
            return oMobiles;
        }

        public async ValueTask<MobileModel> Get(string url, int id)
        {
            var oMobile = await _externalServices.Get<MobileModel>($"{url}/{id}");
            ///TODO your logic 
            return oMobile;
        }
    }
}
