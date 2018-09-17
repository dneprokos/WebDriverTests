using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.TestUntillities
{
    public static class SeleniumExtension
    {
        public static IWebElement WaitUntilElementExists(By locator, int maxSeconds)
        {
            return new WebDriverWait(DriverInitialize.Browser, TimeSpan.FromSeconds(maxSeconds)).Until(dr => dr.FindElement(locator));               
        }

        public static IReadOnlyCollection<IWebElement> WaitUntilElementsExists(By locator, int maxSeconds)
        {
            return new WebDriverWait(DriverInitialize.Browser, TimeSpan.FromSeconds(maxSeconds)).Until(dr => dr.FindElements(locator));
        }
    }
}
