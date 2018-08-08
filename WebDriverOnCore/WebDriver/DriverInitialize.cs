using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverOnCore.WebDriver
{
    public static class DriverInitialize
    {
        public static IWebDriver GetWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-infobars");
            IWebDriver webDriver = new ChromeDriver(options);

            return webDriver;
        }
    }
}
