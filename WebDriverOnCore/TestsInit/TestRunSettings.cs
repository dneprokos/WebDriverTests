using NUnit.Framework;

namespace WebDriverOnCore.TestsInit
{
    public static class TestRunSettings
    {
        public static string GetBrowser => TestContext.Parameters["browser"];

        public static string BaseUrl => TestContext.Parameters["baseUrl"];
    }
}
