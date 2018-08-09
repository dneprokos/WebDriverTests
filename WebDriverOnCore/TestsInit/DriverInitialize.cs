using OpenQA.Selenium;
using System;
using WebDriverOnCore.TestsInit;

namespace WebDriverOnCore.WebDriver
{
    public static class DriverInitialize
    {
        private static IWebDriver _browser;
        public static IWebDriver Browser { get => _browser; private set => _browser = value; }

        /// <summary>
        /// Gets browser from Test.runsettings or return exception
        /// </summary>
        /// <returns></returns>
        public static IWebDriver Start()
        {
            switch (TestSettings.GetBrowser)
            {
                case nameof(BrowserType.Chrome):
                    Browser = BrowserFactory.CreateChromeDriver();
                    break;
                case nameof(BrowserType.Firefox):
                    throw new NotImplementedException("Browser creation logic was not implemented");
                default:
                    throw new NotImplementedException("There is no such browser. Please use exists browsers");
            }

            return Browser;
        }


        
    }
}
