using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverOnCore.LoggerManager;

namespace WebDriverOnCore.TestsInit
{
    public static class BrowserFactory
    {
        public static IWebDriver CreateChromeDriver()
        {
            NLogManager.LogMessage.Info("Chrome WebDriver initialization was started");
            var options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Driver, LogLevel.All);
            options.AddArguments("--disable-notifications");
            options.AddArgument("--no-default-browser-check");
            options.AddArgument("--disable-component-update");
            options.AddArgument("disable-infobars");
            options.AddUserProfilePreference("download.default_directory", Environment.CurrentDirectory);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("profile.default_content_settings.popups", 0);
            options.AddUserProfilePreference("disable-popup-blocking", true);
            var service = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory);

            return new ChromeDriver(service, options);
        }
    }
}
