namespace CleanArchitecture.Infrastracture.Brokers
{
    public partial class MainBroker
    {
        public async ValueTask<bool> Delete(string url, string id)
        {
            var oData = await _externalServices.Delete($"{url}/{id}");
            return oData.IsSuccessStatusCode;
        }
    }
}
