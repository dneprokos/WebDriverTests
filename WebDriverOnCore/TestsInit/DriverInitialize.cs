using OpenQA.Selenium;
using System;
using WebDriverOnCore.LoggerManager;
using WebDriverOnCore.TestsInit;

namespace WebDriverOnCore.WebDriver
{
    public static class Driver
    {
        public static IWebDriver CurrentBrowser { get; private set; }
 

        /// <summary>
        /// Gets browser from Test.runsettings or return exception
        /// </summary>
        /// <returns></returns>
        public static IWebDriver Start()
        {
            switch (TestSettings.GetBrowser)
            {
                case nameof(BrowserType.Chrome):
                    CurrentBrowser = BrowserFactory.CreateChromeDriver();
                    NLogManager.LogMessage.Info("Chrome WebDriver was created");
                    break;
                case nameof(BrowserType.Firefox):
                    throw new NotImplementedException("Browser creation logic was not implemented");
                default:
                    throw new NotImplementedException("There is no such browser. Please use exists browsers");
            }

            return CurrentBrowser;
        }


        
    }
}
