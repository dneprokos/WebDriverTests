using OpenQA.Selenium;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageSections.MainPageSections
{
    public class HeaderSection
    {
        public IWebElement HeaderMain => DriverInitialize.Browser.FindElement(By.ClassName("header-wrap"));

        public IWebElement HeaderTopBanner => DriverInitialize.Browser.FindElement(By.Id("ctl00_topBanner"));


    }
}
