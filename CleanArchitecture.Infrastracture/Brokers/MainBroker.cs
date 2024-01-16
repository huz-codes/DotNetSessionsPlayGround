using CleanArchitecture.Core.Interfaces;
using Microsoft.Extensions.Configuration;

namespace CleanArchitecture.Infrastracture.Brokers
{
    public partial class MainBroker : IMainBroker
    {
        private readonly HttpClient _httpClient;
        private readonly IExternalServices _externalServices;
        private readonly IConfiguration _configuration;
        public MainBroker(IExternalServices externalServices, IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _externalServices = externalServices;
            _configuration = configuration;
        }
    }
}
