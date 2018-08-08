
using System.Configuration;

namespace WebDriverOnCore.TestUntillities
{
    public static class GetUrl
    {
        public static string BaseUrl = ConfigurationManager.AppSettings["baseUrl"];
    }
}
