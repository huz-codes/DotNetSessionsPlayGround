namespace CleanArchitecture.Infrastracture.Brokers
{
    public partial class MainBroker
    {
        public string Put(string url, string content)
        {
            return $"{url} {content}";
        }
    }
}
