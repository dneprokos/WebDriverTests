using OpenQA.Selenium;
using System;
using WebDriverOnCore.TestsInit;

namespace WebDriverOnCore.WebDriver
{
    public static class DriverInitialize
    {
        public static IWebDriver Browser { get; set; }

        public static IWebDriver GetWebDriver()
        {
            switch (TestRunSettings.GetBrowser)
            {
                case "Chrome":
                    Browser = BrowserFactory.CreateChromeDriver();
                    break;
                case "FireFox":
                    throw new NotImplementedException("Browser creation logic was not implemented");
                default:
                    throw new NotImplementedException("There is no such browser. Please use exists browsers");
            }

            return Browser;
        }


        
    }
}
