using WebDriverOnCore.LoggerManager;
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
            NLogManager.LogMessage.Info("Opening of main page...");
            OpenWebSitePageOn(TestSettings.BaseUrl);
            NLogManager.LogMessage.Info("Main page was opened");
        }

        /// <summary>
        /// Opens website on requested page
        /// </summary>
        /// <param name="urlPath">Page you want to open</param>
        public void OpenWebSitePageOn(string urlPath)
        {
            Driver.CurrentBrowser.Navigate().GoToUrl(urlPath);
        }
    }
}
