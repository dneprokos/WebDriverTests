using WebDriverOnCore.TestsInit;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.WebSiteNavigation
{
    public class NavigationSteps
    {
        /// <summary>
        /// Opens football.ua main page
        /// </summary>
        public void OpenWebSiteOnMainPage()
        {
            OpenWebSitePageOn(TestSettings.BaseUrl);
        }

        /// <summary>
        /// Opens website on requested page
        /// </summary>
        /// <param name="urlPath">Page you want to open</param>
        public void OpenWebSitePageOn(string urlPath)
        {
            DriverInitialize.Browser.Navigate().GoToUrl(urlPath);
        }
    }
}
