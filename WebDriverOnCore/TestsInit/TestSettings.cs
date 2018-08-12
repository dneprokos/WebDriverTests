using NUnit.Framework;

namespace WebDriverOnCore.TestsInit
{
    public static class TestSettings
    {
        public static string GetBrowser => TestContext.Parameters["browser"];

        public static string BaseUrl => TestContext.Parameters["baseUrl"];

        public static string NewsUrl => BaseUrl + TestContext.Parameters["newsPage"];

        public static string ScoreBoardUrl => BaseUrl + TestContext.Parameters["scoreboard"];

        public static string VideoUrl => BaseUrl + TestContext.Parameters["videoPage"];

        public static string PhotoUrl => BaseUrl + TestContext.Parameters["photoGaleryPage"];

        public static string TvScheduleUrl => BaseUrl + TestContext.Parameters["tvschedule"];

        public static string ConferencesUrl => BaseUrl + TestContext.Parameters["conferences"];

    }
}
